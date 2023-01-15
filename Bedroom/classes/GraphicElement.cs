using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bedroom.classes
{
    public abstract class GraphicElement
    {
        public Point start;
        public Point end;
        public string path = null;
        public string type = "Photo";

        public GraphicElement(Point start, Point end) 
        {
            this.start = start;
            this.end = end; 
        }

        public virtual void draw (Graphics g)
        {
            Rectangle rect = new Rectangle(start, new Size(end.X - start.X, end.Y - start.Y));
            g.DrawImage(Image.FromFile(path), rect);
        }
    }
}
