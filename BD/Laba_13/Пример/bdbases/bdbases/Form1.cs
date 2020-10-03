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
    public partial class Form1 : Form
    {
        private Login parent;

        struct Table
        {
            public string name;
            public List<string> column;
        }
        bool Load = false;
        List<Table> table;
        public Form1(Login log, string capt)
        {
            
            parent = log;
            InitializeComponent();
            table = new List<Table>();
            tableList();
            this.Text = capt;
        }

        private void tableList()
        {
            SqlConnection sqlCon = new SqlConnection(Login.dbConStr);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "SELECT name FROM sysobjects " +
                                     "WHERE type = \'U\' and name != \'sysdiagrams\' ";
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader SqlDR;
                SqlDR = sqlCom.ExecuteReader();
                while (SqlDR.Read())
                {
                    checkedListBox2.Items.Add(SqlDR.GetString(0));
                }
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            SqlConnection sqlCon = new SqlConnection(Login.dbConStr);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "SELECT sc.name FROM syscolumns sc " +
                                     "inner join sysobjects so ON sc.id = so.id "+
                                     "WHERE so.name = \'"+listBox2.Text+"\'";
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader SqlDR;
                SqlDR = sqlCom.ExecuteReader();
                while (SqlDR.Read())
                {
                    checkedListBox1.Items.Add(SqlDR.GetString(0));
                }
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
            if (checkedListBox1.CheckedItems.Count > 0 || checkedListBox2.CheckedItems.Count > 0)
            {
                SqlConnection sqlCon = new SqlConnection(Login.dbConStr);
                try
                {
                    string tables = "", columns = "";
                    /*for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    {
                        mess = mess + '[' + checkedListBox1.CheckedItems[i] + ']';
                        if (i != checkedListBox1.CheckedItems.Count - 1)
                            mess += ", ";
                    }*/
                    foreach (Table cur in table)
                    {
                        tables += "[" + cur.name + "], ";
                        foreach (string col in cur.column)
                        {
                            columns += "[" + cur.name +"].[" + col + "], ";
                        }
                    }
                    tables = tables.Remove(tables.Length - 2);
                    columns = columns.Remove(columns.Length - 2);
                    SqlCommand sqlCom = new SqlCommand();
                    sqlCom.CommandType = CommandType.Text;
                    if (checkBox1.Checked)
                        sqlCom.CommandText = "SELECT " + columns + " FROM " + tables + " WHERE " + textBox1.Text;
                    else
                        sqlCom.CommandText = "SELECT " + columns + " FROM " + tables;
                    sqlCom.Connection = sqlCon;
                    sqlCon.Open();
                    DataTable dTab1 = new DataTable();
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
                    sqlDataAdapter1.SelectCommand = sqlCom;
                    sqlDataAdapter1.Fill(dTab1);
                    this.dataGridView1.DataSource = dTab1;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не выбрано ни одной таблицы или поля");
                }
                finally
                {
                    sqlCon.Close();
                }
            }
            else
                dataGridView1.DataSource = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) textBox1.Enabled = true;
            else textBox1.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            SqlConnection sqlCon = new SqlConnection(Login.dbConStr);
            try
            {
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "SELECT sc.name FROM syscolumns sc " +
                                     "inner join sysobjects so ON sc.id = so.id " +
                                     "WHERE so.name = \'" + checkedListBox2.Text + "\'";
                sqlCom.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader SqlDR;
                SqlDR = sqlCom.ExecuteReader();
                while (SqlDR.Read())
                {
                    checkedListBox1.Items.Add(SqlDR.GetString(0));
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlCon.Close();
            }
            Load = true;
            for (int i = 0; i < table.Count; i++)
            {
                if (table[i].name == checkedListBox2.Items[checkedListBox2.SelectedIndex].ToString())
                {
                    for (int j = 0; j < table[i].column.Count; j++)
                    {
                        for (int r = 0; r < checkedListBox1.Items.Count; r++)
                        {
                            if (table[i].column[j] == checkedListBox1.Items[r].ToString())
                            {
                                checkedListBox1.SetItemChecked(r, true);
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            Load = false;
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                Table cur = new Table();
                cur.name = checkedListBox2.Items[e.Index].ToString();
                cur.column = new List<string>();
                table.Add(cur);
            }
            if (e.NewValue == CheckState.Unchecked)
            {
                for (int i = 0;i<table.Count;i++)
                {
                    if (table[i].name == checkedListBox2.Items[e.Index].ToString())
                        table.Remove(table[i]);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mess = "";
            foreach (Table cur in table)
            {
                mess += cur.name + ": ";
                foreach (string col in cur.column)
                {
                    mess += col + ", ";
                }
                mess = mess.Remove(mess.Length - 2);
                mess += "\n";
            }
            MessageBox.Show(mess);
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (!Load)
                {
                    if (!checkedListBox2.CheckedIndices.Contains(checkedListBox2.SelectedIndex))
                        checkedListBox2.SetItemChecked(checkedListBox2.SelectedIndex, true);
                    for (int i = 0; i < table.Count; i++)
                    {
                        if (table[i].name == checkedListBox2.Items[checkedListBox2.SelectedIndex].ToString())
                        {
                            table[i].column.Add(checkedListBox1.Items[e.Index].ToString());
                        }
                    }
                }
            }
            if (e.NewValue == CheckState.Unchecked)
            {
                for (int i = 0; i < table.Count; i++)
                {
                    if (table[i].name == checkedListBox2.Items[checkedListBox2.SelectedIndex].ToString())
                    {
                        for (int j = 0; j < table[i].column.Count; j++)
                        {
                            if (table[i].column[j] == checkedListBox1.Items[e.Index].ToString())
                                table[i].column.Remove(table[i].column[j]);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (!checkedListBox1.CheckedIndices.Contains(i))
                    checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string tables = "", columns = "";
                foreach (Table cur in table)
                {
                    tables += "[" + cur.name + "], ";
                    foreach (string col in cur.column)
                    {
                        columns += "[" + cur.name + "].[" + col + "], ";
                    }
                }
                tables = tables.Remove(tables.Length - 2);
                columns = columns.Remove(columns.Length - 2);

                if (checkBox1.Checked)
                    MessageBox.Show("SELECT " + columns + " \nFROM " + tables + " \nWHERE " + textBox1.Text);
                else
                    MessageBox.Show("SELECT " + columns + " \nFROM " + tables);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не выбрано ниодной таблицы или поля.");
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control && checkBox1.Checked && checkedListBox2.SelectedIndex >= 0 && checkedListBox1.SelectedIndex >= 0)
                textBox1.Text += " [" + checkedListBox2.Items[checkedListBox2.SelectedIndex].ToString() + "].["
                    + checkedListBox1.Items[checkedListBox1.SelectedIndex].ToString() + "] ";   
        }

    }
}
