using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    class SnakeItem
    {
        public enum DirectionType { Up = 0, Right = 1, Down = 2, Left = 3};
        public DirectionType direction = DirectionType.Right;
        public DirectionType intendDirection;
        public PointF spd = new PointF(1, 0);
        public List<PointF> lstFlies = new List<PointF>(3);

        public void UpdateDirction()
        {
            PointF temp = new PointF(Court.snake.lstFlies[0].X+Court.snake.spd.X, Court.snake.lstFlies[0].Y + Court.snake.spd.Y);

            if (Court.snake.lstFlies.Contains(temp))
            {
                Application.Restart();
                //MessageBox.Show("Game Over");
            }
            /*
             * x-axis moving direction
             */
            if (temp.X >= Court.BLOCKNUMBER)
            {
                temp.X -= temp.X;
            }
            else if (temp.X < 0)
            {
                temp.X = Court.BLOCKNUMBER - 1;
            }

            /*
             * Y-axis moving direction
             */
            if (temp.Y >= Court.BLOCKNUMBER)
            {
                temp.Y -= temp.Y;
            }
            else if (temp.Y < 0)
            {
                temp.Y = Court.BLOCKNUMBER - 1;
            }

            Court.snake.lstFlies.Insert(0,temp);
            Court.snake.lstFlies.RemoveAt(Court.snake.lstFlies.Count-1);
        }

        public void UpdateSpeed()
        {
            if (Math.Abs(getRealDirection() - intendDirection) != 2)
            {
                switch (intendDirection)
                {
                    case DirectionType.Left:
                        Court.snake.spd.X = -1;
                        Court.snake.spd.Y = 0;
                        break;
                    case DirectionType.Right:
                        Court.snake.spd.X = 1;
                        Court.snake.spd.Y = 0;
                        break;
                    case DirectionType.Up:
                        Court.snake.spd.X = 0;
                        Court.snake.spd.Y = -1;
                        break;
                    case DirectionType.Down:
                        Court.snake.spd.X = 0;
                        Court.snake.spd.Y = 1;
                        break;
                    default:
                        break;
                }
                intendDirection = getRealDirection();
            }
        }

        public SnakeItem.DirectionType getRealDirection()
        {
            if (spd.X > 0 && spd.Y == 0)
            {
                this.direction = DirectionType.Right;
            }
            else if (spd.X < 0 && spd.Y == 0)
            {
                this.direction = DirectionType.Left;
            }
            else if (spd.X == 0 && spd.Y < 0)
            {
                this.direction = DirectionType.Up;

            }
            else if (spd.X == 0 && spd.Y > 0)
            {
                this.direction = DirectionType.Down;
            }

            return this.direction;
        }
    }
}
