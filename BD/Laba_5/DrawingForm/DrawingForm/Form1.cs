using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DrawingForm
{
    public partial class Form1 : Form
    {
        Label l1, l2, l3, l4;
        TextBox t1, t2, t3, t4;
        Button btn;
        int style;
        int color;
        public Form1()
        {
            InitializeComponent();
            solidFillToolStripMenuItem.CheckState = CheckState.Checked;
            redToolStripMenuItem.CheckState = CheckState.Checked;
            btn = new Button();
            style = 1;
            color = 1;
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void AngleCoordinatesClick(object sender, EventArgs e)
        {
            Form form = new Form();

            form.Size = new Size(290, 200);
            form.Text = "Координаты окна";

            l1 = new Label();
            l2 = new Label();

            l1.Text = "X:";
            l2.Text = "Y:";
            l1.Location = new Point(10, 10);
            l2.Location = new Point(10, 60);

            t1 = new TextBox();
            t2 = new TextBox();

            t1.Location = new Point(10, 35);
            t2.Location = new Point(10, 85);
            t1.Width = 220;
            t2.Width = 220;

            btn = new Button();

            btn.Width = 220;
            btn.Location = new Point(10, 120);
            btn.Text = "Применить";



            form.Controls.Add(l1);
            form.Controls.Add(l2);
            form.Controls.Add(t1);
            form.Controls.Add(t2);
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;

            btn.Click += AngleCoordButtonClick;

            form.ShowDialog();
        }
        private void AngleCoordButtonClick(object sender, EventArgs e)
        {
            if (!t1.Text.Equals("") && !t2.Text.Equals(""))
            {
                this.Location = new Point(int.Parse(t1.Text), int.Parse(t2.Text));

                Button btn = (Button)sender;
                Form f = (Form)btn.Parent;
                f.Close();
            }
        }
        private void SetScaleClick(object sender, EventArgs e)
        {
            Form form = new Form();

            form.Size = new Size(290, 200);
            form.Text = "Масштаб";

            l1 = new Label();
            l2 = new Label();

            l1.Text = "X:";
            l2.Text = "Y:";
            l1.Location = new Point(10, 10);
            l2.Location = new Point(10, 60);

            t1 = new TextBox();
            t2 = new TextBox();

            t1.Location = new Point(10, 35);
            t2.Location = new Point(10, 85);
            t1.Width = 220;
            t2.Width = 220;

            btn = new Button();

            btn.Width = 220;
            btn.Location = new Point(10, 120);
            btn.Text = "Применить";



            form.Controls.Add(l1);
            form.Controls.Add(l2);
            form.Controls.Add(t1);
            form.Controls.Add(t2);
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;

            btn.Click += SetScaleButtonClick;

            form.ShowDialog();
        }
        private void SetScaleButtonClick(object sender, EventArgs e)
        {
            if (!t1.Text.Equals("") && !t2.Text.Equals(""))
            {
                this.Size = new Size(int.Parse(t1.Text), int.Parse(t2.Text));
                drawingPanel.Size = new Size(int.Parse(t1.Text),int.Parse(t2.Text));

                Button btn = (Button)sender;
                Form f = (Form)btn.Parent;
                f.Close();
            }
        }
        private void DrawSquareClick(object sender,EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(290, 200);
            form.Text = "Квадрат";

            l1 = new Label();
            l2 = new Label();
            l3 = new Label();

            l1.Text = "X:";
            l2.Text = "Y:";
            l3.Text = "A:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            l3.Location = new Point(10, 94);

            t1 = new TextBox();
            t2 = new TextBox();
            t3 = new TextBox();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t3.Location = new Point(40, 90);
            t1.Width = 220;
            t2.Width = 220;
            t3.Width = 220;

            btn = new Button();

            btn.Width = 220;
            btn.Location = new Point(40, 124);
            btn.Text = "Нарисовать";

            form.Controls.Add(t1);
            form.Controls.Add(t2);
            form.Controls.Add(t3);
            form.Controls.Add(l1);
            form.Controls.Add(l2);
            form.Controls.Add(l3);
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;
            t3.KeyPress += keyPress;

            btn.Click += DrawSquareButtonClick;

            form.ShowDialog();
        }
        private void DrawSquareButtonClick(object sender,EventArgs e)
        {
            if (!t1.Text.Equals("") && !t2.Text.Equals("") && !t3.Text.Equals(""))
            {
                Graphics g = Graphics.FromHwnd(drawingPanel.Handle);
                getColorStyle();

                Brush brush = new SolidBrush(Color.Red);
                Pen pen = new Pen(Color.Red);

                if (style == 1)
                {
                    switch (color)
                    {
                        case 1: brush = new SolidBrush(Color.Red); break;
                        case 2: brush = new SolidBrush(Color.Green); break;
                        case 3: brush = new SolidBrush(Color.Blue); break;
                    }

                    g.FillRectangle(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t3.Text));
                }
                else if (style == 2)
                {
                    switch (color)
                    {
                        case 1:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Blue);
                            break;
                    }

                    g.DrawRectangle(pen, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t3.Text));
                    g.FillRectangle(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t3.Text));
                }
                else
                {
                    switch (color)
                    {
                        case 1:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Blue);
                            break;
                    }

                    g.DrawRectangle(pen, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t3.Text));
                    g.FillRectangle(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t3.Text));
                }

                Button btn = (Button)sender;
                Form f = (Form)btn.Parent;
                f.Close();
            }
        }
        private void DrawRectangleClick(object sender,EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(290, 250);
            form.Text = "Прямоугольник";

            l1 = new Label();
            l2 = new Label();
            l3 = new Label();
            l4 = new Label();

            l1.Text = "X:";
            l2.Text = "Y:";
            l3.Text = "A:";
            l4.Text = "B:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            l3.Location = new Point(10, 94);
            l4.Location = new Point(10, 134);

            t1 = new TextBox();
            t2 = new TextBox();
            t3 = new TextBox();
            t4 = new TextBox();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t3.Location = new Point(40, 90);
            t4.Location = new Point(40, 130);
            t1.Width = 220;
            t2.Width = 220;
            t3.Width = 220;
            t4.Width = 220;

            btn = new Button();

            btn.Width = 220;
            btn.Location = new Point(40, 164);
            btn.Text = "Нарисовать";
            form.Controls.Add(btn);


            form.Controls.Add(t1);
            form.Controls.Add(t2);
            form.Controls.Add(t3);
            form.Controls.Add(t4);
            form.Controls.Add(l1);
            form.Controls.Add(l2);
            form.Controls.Add(l3);
            form.Controls.Add(l4);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;
            t3.KeyPress += keyPress;
            t4.KeyPress += keyPress;

            btn.Click += DrawRectangleButtonClick;

            form.ShowDialog();
        }
        private void DrawRectangleButtonClick(object sender,EventArgs e)
        {
            if (!t1.Text.Equals("") && !t2.Text.Equals("") && !t3.Text.Equals("") && !t4.Text.Equals(""))
            {
                Graphics g = Graphics.FromHwnd(drawingPanel.Handle);

                getColorStyle();

                Brush brush = new SolidBrush(Color.Red);
                Pen pen = new Pen(Color.Red);

                if (style == 1)
                {
                    switch (color)
                    {
                        case 1: brush = new SolidBrush(Color.Red); break;
                        case 2: brush = new SolidBrush(Color.Green); break;
                        case 3: brush = new SolidBrush(Color.Blue); break;
                    }

                    g.FillRectangle(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t4.Text));
                }
                else if (style == 2)
                {
                    switch (color)
                    {
                        case 1:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Blue);
                            break;
                    }

                    g.DrawRectangle(pen, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t4.Text));
                    g.FillRectangle(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t4.Text));
                }
                else
                {
                    switch (color)
                    {
                        case 1:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Blue);
                            break;
                    }

                    g.DrawRectangle(pen, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t4.Text));
                    g.FillRectangle(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t4.Text));
                }

                Button btn = (Button)sender;
                Form f = (Form)btn.Parent;
                f.Close();
            }
        }
        private void DrawCircleClick(object sender,EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(290, 200);
            form.Text = "Окружность";

            l1 = new Label();
            l2 = new Label();
            l3 = new Label();

            l1.Text = "X:";
            l2.Text = "Y:";
            l3.Text = "R:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            l3.Location = new Point(10, 94);

            t1 = new TextBox();
            t2 = new TextBox();
            t3 = new TextBox();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t3.Location = new Point(40, 90);
            t1.Width = 220;
            t2.Width = 220;
            t3.Width = 220;

            btn = new Button();

            btn.Width = 220;
            btn.Location = new Point(40, 124);
            btn.Text = "Нарисовать";


            form.Controls.Add(t1);
            form.Controls.Add(t2);
            form.Controls.Add(t3);
            form.Controls.Add(l1);
            form.Controls.Add(l2);
            form.Controls.Add(l3);
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;
            t3.KeyPress += keyPress;

            btn.Click += DrawCircleButtonClick;

            form.ShowDialog();
        }
        private void DrawCircleButtonClick(object sender,EventArgs e)
        {
            if (!t1.Text.Equals("") && !t2.Text.Equals("") && !t3.Text.Equals(""))
            {
                Graphics g = Graphics.FromHwnd(drawingPanel.Handle);

                getColorStyle();

                Brush brush = new SolidBrush(Color.Red);
                Pen pen = new Pen(Color.Red);

                if (style == 1)
                {
                    switch (color)
                    {
                        case 1: brush = new SolidBrush(Color.Red); break;
                        case 2: brush = new SolidBrush(Color.Green); break;
                        case 3: brush = new SolidBrush(Color.Blue); break;
                    }

                    g.FillEllipse(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t3.Text));
                }
                else if (style == 2)
                {
                    switch (color)
                    {
                        case 1:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Blue);
                            break;
                    }

                    g.FillEllipse(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t3.Text));
                    g.DrawEllipse(pen, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t3.Text));
                }
                else
                {
                    switch (color)
                    {
                        case 1:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Blue);
                            break;
                    }

                    g.FillEllipse(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t3.Text));
                    g.DrawEllipse(pen, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t3.Text));
                }

                Button btn = (Button)sender;
                Form f = (Form)btn.Parent;
                f.Close();
            }
        }
        private void DrawOvalClick(object sender,EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(290, 250);
            form.Text = "Прямоугольник";

            l1 = new Label();
            l2 = new Label();
            l3 = new Label();
            l4 = new Label();

            l1.Text = "X:";
            l2.Text = "Y:";
            l3.Text = "R1:";
            l4.Text = "R2:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            l3.Location = new Point(10, 94);
            l4.Location = new Point(10, 134);

            t1 = new TextBox();
            t2 = new TextBox();
            t3 = new TextBox();
            t4 = new TextBox();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t3.Location = new Point(40, 90);
            t4.Location = new Point(40, 130);
            t1.Width = 220;
            t2.Width = 220;
            t3.Width = 220;
            t4.Width = 220;

            btn = new Button();

            btn.Width = 220;
            btn.Location = new Point(40, 164);
            btn.Text = "Нарисовать";
            form.Controls.Add(btn);


            form.Controls.Add(t1);
            form.Controls.Add(t2);
            form.Controls.Add(t3);
            form.Controls.Add(t4);
            form.Controls.Add(l1);
            form.Controls.Add(l2);
            form.Controls.Add(l3);
            form.Controls.Add(l4);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;
            t3.KeyPress += keyPress;
            t4.KeyPress += keyPress;

            btn.Click += DrawOvalButtonClick;

            form.ShowDialog();
        }
        private void DrawOvalButtonClick(object sender,EventArgs e)
        {
            if (!t1.Text.Equals("") && !t2.Text.Equals("") && !t3.Text.Equals("") && !t4.Text.Equals(""))
            {
                Graphics g = Graphics.FromHwnd(drawingPanel.Handle);

                getColorStyle();

                Brush brush = new SolidBrush(Color.Red);
                Pen pen = new Pen(Color.Red);

                if (style == 1)
                {
                    switch (color)
                    {
                        case 1: brush = new SolidBrush(Color.Red); break;
                        case 2: brush = new SolidBrush(Color.Green); break;
                        case 3: brush = new SolidBrush(Color.Blue); break;
                    }

                    g.FillEllipse(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t4.Text));
                }
                else if (style == 2)
                {
                    switch (color)
                    {
                        case 1:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3:
                            brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Blue);
                            break;
                    }

                    g.FillEllipse(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t4.Text));
                    g.DrawEllipse(pen, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t4.Text));
                }
                else
                {
                    switch (color)
                    {
                        case 1:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3:
                            brush = new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Blue);
                            break;
                    }

                    g.FillEllipse(brush, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t4.Text));
                    g.DrawEllipse(pen, int.Parse(t1.Text), int.Parse(t2.Text), int.Parse(t3.Text), int.Parse(t4.Text));
                }

                Button btn = (Button)sender;
                Form f = (Form)btn.Parent;
                f.Close();
            }
        }
        private void SolidFillClick(object sender, EventArgs e)
        {
            solidFillToolStripMenuItem.CheckState = CheckState.Checked;
            verticalShadingToolStripMenuItem.CheckState = CheckState.Unchecked;
            horizontalShadingToolStripMenuItem.CheckState = CheckState.Unchecked;
        }
        private void verticalFillClick(object sender, EventArgs e)
        {
            solidFillToolStripMenuItem.CheckState = CheckState.Unchecked;
            verticalShadingToolStripMenuItem.CheckState = CheckState.Checked;
            horizontalShadingToolStripMenuItem.CheckState = CheckState.Unchecked;
        }
        private void horizontalFillClick(object sender, EventArgs e)
        {
            solidFillToolStripMenuItem.CheckState = CheckState.Unchecked;
            verticalShadingToolStripMenuItem.CheckState = CheckState.Unchecked;
            horizontalShadingToolStripMenuItem.CheckState = CheckState.Checked;
        }
        private void RedToolClick(object sender, EventArgs e)
        {
            redToolStripMenuItem.CheckState = CheckState.Checked;
            greenToolStripMenuItem.CheckState = CheckState.Unchecked;
            blueToolStripMenuItem.CheckState = CheckState.Unchecked;
        }
        private void GreenToolClick(object sender, EventArgs e)
        {
            redToolStripMenuItem.CheckState = CheckState.Unchecked;
            greenToolStripMenuItem.CheckState = CheckState.Checked;
            blueToolStripMenuItem.CheckState = CheckState.Unchecked;
        }
        private void BlueToolClick(object sender, EventArgs e)
        {
            redToolStripMenuItem.CheckState = CheckState.Unchecked;
            greenToolStripMenuItem.CheckState = CheckState.Unchecked;
            blueToolStripMenuItem.CheckState = CheckState.Checked;
        }
        private void getColorStyle()
        {
            if (solidFillToolStripMenuItem.CheckState == CheckState.Checked)
                style = 1;
            else if (horizontalShadingToolStripMenuItem.CheckState == CheckState.Checked)
                style = 2;
            else style = 3;

            if (redToolStripMenuItem.CheckState == CheckState.Checked)
                color = 1;
            else if (greenToolStripMenuItem.CheckState == CheckState.Checked)
                color = 2;
            else color = 3;
        }
    }
}
