using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace labaTxt
{
    public partial class Form1 : Form
    {
        List<Student> students;
        const string PATH_TO_BIN = "students.bin";
        const string PATH_TO_TXT = "students.txt";
        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void ClearFields()
        {
            fullNameTextBox.Text = "";
            dateTextBox.Text = "";
            groupTextBox.Text = "";
            phoneTextBox.Text = "";
            addressTextBox.Text = "";
        }
        private void UpdateListBoxes()
        {
            fullNameList.Items.Clear();
            dateList.Items.Clear();
            groupList.Items.Clear();
            phoneList.Items.Clear();
            addressList.Items.Clear();

            foreach (var student in students)
            {
                fullNameList.Items.Add(student.FullName);
                dateList.Items.Add(student.Date);
                groupList.Items.Add(student.Group);
                phoneList.Items.Add(student.Phone);
                addressList.Items.Add(student.Address);
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string[] myTextBoxes = {
                fullNameTextBox.Text,
                dateTextBox.Text,
                groupTextBox.Text,
                phoneTextBox.Text,
                addressTextBox.Text };

            bool isCorrect = true;
            foreach (var field in myTextBoxes)
            {
                if (field == "")
                {
                    MessageBox.Show("Заполните все поля для добавления");
                    isCorrect = false;
                    break;
                }
            }

            if (isCorrect)
            {
                students.Add(new Student(myTextBoxes[0], myTextBoxes[1], myTextBoxes[2], myTextBoxes[3], myTextBoxes[4]));

                UpdateListBoxes();
                ClearFields();

            }

        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (isDeleteCheckBox.Checked)
            {
                try
                {
                    students.RemoveAt(fullNameList.SelectedIndex);
                    UpdateListBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении");
                }

            }
            else
            {
                MessageBox.Show("Для удаление записи поставьте галочку");
            }
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (binRadioButton.Checked)
            {
                var result = Deserialize.DeserializeBin(PATH_TO_BIN);
                if (result != null)
                {
                    students.Clear();
                    students.AddRange(result);
                }
            }
            else if (txtRadioButton.Checked)
            {
                var result = Deserialize.DeserializeTxt(PATH_TO_TXT);
                if(result != null)
                {
                    students.Clear();
                    students.AddRange(result);
                }
            }    
            else
                MessageBox.Show("Выберите тип файла");

            UpdateListBoxes();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (binRadioButton.Checked)
                Serialize.SerializeToBin(students, PATH_TO_BIN);
            else if (txtRadioButton.Checked)
                Serialize.SerializeToTxt(students, PATH_TO_TXT);
            else
                MessageBox.Show("Выберите тип файла");
        }

        private void isDeleteCheckBox_CheckedChanged(object sender, EventArgs e) { }
    }
}
