using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public bool checkbox = false;
        public int radiobutton = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prov = 0;
            if(textBox1.Text == "")
            {
                MessageBox.Show("Введите имя", "Ошибка");
                prov = 1;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите дату рождения", "Ошибка");
                prov = 1;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Введите группу", "Ошибка");
                prov = 1;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Введите телефон", "Ошибка");
                prov = 1;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Введите адрес", "Ошибка");
                prov = 1;
            }
            if (prov == 0)
            {
                try
                {
                    students.Add(new Student(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));
                    ShowList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не верный ввод данных", "Ошибка");
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void ShowList()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            foreach (var i in students)
            {
                listBox1.Items.Add(i.FIO);
                listBox2.Items.Add(i.date);
                listBox3.Items.Add(i.group);
                listBox4.Items.Add(i.phone);
                listBox5.Items.Add(i.address);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkbox == true)
            {
                try
                {
                    int index = listBox1.SelectedIndex;

                    students.RemoveAt(index);
                    ShowList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка прои удалении","Ошибка");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox == false)
            {

                checkbox = true;
            }
            else
            {
                checkbox = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            students.Clear();
            ////Загрузить 
            if(radiobutton == 1)
            {
                var res = SerialazbleWork.DeserializeToXML("student.txt");
                students.AddRange(res);
            }
            if(radiobutton == 2)
            {
                students.AddRange(SerialazbleWork.DeserializeToBin("student.bin"));
            }
            ShowList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //////Сохранить
            if (radiobutton == 1)
            {
                SerialazbleWork.SerialazeToXML(students,"student.txt");
            }
            if (radiobutton == 2)
            {
                SerialazbleWork.SerialazeToBin(students, "student.bin");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
