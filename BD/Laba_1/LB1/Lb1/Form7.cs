using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Click(object sender, EventArgs e)
        {

            this.SuspendLayout();

            label1.Font = new Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            label1.Text = "Мышь";

            this.Size = new Size(200, 500);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Form7_KeyDown(object sender, KeyPressEventArgs e)
        {
            this.SuspendLayout();

            label1.Font = new Font("Times New Roman", 24F, System.Drawing.FontStyle.Underline);
            label1.Text = "Нажата кнопка " + e.KeyChar.ToString();

            this.Size = new Size(500, 200);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
