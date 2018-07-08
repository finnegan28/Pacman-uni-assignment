using System;
using System.Drawing;

namespace PacmanCOM377
{
    abstract class MovableCharacter
    {
        public Point Position; //character position

        public void Move(Direction dir) //Moves pacman using a switch statement to determine direction, moving him 1 cell
        {
            switch (dir)
            {
                case Direction.Up:
                    Position.Offset(0, -1);
                    break;
                case Direction.Down:
                    Position.Offset(0, 1);
                    break;
                case Direction.Left:
                    Position.Offset(-1, 0);
                    break;
                case Direction.Right:
                    Position.Offset(1, 0);
                    break;
                default:
                    break;
            }
        }

        
        public void MoveBack(Direction dir)
        {
            switch (dir)
            {
                case Direction.Up:
                    Position.Offset(0, 1);
                    break;
                case Direction.Down:
                    Position.Offset(0, -1);
                    break;
                case Direction.Left:
                    Position.Offset(1, 0);
                    break;
                case Direction.Right:
                    Position.Offset(-1, 0);
                    break;
                default:
                    break;
            }
        }

        //Determines if a collision has occurred by returning an absolute value
        public bool Intersect(MovableCharacter other) => Math.Abs(Position.X-other.Position.X)<= 1 && Math.Abs(Position.Y-other.Position.Y)<=1 ;        
        //gets the current character image
        public virtual Image CurrentImage { get;}

        public abstract void CharTick();
    }
    // enum for direction images
    public enum Direction
    {
        Down, Up, Left, Right
    }


}
