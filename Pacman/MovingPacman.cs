using System.Drawing;
using System.Linq;

namespace PacmanCOM377
{
    class MovingPacman : MovableCharacter
    {
        //pacman image array
        public Image[,] pacmanImage = new Image[4,4];
        public MouthState currentMouthState { get; set; }
        public Direction pacmanFacing { get; set; }

        //enum for move result
        public enum MoveResult
        {
            None, Pill, PowerPellet
        }
        //enum for pacman mouth states
        public enum MouthState
        {
            Closed,Open,Wide,Widest
        }              
        //initialize instance of pacman
        public MovingPacman()
        {
            Position = new Point(21, 13);

            pacmanImage[(int)Direction.Left, (int)MouthState.Closed] = Images.pac32_left_close;
            pacmanImage[(int)Direction.Left, (int)MouthState.Open] = Images.pac32_left_open;
            pacmanImage[(int)Direction.Left, (int)MouthState.Wide] = Images.pac32_left_wide;
            pacmanImage[(int)Direction.Left, (int)MouthState.Widest] = Images.pac32_left_widest;

            pacmanImage[(int)Direction.Down, (int)MouthState.Closed] = Images.pac32_down_close;
            pacmanImage[(int)Direction.Down, (int)MouthState.Open] = Images.pac32_down_open;
            pacmanImage[(int)Direction.Down, (int)MouthState.Wide] = Images.pac32_down_wide;
            pacmanImage[(int)Direction.Down, (int)MouthState.Widest] = Images.pac32_down_widest;

            pacmanImage[(int)Direction.Right, (int)MouthState.Closed] = Images.pac32_right_close;
            pacmanImage[(int)Direction.Right, (int)MouthState.Open] = Images.pac32_right_open;
            pacmanImage[(int)Direction.Right, (int)MouthState.Wide] = Images.pac32_right_wide;
            pacmanImage[(int)Direction.Right, (int)MouthState.Widest] = Images.pac32_right_widest;

            pacmanImage[(int)Direction.Up, (int)MouthState.Closed] = Images.pac32_up_close;
            pacmanImage[(int)Direction.Up, (int)MouthState.Open] = Images.pac32_up_open;
            pacmanImage[(int)Direction.Up, (int)MouthState.Wide] = Images.pac32_up_wide;
            pacmanImage[(int)Direction.Up, (int)MouthState.Widest] = Images.pac32_up_widest;
        }       
       

        public override Image CurrentImage => pacmanImage[(int)pacmanFacing, (int)currentMouthState];

        public override void CharTick() => currentMouthState =(MouthState) (((int)currentMouthState + 1) % 4);

        public MoveResult Move(Cell[,] cells)
        {
            CharTick();

            Point currentPosition = Position;
            Cell currentCell = cells[currentPosition.Y, currentPosition.X];
            Move(pacmanFacing);
            Point nextPosition = Position;
            Cell nextCell = cells[nextPosition.Y, nextPosition.X];

            if ("o.!".Contains(nextCell.CellType))
            {
                if (nextCell.IsVisible)
                {
                    if (nextCell.CellType == '.')
                    {
                        currentCell.IsVisible = false;
                        return MoveResult.Pill;
                    }
                    else if (nextCell.CellType == '!')
                    {
                        currentCell.IsVisible = false;
                        return MoveResult.PowerPellet;
                    }
                    
                }
            }
            else
            {
                MoveBack(pacmanFacing);
            }
            return MoveResult.None;
        }
        
    }

}


