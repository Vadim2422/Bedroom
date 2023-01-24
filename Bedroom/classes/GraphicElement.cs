using System.Drawing;


namespace Bedroom.classes
{
    public abstract class GraphicElement
    {
        public Point start;
        public Point end;
        public int angle = 0;
        public string path = "D:\\src\\";
        public GraphicElement(Point start, Point end, string path) 
        {
            this.start = start;
            this.end = end;
            this.path += path;
        }

        public GraphicElement() {}

        public virtual void draw (Graphics g)
        {
            Rectangle rect = new Rectangle(start, new Size(end.X - start.X, end.Y - start.Y));
            Image image = Image.FromFile(path);
            if (angle == 90) image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            if (angle == 180) image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            if (angle == 270) image.RotateFlip(RotateFlipType.Rotate270FlipNone);

            g.DrawImage(image, rect);
            
        }


        public void move(DrawingField drawF, Point click, Point new_location) 
        {
            drawF.g1.Clear(Color.White);
            drawF.g1.DrawImage(drawF.pic, 0, 0);
            start = new Point(start.X + (new_location.X - click.X), start.Y + (new_location.Y - click.Y));
            end = new Point(end.X + (new_location.X - click.X), end.Y + (new_location.Y - click.Y));
            draw(drawF.g1);
            drawF.picture.Image = drawF.pic1;
        }
    }
}
