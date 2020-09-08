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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double num3;
            double result;

            if (double.TryParse(textBox1.Text, out num1) && 
                double.TryParse(textBox2.Text, out num2) &&
                double.TryParse(textBox3.Text, out num3))
            {
                if (num1 > 0 && num2 > 0 && num3 > 0)
                {
                    result = num1 * num2 * num3;
                    textBox4.Text = result.ToString();
                }
                else
                    textBox4.Text = "Данные введены неверно!";
            }
            else
                textBox4.Text = "Данные введены неверно!";
        }
    }
}
