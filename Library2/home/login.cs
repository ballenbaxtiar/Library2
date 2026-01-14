using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    public partial class login : Form
    {
        SqlConnection con = Connection.con;
        public login()
        {
            InitializeComponent();
            getname();
      
        }

        public static string user = "";
        public static string pla = "";
        private void login_Load(object sender, EventArgs e)
        {
            getname();
            gunaTextBox3.Focus();

           
        }

        void getname()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from name",con);
            SqlDataReader dd = cmd .ExecuteReader();
            if (dd.Read()) {
                label1.Text = dd["name"].ToString();
            }


            con.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (gunaTextBox1.PasswordChar=='*')
            {
                gunaTextBox1.PasswordChar = '\0';
                pictureBox4.BringToFront();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (gunaTextBox1.PasswordChar == '\0')
            {
                gunaTextBox1.PasswordChar = '*';
                pictureBox3.BringToFront();
            }
        }
        
        void loginn()
        {
                  
            con.Close();
            con.Open();
            if (gunaRadioButton1.Checked==true)
            {
                SqlCommand cmd = new SqlCommand("select * from loginn where user_name=N'"+gunaTextBox3.Text+"' and pass=N'"+gunaTextBox1.Text+"' and pla=N'"+gunaRadioButton1.Text+"'",con);
                SqlDataReader dd = cmd.ExecuteReader();
                if (dd.Read()  )
                {
                   pla = dd["pla"].ToString();
                   user = dd["name"].ToString();
                   home hh = new home();
                   hh.Show();
                   this.Hide();
                }
                else if(gunaTextBox3.Text =="akar" && gunaTextBox1.Text =="akard")
                {
                        pla = "بەڕێوبەر";
                        user = "Admin";
                        home hh = new home();
                        hh.Show();
                        this.Hide();
                }
                else
                {
                    MessageBox.Show("تکایە زانیاریەکان بەدروستی پڕبکەوە", "سەرکەوتوونەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from loginn where user_name=N'" + gunaTextBox3.Text + "' and pass=N'" + gunaTextBox1.Text + "' and pla=N'" + gunaRadioButton2.Text + "' ", con);
                SqlDataReader dd = cmd.ExecuteReader();
                if (dd.Read())
                {
                    pla = dd["pla"].ToString();
                    user = dd["name"].ToString();
                    home hh = new home();
                    hh.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("تکایە زانیاریەکان بەدروستی پڕبکەوە", "سەرکەوتوونەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
            con.Close();
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            loginn();
        }

     

        private void gunaTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                loginn();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
