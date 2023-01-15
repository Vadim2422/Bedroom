using Bedroom.classes.BedroomObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bedroom.classes
{
    [Serializable]
    [XmlInclude(typeof(GraphicElement))]
    [XmlInclude(typeof(Bed))]
    [XmlInclude(typeof(Wall))]
    [XmlInclude(typeof(BedsideTable))]
    [XmlInclude(typeof(Computer))]
    [XmlInclude(typeof(Door))]
    [XmlInclude(typeof(BedroomObjects.Size))]
    [XmlInclude(typeof(Table))]
    [XmlInclude(typeof(Text))]
    [XmlInclude(typeof(Wardrobe))]
    [XmlInclude(typeof(Window))]
    [XmlInclude(typeof(Lamp))]
    [XmlInclude(typeof(Armchair))]
    public class DataObjects
    {
        public List<GraphicElement> elements = new List<GraphicElement> { };

        [XmlIgnore]
        public GraphicElement moving_element;

        public DataObjects() {}

        public void search_figure(Point click)
        {
            moving_element = null;
            foreach (GraphicElement e in elements)
            {

                if (e.start.X <= e.end.X)
                {
                    if (!(click.X >= e.start.X && click.X <= e.end.X))
                    {
                        continue;
                    }



                }

                if (e.start.Y <= e.end.Y)
                {
                    if (!(click.Y >= e.start.Y && click.Y <= e.end.Y))
                    {
                        continue;
                    }

                }

                if (e.start.X >= e.end.X)
                {
                    if (!(click.X >= e.end.X && click.X <= e.start.X))
                    {
                        continue;
                    }



                }

                if (e.start.Y >= e.end.Y)
                {
                    if (!(click.Y >= e.end.Y && click.Y <= e.start.Y))
                    {
                        continue;
                    }

                }
                moving_element = e;
                return;


            }
        }


        public void draw_all_element(Graphics g)
        {
            g.Clear(Color.White);
            foreach (GraphicElement e in elements)
            {
                    e.draw(g);  
            }
        }

        public void draw_pic_without_element(Graphics g)
        {
            if (moving_element == null) return;
            g.Clear(Color.White);
            foreach (GraphicElement e in elements)
            {
                if (moving_element != e)
                {
                    e.draw(g);
                }
            }
        }

        public void SerializeXML(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(DataObjects));

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xml.Serialize(fs, this);
            }
        }

        public void deSerializeXML(string fileName)
        {
            elements.Clear();
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer xml = new XmlSerializer(typeof(DataObjects));
                DataObjects elements_tmp = xml.Deserialize(fs) as DataObjects;
                elements = elements_tmp.elements;
            }
        }
    }

}
