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
    public partial class Угадайка : Form
    {

        public static int num;

        public Угадайка()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num; 

            if (int.TryParse(textBox1.Text, out num))
            {
                Random rnd = new Random();
                int number = rnd.Next(0, 10);

                if (num == number)
                    textBox2.Text = "Угадал!";
                else
                    textBox2.Text = "Не угадал!";
            }
        }

    }
}
