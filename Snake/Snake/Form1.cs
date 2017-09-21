using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Court.picMain = pictureBox1;

            Court.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Court.graphic = Graphics.FromImage(Court.bitmap);

            PointF pzn = new PointF(0, 17);
            Court.snake.lstFlies.Add(pzn);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Your score is " + Court.snake.lstFlies.Count.ToString();
            UpdateItem.update();
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            Court.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Court.graphic = Graphics.FromImage(Court.bitmap);
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            UpdateItem.OnKeyDown(e.KeyCode);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PaintItem.paint();
        }
    }
}
