using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Snake
{
    class PaintItem
    {
        public static void paint()
        {
            Court.graphic.Clear(Color.White);
            paintGrid();
            paintSnake();
            paintFood();
            Court.picMain.Image = Court.bitmap;
        }

        private static void paintFood()
        {
            float blockSizeWidth = (Court.picMain.Width / Court.BLOCKNUMBER);
            float blockSizeHeigh = (Court.picMain.Height / Court.BLOCKNUMBER);
            Court.graphic.FillRectangle(Brushes.Red, Court.food.pzn.X * blockSizeWidth, Court.food.pzn.Y * blockSizeHeigh, blockSizeWidth, blockSizeHeigh);
        }

        private static void paintSnake()
        {
            float blockSizeWidth = (Court.picMain.Width / Court.BLOCKNUMBER);
            float blockSizeHeigh = (Court.picMain.Height / Court.BLOCKNUMBER);

            for (int i = 0; i < Court.snake.lstFlies.Count; i++)
            {
                PointF temp = Court.snake.lstFlies[i];
                Court.graphic.FillRectangle(Brushes.Black, temp.X * blockSizeWidth, temp.Y * blockSizeHeigh, blockSizeWidth, blockSizeHeigh);
            }
        }

        private static void paintGrid()
        {
            Pen p = new Pen(Color.Black);

            for (int y = 0; y < Court.BLOCKNUMBER; ++y)
            {
                Court.graphic.DrawLine(p, 0, y * (Court.picMain.Height / Court.BLOCKNUMBER), Court.picMain.Width, y * (Court.picMain.Height / Court.BLOCKNUMBER));
            }

            for (int x = 0; x < Court.BLOCKNUMBER; ++x)
            {
                Court.graphic.DrawLine(p, x * (Court.picMain.Width / Court.BLOCKNUMBER), 0, x * (Court.picMain.Width / Court.BLOCKNUMBER), Court.picMain.Height);
            }
        }
    }
}
