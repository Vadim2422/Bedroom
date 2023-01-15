using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bedroom.classes.BedroomObjects
{
    public class Wall : GraphicElement
    {
        Pen pen = new Pen(Color.Black, 5);
        public Wall(Point start, Point end) : base(start, end) {}
        public Wall() {}

        public override void draw(Graphics g)
        {
            g.DrawLine(pen, start, end);
        }
    }
}
