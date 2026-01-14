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

    public partial class change_language : Form
    {
        SqlConnection con = Connection.con;

        public change_language()
        {
            InitializeComponent();
            get_radio();

        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lang_Load(object sender, EventArgs e)
        {
            get_radio();
        }
         void get_radio()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from language",con);
            SqlDataReader dd = cmd.ExecuteReader();
            if (dd.Read())
            {
                 if (dd["language"].ToString()== "کوردی")
                {
                    gunaRadioButton2.Checked = true;
                }
                else
                {
                    gunaRadioButton1.Checked = true;
                }
            }
            con.Close();
         }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            if (gunaRadioButton1.Checked==true)
            {
                SqlCommand cmd = new SqlCommand("update language set language=N'"+gunaRadioButton1.Text+"'",con);
                cmd.ExecuteNonQuery();
                this.Close();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update language set language=N'" + gunaRadioButton2.Text + "'", con);
                cmd.ExecuteNonQuery();
                this.Close();
            }
            

            con.Close();
        }
    }
}
