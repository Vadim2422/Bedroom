using Bedroom.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bedroom
{
    public partial class Form1 : Form
    {
        DrawingField draw = new DrawingField();
        //PictureBox pictureBox1;

        public string mode = "Bed";
        public Point click;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
          
            InitializeComponent();
            
            
           


            draw.picture = pictureBox1;
            draw.pic = new Bitmap(1920, 1080);
            draw.pic1 = new Bitmap(1920, 1080);
            draw.g = Graphics.FromImage(draw.pic);
            draw.g.Clear(Color.White);
            draw.g1 = Graphics.FromImage(draw.pic1);

        }

       

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            click = new Point(e.X, e.Y);

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                switch (mode)
                {
                    case "Wall":
                        draw.DrawWall(click, new Point(e.X, e.Y));
                        break;
                    case "Bed":
                        draw.DrawBed(click, new Point(e.X, e.Y));
                       

                        break;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (mode)
            {
                case "Wall":
                case "Bed":
                    draw.g.DrawImage(draw.pic1, 0, 0);
                    pictureBox1.Image = draw.pic;
                    break;
         
            }
        }
    }
}
