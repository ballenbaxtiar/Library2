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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library2
{
    public partial class brdn : UserControl
    {
        SqlConnection con = Connection.con;

        public brdn()
        {
            InitializeComponent();
           // gunaDateTimePicker1.Text = DateTime.Now.ToString("dd-MM-yyyy");
            //gunaDateTimePicker2.Text = DateTime.Now.ToString("dd-MM-yyyy");

        }

        private void brdn_Load(object sender, EventArgs e)
        {
            gunaTextBox2.Focus();
            //dateTimePicker1.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }


        void hadad__()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("update koga set hadad-=1 where code=N'"+ gunaTextBox4 .Text+ "'",con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            if (gunaTextBox4.Text != "" && gunaTextBox1.Text != "" && gunaTextBox2.Text != "" && gunaTextBox3.Text != "" && gunaTextBox5.Text != "" && gunaTextBox6.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert get_book values(N'" + gunaTextBox2.Text + "',N'" + gunaTextBox3.Text + "',N'" + gunaComboBox2.Text + "',N'" + gunaTextBox1.Text + "',N'" + gunaTextBox6.Text + "',N'" + gunaTextBox5.Text + "',N'" + gunaTextBox4.Text + "',N'" + gunaDateTimePicker1.Text + "',N'" + gunaDateTimePicker2.Text + "',N'" + login.user + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("سەرکەوتووبوو");
                hadad__();
                gunaTextBox4.Clear();
                gunaTextBox1.Clear();
                gunaTextBox2.Clear();
                gunaTextBox3.Clear();
                gunaTextBox5.Clear();
                gunaTextBox6.Clear();
                gunaTextBox2.Focus();
                gunaDateTimePicker1.Text = DateTime.Now.ToString("dd-MM-yyyy");

            }
            else
            {
                MessageBox.Show("تکایە زانیاریەکان بەدروستی پڕبکەوە", "سەرکەوتوونەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



            con.Close();
        }

        private void gunaTextBox4_TextChanged_1(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select name from koga where code= N'" + gunaTextBox4.Text + "' and hadad != 0", con);
            SqlDataReader dd = cmd.ExecuteReader();
            if (dd.Read())
            {
                gunaTextBox5.Text = dd["name"].ToString();
            }
            else
            {
                gunaTextBox5.Clear();
            }

            con.Close();
        }
    }
    
}
