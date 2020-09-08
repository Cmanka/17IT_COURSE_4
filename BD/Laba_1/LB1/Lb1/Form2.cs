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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;

            if (int.TryParse(textBox1.Text, out num)) {
                if (num <= 0)
                    textBox2.Text = "Введите положительно число";
                else
                {
                    int sum = 0;
                    for (int i = 1; i <= num; i++)
                        sum += i;

                    textBox2.Text = sum.ToString();
                }
            }
        }
    }
}
