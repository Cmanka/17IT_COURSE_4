namespace DrawingForm
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
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angleCoordinatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalShadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalShadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.Location = new System.Drawing.Point(-1, 27);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(800, 426);
            this.drawingPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleToolStripMenuItem,
            this.figureToolStripMenuItem,
            this.solidToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angleCoordinatesToolStripMenuItem,
            this.setScaleToolStripMenuItem});
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.scaleToolStripMenuItem.Text = "Масштаб";
            // 
            // angleCoordinatesToolStripMenuItem
            // 
            this.angleCoordinatesToolStripMenuItem.Name = "angleCoordinatesToolStripMenuItem";
            this.angleCoordinatesToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.angleCoordinatesToolStripMenuItem.Text = "Координаты углов";
            this.angleCoordinatesToolStripMenuItem.Click += new System.EventHandler(this.AngleCoordinatesClick);
            // 
            // setScaleToolStripMenuItem
            // 
            this.setScaleToolStripMenuItem.Name = "setScaleToolStripMenuItem";
            this.setScaleToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.setScaleToolStripMenuItem.Text = "Установка масштаба";
            this.setScaleToolStripMenuItem.Click += new System.EventHandler(this.SetScaleClick);
            // 
            // figureToolStripMenuItem
            // 
            this.figureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.ovalToolStripMenuItem});
            this.figureToolStripMenuItem.Name = "figureToolStripMenuItem";
            this.figureToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.figureToolStripMenuItem.Text = "Фигура";
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.squareToolStripMenuItem.Text = "Квадрат";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.DrawSquareClick);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rectangleToolStripMenuItem.Text = "Прямоугольник";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.DrawRectangleClick);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circleToolStripMenuItem.Text = "Окружность";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.DrawCircleClick);
            // 
            // ovalToolStripMenuItem
            // 
            this.ovalToolStripMenuItem.Name = "ovalToolStripMenuItem";
            this.ovalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ovalToolStripMenuItem.Text = "Овал";
            this.ovalToolStripMenuItem.Click += new System.EventHandler(this.DrawOvalClick);
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.solidToolStripMenuItem.Text = "Заливка";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidFillToolStripMenuItem,
            this.horizontalShadingToolStripMenuItem,
            this.verticalShadingToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.styleToolStripMenuItem.Text = "Стиль";
            // 
            // solidFillToolStripMenuItem
            // 
            this.solidFillToolStripMenuItem.Name = "solidFillToolStripMenuItem";
            this.solidFillToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.solidFillToolStripMenuItem.Text = "Сплошная заливка";
            this.solidFillToolStripMenuItem.Click += new System.EventHandler(this.SolidFillClick);
            // 
            // horizontalShadingToolStripMenuItem
            // 
            this.horizontalShadingToolStripMenuItem.Name = "horizontalShadingToolStripMenuItem";
            this.horizontalShadingToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.horizontalShadingToolStripMenuItem.Text = "Горизонтальная штриховка";
            this.horizontalShadingToolStripMenuItem.Click += new System.EventHandler(this.horizontalFillClick);
            // 
            // verticalShadingToolStripMenuItem
            // 
            this.verticalShadingToolStripMenuItem.Name = "verticalShadingToolStripMenuItem";
            this.verticalShadingToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.verticalShadingToolStripMenuItem.Text = "Вертикальная штриховка";
            this.verticalShadingToolStripMenuItem.Click += new System.EventHandler(this.verticalFillClick);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorToolStripMenuItem.Text = "Цвета";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.redToolStripMenuItem.Text = "Красный";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.RedToolClick);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.greenToolStripMenuItem.Text = "Зелёный";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.GreenToolClick);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.blueToolStripMenuItem.Text = "Синий";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.BlueToolClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angleCoordinatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalShadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalShadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
    }
}

