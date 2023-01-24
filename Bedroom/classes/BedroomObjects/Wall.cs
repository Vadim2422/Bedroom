using System.Drawing;


namespace Bedroom.classes.BedroomObjects
{
    public class Wall : GraphicElement
    {
        Pen pen = new Pen(Color.Black, 5);
        public Wall(Point start, Point end) : base(start, end, "")
        {
            path = null;
        }
        public Wall() {}

        public override void draw(Graphics g)
        {
            g.DrawLine(pen, start, end);
        }
    }
}
