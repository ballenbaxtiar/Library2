using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    public partial class backup : UserControl
    {
        SqlConnection con = Connection.con;
        public backup()
        {
            InitializeComponent();
            gunaAdvenceButton2.Enabled = false;
            gunaAdvenceButton1.Enabled = false;

        }

        private void backup_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ff = new FolderBrowserDialog();

            if (ff.ShowDialog() == DialogResult.OK)
            {
                gunaTextBox1.Text = ff.SelectedPath;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Backup file|*.bak";
            op.Title = "Database restory";
            if (op.ShowDialog() == DialogResult.OK)
            {
                gunaTextBox2.Text = op.FileName;
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaTextBox1.Text != "")
                {

                    con.Close();
                    con.Open();
                    string qq = "BACKUP DATABASE Library2 TO DISK ='" + gunaTextBox1.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + ".bak' ";
                    SqlCommand cmd = new SqlCommand(qq, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("هەڵگرتنی داتا سەرکەوتووبوو");
                    gunaTextBox1.Clear();
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("سەرکەوتوونوبوو تکایە هەوڵبدەوە", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {               

            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand(" alter database Library2 set single_user with rollback immediate", con);
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("use master restore DATABASE Library2 from DISK ='" + gunaTextBox2.Text + "' with replace", con);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand(" alter database Library2 set multi_user", con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("گەڕانەوەی داتا سەرکەوتووبوو");

                gunaTextBox2.Clear();
            }
            catch (Exception)
            {
                SqlCommand cmd2 = new SqlCommand(" alter database Library2 set multi_user", con);
                cmd2.ExecuteNonQuery();

                con.Close();
            }
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text != "")
            {
                gunaAdvenceButton2.Enabled = true;
            }
            else
            {
                gunaAdvenceButton2.Enabled = false;
            }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text != "")
            {
                gunaAdvenceButton1.Enabled = true;
            }
            else
            {
                gunaAdvenceButton1.Enabled = false;

            }
        }
    }
}
