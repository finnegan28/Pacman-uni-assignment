using System;
using System.Drawing;
using System.Linq;

namespace PacmanCOM377
{
    class MovingGhost : MovableCharacter
    {
        static Random rnd = new Random();
        //Initalizes the array for the ghost
        public Image[] ghostImage = new Image[2];
        public EyePosition currentEyePosition { get; set; }
        public enum EyePosition { Left, Right }
        public enum GhostColor { Red, Blue }
        public GhostColor Color { get; private set; }

        public MovingGhost(GhostColor color)
        {
            //Initalizes the instances of ghosts, images and starting positions
            switch (color)
            {
                case GhostColor.Red:
                    Position = new Point(22, 8);
                    ghostImage[(int)EyePosition.Left] = Images.redGhost_left;
                    ghostImage[(int)EyePosition.Right] = Images.redGhost_right;
                    break;
                case GhostColor.Blue:
                    Position = new Point(20, 8);
                    ghostImage[(int)EyePosition.Left] = Images.blueGhost_left;
                    ghostImage[(int)EyePosition.Right] = Images.blueGhost_right;
                    break;
                default:
                    break;
            }
            Color = color;
            stepsBeforeChangeDirection = rnd.Next(7);
            currentDirection = Direction.Up;
        }

        int stepsBeforeChangeDirection;

        Direction currentDirection;
        
        public void randomMove(Cell[,] cells)
        {
            CharTick();


            //stores the next random number in an integer
            if (stepsBeforeChangeDirection--<0)
            {
                stepsBeforeChangeDirection = rnd.Next(7);
                currentDirection = (Direction)rnd.Next(4);
            }

             

            //begin the switch statement with the random number as the parameter
            switch (currentDirection)
            {
                case Direction.Right:
                    if ("o.!c".Any(cellType => cellType == cells[Position.Y, Position.X + 1].CellType))     //determines if any of the cells match the characters in the string "o.!c" which represent
                    {                                                                                       //tiles which can be navigated
                        Move(Direction.Right);
                    }
                    break;
                case Direction.Left:
                    if ("o.!c".Any(cellType => cellType == cells[Position.Y, Position.X - 1].CellType))
                    {
                        Move(Direction.Left);
                    }
                    break;
                case Direction.Down:
                    if ("o.!c".Any(cellType => cellType == cells[Position.Y + 1, Position.X].CellType))
                    {
                        Move(Direction.Down);
                    }
                    break;
                case Direction.Up:
                    if ("o.!c".Any(cellType => cellType == cells[Position.Y - 1, Position.X].CellType))
                    {
                        Move(Direction.Up);
                    }
                    break;
            }
        }



        //Draws the ghost
        public override Image CurrentImage => ghostImage[(int)currentEyePosition];

        public override void CharTick() => currentEyePosition = (currentEyePosition == EyePosition.Left)? EyePosition.Right : EyePosition.Left;
        
    }

}


