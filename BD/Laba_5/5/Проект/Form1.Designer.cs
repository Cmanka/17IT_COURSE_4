namespace Проект
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.координатыУгловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установкаМасштабаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окружностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.овалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сплошнаяЗаливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальнаяЗаливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальнаяЗаливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масштабToolStripMenuItem,
            this.фигураToolStripMenuItem,
            this.заливкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // масштабToolStripMenuItem
            // 
            this.масштабToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.координатыУгловToolStripMenuItem,
            this.установкаМасштабаToolStripMenuItem});
            this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            this.масштабToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.масштабToolStripMenuItem.Text = "Масштаб";
            // 
            // координатыУгловToolStripMenuItem
            // 
            this.координатыУгловToolStripMenuItem.Name = "координатыУгловToolStripMenuItem";
            this.координатыУгловToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.координатыУгловToolStripMenuItem.Text = "Координаты углов";
            this.координатыУгловToolStripMenuItem.Click += new System.EventHandler(this.координатыУгловToolStripMenuItem_Click);
            // 
            // установкаМасштабаToolStripMenuItem
            // 
            this.установкаМасштабаToolStripMenuItem.Name = "установкаМасштабаToolStripMenuItem";
            this.установкаМасштабаToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.установкаМасштабаToolStripMenuItem.Text = "Установка масштаба";
            this.установкаМасштабаToolStripMenuItem.Click += new System.EventHandler(this.установкаМасштабаToolStripMenuItem_Click);
            // 
            // фигураToolStripMenuItem
            // 
            this.фигураToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квадратToolStripMenuItem,
            this.прямоугольникToolStripMenuItem,
            this.окружностьToolStripMenuItem,
            this.овалToolStripMenuItem});
            this.фигураToolStripMenuItem.Name = "фигураToolStripMenuItem";
            this.фигураToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.фигураToolStripMenuItem.Text = "Фигура";
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.квадратToolStripMenuItem.Text = "Квадрат";
            this.квадратToolStripMenuItem.Click += new System.EventHandler(this.квадратToolStripMenuItem_Click);
            // 
            // прямоугольникToolStripMenuItem
            // 
            this.прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            this.прямоугольникToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            this.прямоугольникToolStripMenuItem.Click += new System.EventHandler(this.прямоугольникToolStripMenuItem_Click);
            // 
            // окружностьToolStripMenuItem
            // 
            this.окружностьToolStripMenuItem.Name = "окружностьToolStripMenuItem";
            this.окружностьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.окружностьToolStripMenuItem.Text = "Окружность";
            this.окружностьToolStripMenuItem.Click += new System.EventHandler(this.окружностьToolStripMenuItem_Click);
            // 
            // овалToolStripMenuItem
            // 
            this.овалToolStripMenuItem.Name = "овалToolStripMenuItem";
            this.овалToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.овалToolStripMenuItem.Text = "Овал";
            this.овалToolStripMenuItem.Click += new System.EventHandler(this.овалToolStripMenuItem_Click);
            // 
            // заливкаToolStripMenuItem
            // 
            this.заливкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стильToolStripMenuItem,
            this.цветToolStripMenuItem});
            this.заливкаToolStripMenuItem.Name = "заливкаToolStripMenuItem";
            this.заливкаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.заливкаToolStripMenuItem.Text = "Заливка";
            // 
            // стильToolStripMenuItem
            // 
            this.стильToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сплошнаяЗаливкаToolStripMenuItem,
            this.горизонтальнаяЗаливкаToolStripMenuItem,
            this.вертикальнаяЗаливкаToolStripMenuItem});
            this.стильToolStripMenuItem.Name = "стильToolStripMenuItem";
            this.стильToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.стильToolStripMenuItem.Text = "Стиль";
            // 
            // сплошнаяЗаливкаToolStripMenuItem
            // 
            this.сплошнаяЗаливкаToolStripMenuItem.CheckOnClick = true;
            this.сплошнаяЗаливкаToolStripMenuItem.Name = "сплошнаяЗаливкаToolStripMenuItem";
            this.сплошнаяЗаливкаToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.сплошнаяЗаливкаToolStripMenuItem.Text = "Сплошная заливка";
            this.сплошнаяЗаливкаToolStripMenuItem.Click += new System.EventHandler(this.сплошнаяЗаливкаToolStripMenuItem_Click);
            // 
            // горизонтальнаяЗаливкаToolStripMenuItem
            // 
            this.горизонтальнаяЗаливкаToolStripMenuItem.CheckOnClick = true;
            this.горизонтальнаяЗаливкаToolStripMenuItem.Name = "горизонтальнаяЗаливкаToolStripMenuItem";
            this.горизонтальнаяЗаливкаToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.горизонтальнаяЗаливкаToolStripMenuItem.Text = "Горизонтальная заливка";
            this.горизонтальнаяЗаливкаToolStripMenuItem.Click += new System.EventHandler(this.горизонтальнаяЗаливкаToolStripMenuItem_Click);
            // 
            // вертикальнаяЗаливкаToolStripMenuItem
            // 
            this.вертикальнаяЗаливкаToolStripMenuItem.CheckOnClick = true;
            this.вертикальнаяЗаливкаToolStripMenuItem.Name = "вертикальнаяЗаливкаToolStripMenuItem";
            this.вертикальнаяЗаливкаToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.вертикальнаяЗаливкаToolStripMenuItem.Text = "Вертикальная заливка";
            this.вертикальнаяЗаливкаToolStripMenuItem.Click += new System.EventHandler(this.вертикальнаяЗаливкаToolStripMenuItem_Click);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.синийToolStripMenuItem});
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.CheckOnClick = true;
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.красныйToolStripMenuItem_Click);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.CheckOnClick = true;
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.CheckOnClick = true;
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 389);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem масштабToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem координатыУгловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установкаМасштабаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фигураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прямоугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окружностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem овалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заливкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сплошнаяЗаливкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальнаяЗаливкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальнаяЗаливкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

