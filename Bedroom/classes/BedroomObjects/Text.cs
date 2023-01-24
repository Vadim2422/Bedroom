using System.Drawing;


namespace Bedroom.classes.BedroomObjects
{
    public class Text : GraphicElement
    {
            public string text;
            public Text() { }
            public Text(string text, Point start, Point end) : base(start, end, "") 
            {
                this.text = text;
                path = null;
            }
            
            public override void draw(Graphics g)
            {
            Font font = new Font(FontFamily.GenericSerif, 25, FontStyle.Regular);
            Brush brush = new SolidBrush(Color.Black);
            g.DrawString(text, font, brush, start);
            }

    }
}
