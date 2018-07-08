using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using PacmanCOM377;
using System.Media;

namespace PacmanCOM377
{
    public partial class PacmanGUI : Form
    {
        const int CellSize = 20; //Cell deminsion

        MovingPacman pacman = new MovingPacman();            //Pacman instance
        MovingGhost ghost = new MovingGhost(MovingGhost.GhostColor.Red);             //Ghost instance
        MovingGhost ghost2 = new MovingGhost(MovingGhost.GhostColor.Blue);            //Ghost 2 instance



        List<MovableCharacter> characters;



        private Cell[,] cells;                               // Cells make up an array that make up the map
        public Image[] pacmanLeftImage = new Image[16];      //Pacmn images are created
        public int currentMouthPosition { get; set; }        //Pacman mouth position is set 
        public int currentEyePosition { get; set; }         //Pacman mouth postion is set
        public Image[] ghostImage = new Image[2];           //Array of ghost images is created
        private int mapWidth;                               // width of map is set in tiles
        private int mapHeight;                              // height of the map is set in tiles

        
        //sounds made for pacman eating, eating a power up and dying 
        SoundPlayer eat = new SoundPlayer("..\\..\\Sounds\\pacman_chomp.wav");
        SoundPlayer powerup = new SoundPlayer("..\\..\\Sounds\\pacman_powerup.wav");
        SoundPlayer death = new SoundPlayer("..\\..\\Sounds\\pacman_death.wav");

        // custom delegate has been created
        public delegate void ScoreChangedEventHandler(object Source, ScoreInfoEventArgs e);
        // public event EventHandler ScoreChanged;
        public event ScoreChangedEventHandler ScoreChanged;
        //creates a custom delegate
        public delegate void LivesChangedEventHandler(object Source, LiveInfoEventArgs e);
        //......
        public event LivesChangedEventHandler LivesChanged;

        private int score = 0;        //Sets the score to 0
        private int lives = 3;        //Sets the lives to 3


        Random rnd = new Random();

        public class ScoreInfoEventArgs : EventArgs        // creates the scoreinfo delegate handling class

        {
            public int score = 0;            //sets the score to 0

            public ScoreInfoEventArgs(int score)
            {
                this.score = score;
            }

            public int Score            //gets the score and sets it as "value"
            {
                get { return score; }
                set { score = value; }
            }
        }


        protected virtual void OnScoreChanged(ScoreInfoEventArgs e)
        {   //if the score changes it converts the interger number of pellets to a string and print it through a textbox
            if (ScoreChanged != null) ScoreChanged(this, e);
            this.ScoreBox.Text = e.score.ToString();
            if (this.ScoreBox.Text == "2200")
            {
                WinDisplay winner = new WinDisplay();
                winner.Show();                              //Shows the winner display when points have been reached
            }
        }

        // 
        public class LiveInfoEventArgs : EventArgs
        {
            public int lives = 3;

            public LiveInfoEventArgs(int lives)
            {
                this.lives = lives;
            }

            public int Lives
            {
                get { return lives; }
                set { lives = value; }
            }
        }

        protected virtual void OnLiveChanged(LiveInfoEventArgs e)
        {
            int value;

            if (LivesChanged != null) LivesChanged(this, e);
            this.RemainingLivesTextBox.Text = e.lives.ToString();

            if (Int32.TryParse(RemainingLivesTextBox.Text, out value))
            {
                if (value < 1)
                {
                    LoseDisplay loser = new LoseDisplay();
                    loser.Show();
                }
            }

        }

        // the components are inaitilized
        public PacmanGUI()
        {
            InitializeComponent();
            SoundPlayer backgroundsound = new SoundPlayer("..\\..\\Sounds\\pacman_beginning.wav");
            backgroundsound.PlayLooping();

        }

        public void PacmanGUI_Load(object sender, EventArgs e)
        {
            characters = new MovableCharacter [] { ghost, ghost2, pacman }.ToList();

          if (readMapFileDialog.ShowDialog() == DialogResult.OK)              //reads the file
            {
                String mapFile = readMapFileDialog.FileName;
                //cell array is created
                CreateCellArray(mapFile);
                //sets picture box 
                mapPictureBox.Height = mapHeight * CellSize;
                mapPictureBox.Width = mapWidth * CellSize;
                mapPictureBox.BackColor = Color.Black;

            }
            else
            {
                //pa message pops up asking the user to select a file
                MessageBox.Show(new Form() { TopMost = true }, "Please select a map file to continue", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                Application.Exit();
            }
            this.BackColor = Color.Black;
        }

        /// reads the map file and creates an array
        public void CreateCellArray(string level)
        {
            ArrayList lineList = new ArrayList();

            string line = null;

            try
            {
                
                StreamReader levelData = new StreamReader(level);
                while ((line = levelData.ReadLine()) != null)
                {
                    lineList.Add(line);
                }
            }
            catch (System.IO.IOException exc)
            {
                Console.Write(exc.Message);
            }
            mapHeight = lineList.Count;            //height is determined
            string width = lineList[0] as string;            //width is determined
            mapWidth = width.Length;

            // cells are then created
            cells = new Cell[mapHeight, mapWidth];
            for (int row = 0; row < mapHeight; row++)
            {
                string hLine = lineList[row] as string;
                for (int column = 0; column < mapWidth; column++)
                {
                    
                    char type = hLine[column];
                    cells[row, column] = new Cell(column, row, type);
                }
            }
        }


        //paint event handler      
        public void mapPictureBox_Paint(object sender, PaintEventArgs e)
        {
            //creates an instance of the graphics class
            Graphics g = e.Graphics;

            // Outer loop loops through each row in the array
            for (int row = 0; row < mapHeight; row++)
            {
                // Inner loop loops through each column in the array
                for (int column = 0; column < mapWidth; column++)
                {
                    cells[row, column].drawBackground(g);
                }
                characters.ForEach(c => g.DrawImage(c.CurrentImage, CellSize * c.Position.X, CellSize * c.Position.Y,20,20));
            }
        }

        Dictionary<Keys, Direction> Key2Dir = new Dictionary<Keys, Direction>()
        {
            {Keys.Down,Direction.Down },
            {Keys.Up, Direction.Up },
            {Keys.Right,Direction.Right },
            {Keys.Left,Direction.Left }
        };

        private void PacmanGUI_KeyDown(object sender, KeyEventArgs e)
        {
            //On keydown
            if (Key2Dir.ContainsKey(e.KeyCode))
            {
                // loads down and sets the facing to 0
                pacman.pacmanFacing = Key2Dir[e.KeyCode];
                // checks for collision
                checkCollision();
            }          

            // on key P
            else if (e.KeyCode == Keys.P)
            {
                //stops all the timers
                pacmanTimer.Stop();
                ghostTimer.Stop();
                ghost2Timer.Stop();
            }

            //on key r
            else if (e.KeyCode == Keys.R)
            {
                //start all the timers
                pacmanTimer.Start();
                ghostTimer.Start();
                ghost2Timer.Start();
            }
            mapPictureBox.Invalidate();
        }

        // start button
        private void Start_Click(object sender, EventArgs e)
        {
            pacmanTimer.Start();
            ghostTimer.Start();
            ghost2Timer.Start();
        }
        // pause button
        private void Pause_Click(object sender, EventArgs e)
        {
            pacmanTimer.Stop();
            ghostTimer.Stop();
            ghost2Timer.Stop();
        }

        //resume button
        private void Resume_Click(object sender, EventArgs e)
        {
            pacmanTimer.Start();
            ghostTimer.Start();
            ghost2Timer.Start();
        }

        //selects the map file to use 
        private void readMapFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        //unmute sound button
        private void unmuteSound_Click(object sender, EventArgs e)
        {
            SoundPlayer backgroundsound = new SoundPlayer("..\\..\\Sounds\\pacman_beginning.wav");
            backgroundsound.PlayLooping();
        }

        //mute sound button
        private void muteSound_Click_1(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            sound.Stop();
        }

        //color dialog button for background
        private void backgroundColour_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            mapPictureBox.BackColor = colorDialog1.Color;
        }

        //restart button
        private void RestartBtn_Click(object sender, EventArgs e)
        {
            pacmanTimer.Stop();
            ghostTimer.Stop();
            ghost2Timer.Stop();
            lives = 3; 
        }


        // checking collision
        public void checkCollision()
        {

            //checks if rectangles intersect 
            if (pacman.Intersect(ghost) || pacman.Intersect(ghost2))
            {

                //checks LiveInfoEventArgs to see how many lives are left
                LiveInfoEventArgs CurrentLives = new LiveInfoEventArgs(lives);
                OnLiveChanged(CurrentLives);
                lives -= 1;

                //resets pacman to the starting position
                death.Play();

                pacman.Position = new Point(21, 13);

                //restarts the timer    
                pacmanTimer.Start();
            }


        }
        // pacman and ghost timers starts

        private void pacmanTimer_Tick(object sender, EventArgs e)
        {
            //performs action based on the cell pacman interacts with
            switch (pacman.Move(cells))
            {
                case MovingPacman.MoveResult.None:
                    break;
                case MovingPacman.MoveResult.Pill:
                    score += 10;
                    ScoreInfoEventArgs currentScore = new ScoreInfoEventArgs(score);
                    OnScoreChanged(currentScore);
                    eat.Play();
                    break;
                case MovingPacman.MoveResult.PowerPellet:
                    score += 50;
                    powerup.Play();
                    break;
                default:
                    break;
            }
            mapPictureBox.Invalidate();
        }

        private void ghostTimer_Tick(object sender, EventArgs e)
        {
            ghost.randomMove(cells);
        }

        private void ghost2Timer_Tick(object sender, EventArgs e)
        {
            ghost2.randomMove(cells);
        }


    }
    }
