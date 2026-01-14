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
    public partial class change_name : Form
    {
        SqlConnection con = Connection.con;

        public change_name()
        {
            InitializeComponent();
            getname();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void getname()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from name",con);
            SqlDataReader dd = cmd .ExecuteReader();
            if (dd.Read())
            {
                gunaTextBox3.Text = dd["name"].ToString();
            }


            con.Close();
        }

        private void change_name_Load(object sender, EventArgs e)
        {
            getname();
        }
        void change()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("update name set name=N'"+gunaTextBox3.Text+"'", con);
            cmd.ExecuteNonQuery();
            this.Close();
            con.Close();
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            change();
        }

        private void gunaTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                change();
            }

        }
    }
}
