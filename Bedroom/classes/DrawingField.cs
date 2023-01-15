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
        private string path_dir = "D:\\src\\";
        public GraphicElement DrawWall(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            Wall wall = new Wall(start, end);
            wall.draw(g1);
            picture.Image = pic1;
            return wall;
        }

        public GraphicElement DrawBed(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            
            string path = path_dir + "Bed.png";
            Bed bed = new Bed(start, end)
            {
                path = path
            };
            bed.draw(g1);
            picture.Image = pic1;
            return bed;
        }
        public GraphicElement DrawBedsideTable(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            string path = path_dir + "BedsideTable.png";
            BedsideTable bedsideTable = new BedsideTable(start, end)
            {
                path = path
            };
            bedsideTable.draw(g1);
            picture.Image = pic1;
            return bedsideTable;
        }

        public GraphicElement DrawComputer(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            string path = path_dir + "Computer.png";
            Computer computer = new Computer(start, end)
            {
                path = path
            };
            computer.draw(g1);
            picture.Image = pic1;
            return computer;
        }

        public GraphicElement DrawWardrobe(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            string path = path_dir + "Wardrobe.png";
            Wardrobe wardrobe = new Wardrobe(start, end)
            {
                path = path
            };
            wardrobe.draw(g1);
            picture.Image = pic1;
            return wardrobe;
        }

        public GraphicElement DrawWindow(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            string path = "Window.png";
            Window window = new Window(start, end)
            {
                path = path
            };
            window.draw(g1);
            picture.Image = pic1;
            return window;
        }

        public GraphicElement DrawDoor(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            string path = path_dir + "Door.png";
            Door door = new Door(start, end)
            {
                path = path
            };
            door.draw(g1);
            picture.Image = pic1;
            return door;
        }

        public GraphicElement DrawArrow(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            string path = path_dir + "Size.png";
            BedroomObjects.Size size = new BedroomObjects.Size(start, end)
            {
                path = path
            };
            size.draw(g1);
            picture.Image = pic1;
            return size;
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

        public GraphicElement DrawLamp(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            string path = path_dir + "Lamp.png";
            Lamp lamp = new Lamp(start, end)
            {
                path = path
            };
            lamp.draw(g1);
            picture.Image = pic1;
            return lamp;
        }

        public GraphicElement DrawArmchair(Point start, Point end)
        {
            g1.Clear(Color.Transparent);
            g1.DrawImage(pic, 0, 0);
            string path = path_dir + "Armchair.png";
            Armchair armchair = new Armchair(start, end)
            {
                path = path
            };
            armchair.draw(g1);
            picture.Image = pic1;
            return armchair;
        }
    }
}
