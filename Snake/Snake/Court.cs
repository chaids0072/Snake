using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    class Court
    {
        /*
         * Constant
         */
        public static readonly int BLOCKNUMBER = 20;

        /*
         * Form Constant
         */
        public static PictureBox picMain;
        public static Bitmap bitmap;
        public static Graphics graphic;

        /*
         * Points
         */
        public static Random rnd = new Random();
        public static SnakeItem snake = new SnakeItem();
        public static FoodItem food = new FoodItem();
    }
}
