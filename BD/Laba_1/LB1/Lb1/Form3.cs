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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num;

            if (double.TryParse(textBox1.Text, out num))
            {
                num = Math.Abs(num);
                textBox2.Text = num.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num;

            if (double.TryParse(textBox1.Text, out num))
            {
                if (num < 0)
                    num *= -1 ;
                num = Math.Sqrt(num);
                textBox2.Text = num.ToString();
            }
        }
    }
}
