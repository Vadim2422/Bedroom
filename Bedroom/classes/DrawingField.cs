using Bedroom.classes.BedroomObjects;
using System.Drawing;
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
        public GraphicElement DrawWall(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            Wall wall = new Wall(start, end);
            wall.draw(g1);
            picture.Image = pic1;
            return wall;
        }

        public GraphicElement DrawPicture(GraphicElement element)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);

            element.draw(g1);
            picture.Image = pic1;
            return element;
        }

        public GraphicElement DrawText(string text_size, Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            Text size = new Text(text_size, start, end);
            size.draw(g1);
            picture.Image = pic1;
            return size;
        }


    }
}
