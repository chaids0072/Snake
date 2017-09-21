using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Snake
{
    class FoodItem
    {
        public PointF pzn = new PointF(9, 9);
        public PointF predictedLocation;

        public void UpdateLength()
        {
            switch (Court.snake.intendDirection)
            {
                case SnakeItem.DirectionType.Left:
                    predictedLocation.X = -1;
                    predictedLocation.Y = 0;
                    break;
                case SnakeItem.DirectionType.Right:
                    predictedLocation.X = 1;
                    predictedLocation.Y = 0;
                    break;
                case SnakeItem.DirectionType.Up:
                    predictedLocation.X = 0;
                    predictedLocation.Y = -1;
                    break;
                case SnakeItem.DirectionType.Down:
                    predictedLocation.X = 0;
                    predictedLocation.Y = 1;
                    break;
                default:
                    break;
            }

            if (pzn.X - predictedLocation.X == Court.snake.lstFlies[0].X && 
                pzn.Y - predictedLocation.Y == Court.snake.lstFlies[0].Y) 
            {
                Court.snake.lstFlies.Insert(0, pzn);
                PointF foodTemp = new PointF();

                while (true) {
                    int foodX = Court.rnd.Next(Court.BLOCKNUMBER);
                    int foodY = Court.rnd.Next(Court.BLOCKNUMBER);
                    foodTemp = new PointF(foodX, foodY);
                    if (!Court.snake.lstFlies.Contains(foodTemp)) {
                        this.pzn = foodTemp;
                        break;
                    }                    
                }
            }
        }
    }
}
