using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    class UpdateItem
    {
        public static void update()
        {
            Court.food.UpdateLength();
            Court.snake.UpdateSpeed();
            Court.snake.UpdateDirction();
        }

        public static void OnKeyDown(Keys argKey)
        {
            switch (argKey)
            {
                case Keys.Left:
                    Court.snake.intendDirection = SnakeItem.DirectionType.Left;
                    break;
                case Keys.Right:
                    Court.snake.intendDirection = SnakeItem.DirectionType.Right;
                    break;
                case Keys.Up:
                    Court.snake.intendDirection = SnakeItem.DirectionType.Up;
                    break;
                case Keys.Down:
                    Court.snake.intendDirection = SnakeItem.DirectionType.Down;
                    break;
                default:
                    break;
            }
        }
    }
}
