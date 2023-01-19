using Bedroom.classes;
using Bedroom.classes.BedroomObjects;
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
        DataObjects data = new DataObjects();
        GraphicElement last_object = null;
        public string mode = "Wall";
        public Point click;
        string size = null;
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
            if (e.Button == MouseButtons.Left)
            {
                click = new Point(e.X, e.Y);
                if (mode == "Drag_and_Drop" || mode == "Change_Size" || mode == "Delete_Element")
                {
                    data.search_figure(click);
                    if (data.moving_element!= null)
                        data.draw_pic_without_element(draw.g);
                }

                

                if (mode == "Turning")
                {
                    data.search_figure(click);
                    data.draw_pic_without_element(draw.g);
                    if (data.moving_element != null)
                    {
                        if (data.moving_element.path != null)
                        {
                            data.moving_element.angle += 90;
                            if (data.moving_element.angle >= 360)
                                data.moving_element.angle= 0;
                            
                                
                                
                                
                                data.moving_element.end = new Point(data.moving_element.start.X + (data.moving_element.end.Y - data.moving_element.start.Y), data.moving_element.start.Y + (data.moving_element.end.X - data.moving_element.start.X));
                            
                            data.moving_element.draw(draw.g);
                            draw.picture.Image = draw.pic;
                        }
                        
                    }
                }
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                switch (mode)
                {
                    case "Wall":
                        last_object = draw.DrawWall(click, new Point(e.X, e.Y));
                        break;
                    case "Bed":
                        Bed bed = new Bed(click, new Point(e.X, e.Y));
                        last_object = draw.DrawPicture(bed);
                        break;
                    case "BedsideTable":
                        BedsideTable bedsideTable = new BedsideTable(click, new Point(e.X, e.Y));
                        last_object = draw.DrawPicture(bedsideTable); 
                        break;
                    case "Computer":
                        Computer computer = new Computer(click, new Point(e.X, e.Y));
                        last_object = draw.DrawPicture(computer);
                        break;
                    case "Wardrobe":
                        Wardrobe wardrobe = new Wardrobe(click, new Point(e.X, e.Y));
                        last_object = draw.DrawPicture(wardrobe); 
                        break;
                    case "Window":
                        Window window = new Window(click, new Point(e.X, e.Y));
                        last_object = draw.DrawPicture(window); 
                        break;
                    case "Door":
                        Door door = new Door(click, new Point(e.X, e.Y));
                        last_object = draw.DrawPicture(door); 
                        break;
                    case "Arrow":
                        Arrow arrow = new Arrow(click, new Point(e.X, e.Y));
                        last_object = draw.DrawPicture(arrow);
                        break;
                    case "Lamp":
                        Lamp lamp = new Lamp(click, new Point(e.X, e.Y));
                        last_object = draw.DrawPicture(lamp);
                        break;
                    case "Armchair":
                        Armchair armchair = new Armchair(click, new Point(e.X, e.Y));
                        last_object = draw.DrawPicture(armchair);
                        break;
                    case "Drag_and_Drop":
                        if (data.moving_element != null)
                        {
                            data.moving_element.move(draw, click, new Point(e.X, e.Y));
                            click = new Point(e.X, e.Y);
                        }
                        break;
                    case "Change_Size":
                        if (data.moving_element != null)
                        {
                            data.moving_element.end = new Point(data.moving_element.end.X + (e.X - click.X), data.moving_element.end.Y + (e.Y - click.Y));
                            draw.g1.Clear(Color.Transparent);
                            draw.g1.DrawImage(draw.pic, 0, 0);
                            data.moving_element.draw(draw.g1);
                            click = new Point(e.X, e.Y);
                            draw.picture.Image = draw.pic1;
                        }
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
                case "BedsideTable":
                case "Computer":
                case "Wardrobe":
                case "Window":
                case "Door":
                case "Arrow":
                case "Lamp":
                case "Armchair":
                    draw.g.DrawImage(draw.pic1, 0, 0);
                    pictureBox1.Image = draw.pic;
                    data.elements.Insert(0, last_object);
                    break;
                case "Size_text":
                    if (size == null) break;
                    last_object = draw.DrawText(size, click, new Point(e.X, e.Y));
                    draw.g.DrawImage(draw.pic1, 0, 0);
                    pictureBox1.Image = draw.pic;
                    data.elements.Insert(0, last_object);
                    break;
                case "Drag_and_Drop":
                    if (data.moving_element != null)
                    {
                        data.moving_element.draw(draw.g);
                        data.elements.Insert(0, data.moving_element);
                        data.elements.RemoveAt(data.elements.LastIndexOf(data.moving_element));
                        pictureBox1.Image = draw.pic;
                    }
                    break;
                case "Change_Size":
                    if (data.moving_element != null)
                    {
                        draw.g.DrawImage(draw.pic1, 0, 0);
                        pictureBox1.Image = draw.pic;
                    }
                    break;
                case "Delete_Element":
                    data.elements.Remove(data.moving_element);
                    pictureBox1.Image = draw.pic;
                    break;

            }
        }

        

        private void clear(object sender, EventArgs e)
        {
            draw.g.Clear(Color.White);
            draw.picture.Image= draw.pic;
            data.elements.Clear();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog
            {
                Title = "Открыть файл как...",
                CheckPathExists = true,
                Filter = "Image Files(*.jpg)|*.jpg|Image Files(*.png)|*.png|XML Files(*.xml)|*.xml",
                ShowHelp = true
            };
            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (opendialog.FileName.EndsWith(".xml"))
                    {
                        data.deSerializeXML(opendialog.FileName);
                        data.draw_all_element(draw.g);
                        draw.picture.Image = draw.pic;
                    }
                    if (opendialog.FileName.EndsWith(".jpg") || opendialog.FileName.EndsWith(".png"))
                    {
                        draw.g.Clear(Color.White);
                        draw.g.DrawImage(Image.FromFile(opendialog.FileName), 0, 0);
                        draw.picture.Image = draw.pic;
                    }

                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить файл как...";
            savedialog.OverwritePrompt = true;
            savedialog.Filter = "Image Files(*.jpg)|*.jpg|Image Files(*.png)|*.png|XML Files(*.xml)|*.xml";
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (savedialog.FileName.EndsWith(".xml"))
                    {
                        data.SerializeXML(savedialog.FileName);
                        MessageBox.Show("Файл сохранен", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (savedialog.FileName.EndsWith(".jpg") || savedialog.FileName.EndsWith(".png"))
                    {
                        draw.pic.Save(savedialog.FileName);
                        MessageBox.Show("Файл сохранен", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить файл", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void change_mode(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            mode = item.Name;
            if (mode == "Size_text")
            {
               
                Form2 form = new Form2();

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (form.textBox1.Text != "")
                    {
                        size = form.textBox1.Text;
                    }
                }
                else size = null;
                form.Dispose();
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}

