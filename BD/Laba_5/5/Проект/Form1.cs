using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class Form1 : Form
    {
        Label l1, l2, l3, l4;
        TextBox t1, t2, t3, t4;
        Button btn = new Button();

        int style = 1, color = 1;

        public Form1()
        {
            InitializeComponent();
            сплошнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Checked;
            красныйToolStripMenuItem.CheckState = CheckState.Checked;
        }

        private void draw_1()
        {
            Form form = new Form();
            form.Size = new System.Drawing.Size(290, 200);
            form.Text = "Квадрат";

            l1 = new Label(); l2 = new Label(); l3 = new Label();
            t1 = new TextBox(); t2 = new TextBox(); t3 = new TextBox();
            btn = new Button();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t3.Location = new Point(40, 90);
            t1.Width = 220;
            t2.Width = 220;
            t3.Width = 220;
            form.Controls.Add(t1);
            form.Controls.Add(t2);
            form.Controls.Add(t3);

            l1.Text = "X:";
            l2.Text = "Y:";
            l3.Text = "A:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            l3.Location = new Point(10, 94);
            form.Controls.Add(l1);
            form.Controls.Add(l2);
            form.Controls.Add(l3);

            btn.Width = 220;
            btn.Location = new Point(40, 124);
            btn.Text = "Нарисовать";
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;
            t3.KeyPress += keyPress;

            btn.Click += btnClick1;

            form.ShowDialog();
        }

        private void draw_2()
        {
            Form form = new Form();
            form.Size = new System.Drawing.Size(290, 250);
            form.Text = "Прямоугольник";

            l1 = new Label(); l2 = new Label(); l3 = new Label(); l4 = new Label();
            t1 = new TextBox(); t2 = new TextBox(); t3 = new TextBox(); t4 = new TextBox();
            btn = new Button();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t3.Location = new Point(40, 90);
            t4.Location = new Point(40, 130);
            t1.Width = 220;
            t2.Width = 220;
            t3.Width = 220;
            t4.Width = 220;
            form.Controls.Add(t1);
            form.Controls.Add(t2);
            form.Controls.Add(t3);
            form.Controls.Add(t4);

            l1.Text = "X:";
            l2.Text = "Y:";
            l3.Text = "A:";
            l4.Text = "B:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            l3.Location = new Point(10, 94);
            l4.Location = new Point(10, 134);
            form.Controls.Add(l1);
            form.Controls.Add(l2);
            form.Controls.Add(l3);
            form.Controls.Add(l4);

            btn.Width = 220;
            btn.Location = new Point(40, 164);
            btn.Text = "Нарисовать";
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;
            t3.KeyPress += keyPress;
            t4.KeyPress += keyPress;

            btn.Click += btnClick2;

            form.ShowDialog();
        }

        private void draw_3()
        {
            Form form = new Form();
            form.Size = new System.Drawing.Size(290, 200);
            form.Text = "Окружность";

            l1 = new Label(); l2 = new Label(); l3 = new Label();
            t1 = new TextBox(); t2 = new TextBox(); t3 = new TextBox();
            btn = new Button();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t3.Location = new Point(40, 90);
            t1.Width = 220;
            t2.Width = 220;
            t3.Width = 220;
            form.Controls.Add(t1);
            form.Controls.Add(t2);
            form.Controls.Add(t3);

            l1.Text = "X:";
            l2.Text = "Y:";
            l3.Text = "R:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            l3.Location = new Point(10, 94);
            form.Controls.Add(l1);
            form.Controls.Add(l2);
            form.Controls.Add(l3);

            btn.Width = 220;
            btn.Location = new Point(40, 124);
            btn.Text = "Нарисовать";
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;
            t3.KeyPress += keyPress;

            btn.Click += btnClick3;

            form.ShowDialog();
        }

        private void draw_4()
        {
            Form form = new Form();
            form.Size = new System.Drawing.Size(290, 250);
            form.Text = "Овал";

            l1 = new Label(); l2 = new Label(); l3 = new Label(); l4 = new Label();
            t1 = new TextBox(); t2 = new TextBox(); t3 = new TextBox(); t4 = new TextBox();
            btn = new Button();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t3.Location = new Point(40, 90);
            t4.Location = new Point(40, 130);
            t1.Width = 220;
            t2.Width = 220;
            t3.Width = 220;
            t4.Width = 220;
            form.Controls.Add(t1);
            form.Controls.Add(t2);
            form.Controls.Add(t3);
            form.Controls.Add(t4);

            l1.Text = "X:";
            l2.Text = "Y:";
            l3.Text = "R1:";
            l4.Text = "R2:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            l3.Location = new Point(10, 94);
            l4.Location = new Point(10, 134);
            form.Controls.Add(l1);
            form.Controls.Add(l2);
            form.Controls.Add(l3);
            form.Controls.Add(l4);

            btn.Width = 220;
            btn.Location = new Point(40, 164);
            btn.Text = "Нарисовать";
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;
            t3.KeyPress += keyPress;
            t4.KeyPress += keyPress;

            btn.Click += btnClick4;

            form.ShowDialog();
        }

        private void btnClick4(object sender, EventArgs e)
        {
            if(!t1.Text.Equals("") && !t2.Text.Equals("") && !t3.Text.Equals("") && !t4.Text.Equals("")) {
            Graphics g = Graphics.FromHwnd(panel1.Handle);

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
                    case 1: brush = new HatchBrush(HatchStyle.Horizontal, Color.Red, Color.FromArgb(0, 1, 1, 1));
                        pen = new Pen(Color.Red);
                        break;
                    case 2: brush = new HatchBrush(HatchStyle.Horizontal, Color.Green, Color.FromArgb(0, 1, 1, 1));
                        pen = new Pen(Color.Green);
                        break;
                    case 3: brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.FromArgb(0, 1, 1, 1));
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
                    case 1: brush = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.FromArgb(0, 1, 1, 1));
                        pen = new Pen(Color.Red);
                        break;
                    case 2: brush = new HatchBrush(HatchStyle.Vertical, Color.Green, Color.FromArgb(0, 1, 1, 1));
                        pen = new Pen(Color.Green);
                        break;
                    case 3: brush = new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.FromArgb(0, 1, 1, 1));
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

        private void btnClick3(object sender, EventArgs e)
        {
            if (!t1.Text.Equals("") && !t2.Text.Equals("") && !t3.Text.Equals(""))
            {
                Graphics g = Graphics.FromHwnd(panel1.Handle);

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
                        case 1: brush = new HatchBrush(HatchStyle.Horizontal, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2: brush = new HatchBrush(HatchStyle.Horizontal, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3: brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.FromArgb(0, 1, 1, 1));
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
                        case 1: brush = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2: brush = new HatchBrush(HatchStyle.Vertical, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3: brush = new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.FromArgb(0, 1, 1, 1));
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

        private void btnClick2(object sender, EventArgs e)
        {
            if (!t1.Text.Equals("") && !t2.Text.Equals("") && !t3.Text.Equals("") && !t4.Text.Equals(""))
            {
                Graphics g = Graphics.FromHwnd(panel1.Handle);

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
                        case 1: brush = new HatchBrush(HatchStyle.Horizontal, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2: brush = new HatchBrush(HatchStyle.Horizontal, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3: brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.FromArgb(0, 1, 1, 1));
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
                        case 1: brush = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2: brush = new HatchBrush(HatchStyle.Vertical, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3: brush = new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.FromArgb(0, 1, 1, 1));
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

        private void btnClick1(object sender, EventArgs e)
        {
            if (!t1.Text.Equals("") && !t2.Text.Equals("") && !t3.Text.Equals(""))
            {
                Graphics g = Graphics.FromHwnd(panel1.Handle);
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
                        case 1: brush = new HatchBrush(HatchStyle.Horizontal, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2: brush = new HatchBrush(HatchStyle.Horizontal, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3: brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.FromArgb(0, 1, 1, 1));
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
                        case 1: brush = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Red);
                            break;
                        case 2: brush = new HatchBrush(HatchStyle.Vertical, Color.Green, Color.FromArgb(0, 1, 1, 1));
                            pen = new Pen(Color.Green);
                            break;
                        case 3: brush = new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.FromArgb(0, 1, 1, 1));
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


        // Маска ввода
        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // Рисование фигур
        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw_1();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            draw_1();
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw_2();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            draw_2();
        }

        private void окружностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw_3();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            draw_3();
        }

        private void овалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw_4();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            draw_4();
        }


        private void getColorStyle()
        {
            if (сплошнаяЗаливкаToolStripMenuItem.CheckState == CheckState.Checked)
                style = 1;
            else if (горизонтальнаяЗаливкаToolStripMenuItem.CheckState == CheckState.Checked)
                style = 2;
            else style = 3;

            if (красныйToolStripMenuItem.CheckState == CheckState.Checked)
                color = 1;
            else if (зеленыйToolStripMenuItem.CheckState == CheckState.Checked)
                color = 2;
            else color = 3;
        }


        // Работа с масштабом
        private void координатыУгловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new System.Drawing.Size(290, 160);
            form.Text = "Координаты окна";

            l1 = new Label(); l2 = new Label();
            t1 = new TextBox(); t2 = new TextBox();
            btn = new Button();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t1.Width = 220;
            t2.Width = 220;
            form.Controls.Add(t1);
            form.Controls.Add(t2);

            l1.Text = "X:";
            l2.Text = "Y:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            form.Controls.Add(l1);
            form.Controls.Add(l2);

            btn.Width = 220;
            btn.Location = new Point(40, 84);
            btn.Text = "Применить";
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;

            btn.Click += btnClick5;

            form.ShowDialog();
        }

        private void установкаМасштабаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new System.Drawing.Size(290, 160);
            form.Text = "Масштаб";

            l1 = new Label(); l2 = new Label();
            t1 = new TextBox(); t2 = new TextBox();
            btn = new Button();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t1.Width = 220;
            t2.Width = 220;
            form.Controls.Add(t1);
            form.Controls.Add(t2);

            l1.Text = "X:";
            l2.Text = "Y:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            form.Controls.Add(l1);
            form.Controls.Add(l2);

            btn.Width = 220;
            btn.Location = new Point(40, 84);
            btn.Text = "Применить";
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;

            btn.Click += btnClick6;

            form.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new System.Drawing.Size(290, 160);
            form.Text = "Координаты окна";

            l1 = new Label(); l2 = new Label();
            t1 = new TextBox(); t2 = new TextBox();
            btn = new Button();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t1.Width = 220;
            t2.Width = 220;
            form.Controls.Add(t1);
            form.Controls.Add(t2);

            l1.Text = "X:";
            l2.Text = "Y:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            form.Controls.Add(l1);
            form.Controls.Add(l2);

            btn.Width = 220;
            btn.Location = new Point(40, 84);
            btn.Text = "Применить";
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;

            btn.Click += btnClick5;

            form.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new System.Drawing.Size(290, 160);
            form.Text = "Масштаб";

            l1 = new Label(); l2 = new Label();
            t1 = new TextBox(); t2 = new TextBox();
            btn = new Button();

            t1.Location = new Point(40, 10);
            t2.Location = new Point(40, 50);
            t1.Width = 220;
            t2.Width = 220;
            form.Controls.Add(t1);
            form.Controls.Add(t2);

            l1.Text = "X:";
            l2.Text = "Y:";
            l1.Location = new Point(10, 14);
            l2.Location = new Point(10, 54);
            form.Controls.Add(l1);
            form.Controls.Add(l2);

            btn.Width = 220;
            btn.Location = new Point(40, 84);
            btn.Text = "Применить";
            form.Controls.Add(btn);

            t1.KeyPress += keyPress;
            t2.KeyPress += keyPress;

            btn.Click += btnClick6;

            form.ShowDialog();
        }

        private void btnClick6(object sender, EventArgs e)
        {
            if (!t1.Text.Equals("") && !t2.Text.Equals(""))
            {
                this.Size = new System.Drawing.Size(int.Parse(t1.Text), int.Parse(t2.Text));
                panel1.Size = new System.Drawing.Size(int.Parse(t1.Text) - 40, int.Parse(t2.Text) - 110);

                Button btn = (Button)sender;
                Form f = (Form)btn.Parent;
                f.Close();
            }
        }

        private void btnClick5(object sender, EventArgs e)
        {
            if (!t1.Text.Equals("") && !t2.Text.Equals(""))
            {
                this.Location = new Point(int.Parse(t1.Text), int.Parse(t2.Text));

                Button btn = (Button)sender;
                Form f = (Form)btn.Parent;
                f.Close();
            }
        }


        // Выбор заливки и стиля
        private void сплошнаяЗаливкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сплошнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Checked;
            вертикальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;
            горизонтальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;

        }

        private void горизонтальнаяЗаливкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сплошнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;
            вертикальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;
            горизонтальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Checked;

        }

        private void вертикальнаяЗаливкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сплошнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;
            вертикальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Checked;
            горизонтальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;

        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            красныйToolStripMenuItem.CheckState = CheckState.Checked;
            зеленыйToolStripMenuItem.CheckState = CheckState.Unchecked;
            синийToolStripMenuItem.CheckState = CheckState.Unchecked;

        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {

            красныйToolStripMenuItem.CheckState = CheckState.Unchecked;
            зеленыйToolStripMenuItem.CheckState = CheckState.Checked;
            синийToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {

            красныйToolStripMenuItem.CheckState = CheckState.Unchecked;
            зеленыйToolStripMenuItem.CheckState = CheckState.Unchecked;
            синийToolStripMenuItem.CheckState = CheckState.Checked;
        }

        private void красныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            красныйToolStripMenuItem.CheckState = CheckState.Checked;
            зеленыйToolStripMenuItem.CheckState = CheckState.Unchecked;
            синийToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void зеленыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            красныйToolStripMenuItem.CheckState = CheckState.Unchecked;
            зеленыйToolStripMenuItem.CheckState = CheckState.Checked;
            синийToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void синийToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            красныйToolStripMenuItem.CheckState = CheckState.Unchecked;
            зеленыйToolStripMenuItem.CheckState = CheckState.Unchecked;
            синийToolStripMenuItem.CheckState = CheckState.Checked;
        }

        private void сплошнаяЗаливкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            сплошнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Checked;
            вертикальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;
            горизонтальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;

        }

        private void горизонтальнаяЗаливкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            сплошнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;
            вертикальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;
            горизонтальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Checked;

        }

        private void вертикальнаяЗаливкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            сплошнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;
            вертикальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Checked;
            горизонтальнаяЗаливкаToolStripMenuItem.CheckState = CheckState.Unchecked;

        }

    }
}