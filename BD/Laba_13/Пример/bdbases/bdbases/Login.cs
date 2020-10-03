using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdbases
{
    public partial class Login : Form
    {

        public static string dbConStr = "";
        public Login()
        {
            InitializeComponent();
            bdList();
        }


        private void bdList()
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=HP250G1\\SQLEXPRESS;Integrated Security=true;");

            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "SELECT name FROM sys.databases " +
                                     "WHERE name not in (\'master\',\'tempdb\',\'model\',\'msdb\')";
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader SqlDR;
                SqlDR = sqlCom.ExecuteReader();
                while (SqlDR.Read())
                {
                    comboBox1.Items.Add(SqlDR.GetString(0));
                }
                comboBox1.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlCon.Close();
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlConnection sqlCon = new SqlConnection("Data Source=HP250G1\\SQLEXPRESS;Database=\"" +
                comboBox1.Text + "\";Integrated Security=true;");

            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "SELECT name FROM sys.database_principals " +
                                     "WHERE (type <> \'r\') AND (name NOT IN (\'dbo\', \'sys\', \'INFORMATION_SCHEMA\'))";      
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader SqlDR;
                SqlDR = sqlCom.ExecuteReader();
                while (SqlDR.Read())
                {
                    comboBox2.Items.Add(SqlDR.GetString(0));
                }
                if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlCon.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                if (checkBox1.Checked) dbConStr = "Data Source=HP250G1\\SQLEXPRESS;Database=\"" +
                comboBox1.Text + "\";User=" + comboBox2.Text + ";Password=" + textBox1.Text;
                else dbConStr = "Data Source=HP250G1\\SQLEXPRESS;Database=\"" +
                comboBox1.Text + "\";Integrated Security=true;";
                sqlCon.ConnectionString = dbConStr;
                sqlCon.Open();
                Form1 main = new Form1(this,comboBox1.Text);
                main.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox2.Enabled = true;
                textBox1.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
                textBox1.Enabled = false;
            }

        }
    }
}
