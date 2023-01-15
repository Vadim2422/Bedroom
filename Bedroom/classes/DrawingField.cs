using Bedroom.classes.BedroomObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bedroom.classes
{
    public class DrawingField
    {
        public Bitmap pic;
        public Bitmap pic1;
        public Graphics g;
        public Graphics g1;
        public PictureBox picture;
        public void DrawWall(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            Wall wall = new Wall(start, end);
            wall.draw(g1);
            picture.Image = pic1;
        }

        public void DrawBed(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            string path = "..\\..\\src\\Bed.png";
            Bed bed = new Bed(start, end);
            bed.path = path;
            bed.draw(g1);
            picture.Image = pic1;
        }
    }
}
