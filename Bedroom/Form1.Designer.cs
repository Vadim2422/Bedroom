namespace Bedroom
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.элементыСпальниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Wall = new System.Windows.Forms.ToolStripMenuItem();
            this.Bed = new System.Windows.Forms.ToolStripMenuItem();
            this.BedsideTable = new System.Windows.Forms.ToolStripMenuItem();
            this.Lamp = new System.Windows.Forms.ToolStripMenuItem();
            this.Armchair = new System.Windows.Forms.ToolStripMenuItem();
            this.Computer = new System.Windows.Forms.ToolStripMenuItem();
            this.Wardrobe = new System.Windows.Forms.ToolStripMenuItem();
            this.Window = new System.Windows.Forms.ToolStripMenuItem();
            this.Door = new System.Windows.Forms.ToolStripMenuItem();
            this.Arrow = new System.Windows.Forms.ToolStripMenuItem();
            this.Size_text = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Drag_and_Drop = new System.Windows.Forms.ToolStripMenuItem();
            this.Turning = new System.Windows.Forms.ToolStripMenuItem();
            this.Change_Size = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_Element = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_map = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.элементыСпальниToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.Clear_map});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // элементыСпальниToolStripMenuItem
            // 
            this.элементыСпальниToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Wall,
            this.Bed,
            this.BedsideTable,
            this.Lamp,
            this.Armchair,
            this.Computer,
            this.Wardrobe,
            this.Window,
            this.Door,
            this.Arrow,
            this.Size_text});
            this.элементыСпальниToolStripMenuItem.Name = "элементыСпальниToolStripMenuItem";
            this.элементыСпальниToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.элементыСпальниToolStripMenuItem.Text = "Элементы спальни";
            // 
            // Wall
            // 
            this.Wall.Name = "Wall";
            this.Wall.Size = new System.Drawing.Size(180, 22);
            this.Wall.Text = "Стена";
            this.Wall.Click += new System.EventHandler(this.change_mode);
            // 
            // Bed
            // 
            this.Bed.Name = "Bed";
            this.Bed.Size = new System.Drawing.Size(180, 22);
            this.Bed.Text = "Кровать";
            this.Bed.Click += new System.EventHandler(this.change_mode);
            // 
            // BedsideTable
            // 
            this.BedsideTable.Name = "BedsideTable";
            this.BedsideTable.Size = new System.Drawing.Size(180, 22);
            this.BedsideTable.Text = "Тумбочка";
            this.BedsideTable.Click += new System.EventHandler(this.change_mode);
            // 
            // Lamp
            // 
            this.Lamp.Name = "Lamp";
            this.Lamp.Size = new System.Drawing.Size(180, 22);
            this.Lamp.Text = "Лампа";
            this.Lamp.Click += new System.EventHandler(this.change_mode);
            // 
            // Armchair
            // 
            this.Armchair.Name = "Armchair";
            this.Armchair.Size = new System.Drawing.Size(180, 22);
            this.Armchair.Text = "Кресло";
            this.Armchair.Click += new System.EventHandler(this.change_mode);
            // 
            // Computer
            // 
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(180, 22);
            this.Computer.Text = "Компьютер";
            this.Computer.Click += new System.EventHandler(this.change_mode);
            // 
            // Wardrobe
            // 
            this.Wardrobe.Name = "Wardrobe";
            this.Wardrobe.Size = new System.Drawing.Size(180, 22);
            this.Wardrobe.Text = "Шкаф";
            this.Wardrobe.Click += new System.EventHandler(this.change_mode);
            // 
            // Window
            // 
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(180, 22);
            this.Window.Text = "Окно";
            this.Window.Click += new System.EventHandler(this.change_mode);
            // 
            // Door
            // 
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(180, 22);
            this.Door.Text = "Дверь";
            this.Door.Click += new System.EventHandler(this.change_mode);
            // 
            // Arrow
            // 
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(180, 22);
            this.Arrow.Text = "Стрелка";
            this.Arrow.Click += new System.EventHandler(this.change_mode);
            // 
            // Size_text
            // 
            this.Size_text.Name = "Size_text";
            this.Size_text.Size = new System.Drawing.Size(180, 22);
            this.Size_text.Text = "Размер";
            this.Size_text.Click += new System.EventHandler(this.change_mode);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Drag_and_Drop,
            this.Turning,
            this.Change_Size,
            this.Delete_Element});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // Drag_and_Drop
            // 
            this.Drag_and_Drop.Name = "Drag_and_Drop";
            this.Drag_and_Drop.Size = new System.Drawing.Size(171, 22);
            this.Drag_and_Drop.Text = "Переместить";
            this.Drag_and_Drop.Click += new System.EventHandler(this.change_mode);
            // 
            // Turning
            // 
            this.Turning.Name = "Turning";
            this.Turning.Size = new System.Drawing.Size(171, 22);
            this.Turning.Text = "Поворот";
            this.Turning.Click += new System.EventHandler(this.change_mode);
            // 
            // Change_Size
            // 
            this.Change_Size.Name = "Change_Size";
            this.Change_Size.Size = new System.Drawing.Size(171, 22);
            this.Change_Size.Text = "Изменить размер";
            this.Change_Size.Click += new System.EventHandler(this.change_mode);
            // 
            // Delete_Element
            // 
            this.Delete_Element.Name = "Delete_Element";
            this.Delete_Element.Size = new System.Drawing.Size(171, 22);
            this.Delete_Element.Text = "Удалить элемент";
            this.Delete_Element.Click += new System.EventHandler(this.change_mode);
            // 
            // Clear_map
            // 
            this.Clear_map.Name = "Clear_map";
            this.Clear_map.Size = new System.Drawing.Size(71, 20);
            this.Clear_map.Text = "Очистить";
            this.Clear_map.Click += new System.EventHandler(this.clear);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 529);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(935, 529);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Спальня";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem элементыСпальниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Wall;
        private System.Windows.Forms.ToolStripMenuItem Bed;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Drag_and_Drop;
        private System.Windows.Forms.ToolStripMenuItem Turning;
        private System.Windows.Forms.ToolStripMenuItem Change_Size;
        private System.Windows.Forms.ToolStripMenuItem Clear_map;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete_Element;
        private System.Windows.Forms.ToolStripMenuItem BedsideTable;
        private System.Windows.Forms.ToolStripMenuItem Computer;
        private System.Windows.Forms.ToolStripMenuItem Wardrobe;
        private System.Windows.Forms.ToolStripMenuItem Window;
        private System.Windows.Forms.ToolStripMenuItem Door;
        private System.Windows.Forms.ToolStripMenuItem Arrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem Size_text;
        private System.Windows.Forms.ToolStripMenuItem Lamp;
        private System.Windows.Forms.ToolStripMenuItem Armchair;
    }
}

