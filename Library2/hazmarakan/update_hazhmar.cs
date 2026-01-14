using Guna.UI.WinForms;
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

namespace Library2
{
    public partial class update_hazhmar : Form
    {
        SqlConnection con = Connection.con;

        public update_hazhmar()
        {
            InitializeComponent();
            getdata();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_hazhmar_Load(object sender, EventArgs e)
        {
            getdata();

        }
        private void getdata()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from loginn where id=N'" + hazhmarakan.id + "'", con);
            SqlDataReader dd = cmd.ExecuteReader();
            if (dd.Read())
            {
                gunaTextBox1.Text = dd["pass"].ToString();
                gunaTextBox2.Text = dd["name"].ToString();
                gunaComboBox2.Text = dd["pla"].ToString();
                gunaTextBox3.Text = dd["user_name"].ToString();
            }

            con.Close();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            if (gunaTextBox1.Text != "" && gunaTextBox2.Text != "" && gunaTextBox3.Text != "" &&  gunaComboBox2.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update loginn set name=N'" + gunaTextBox2.Text + "',user_name=N'" + gunaTextBox3.Text + "' ,pass=N'" + gunaTextBox1.Text + "',pla=N'" + gunaComboBox2.Text + "' where id='"+hazhmarakan.id+"'", con);
                cmd.ExecuteNonQuery();
                this.Close();
            }
            else
            {
                MessageBox.Show("تکایە هەموو بۆشایەکان بە دروستی پڕبکەوە", "سەرکەوتوو نەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            con.Close();
        }
    }
}
