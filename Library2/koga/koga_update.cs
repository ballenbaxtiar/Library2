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
    public partial class koga_update : Form
    {
        SqlConnection con = Connection.con;

        public koga_update()
        {
            InitializeComponent();
            getdata();
            getcombo();

        }
        private void getdata()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from koga where code=N'"+koga.code+"'", con);
            SqlDataReader dd = cmd.ExecuteReader();
            if (dd.Read())
            {
                gunaTextBox1.Text = dd["name"].ToString();
                gunaTextBox2.Text = dd["code"].ToString();
                gunaTextBox4.Text = dd["nusar"].ToString();
                gunaComboBox1.Text = dd["jor"].ToString();
                gunaComboBox2.Text = dd["lang"].ToString();
                gunaTextBox3.Text = dd["hadad"].ToString();
            }

            con.Close();
         }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void getcombo()
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from jor_book", con);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gunaComboBox1.Items.Add(dt.Rows[i]["jor"]);
            }

            con.Close();


            con.Close();
        }
        private void koga_update_Load(object sender, EventArgs e)
        {
            getdata();


        }

        private void gunaComboBox1_DropDown(object sender, EventArgs e)
        {
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            try
            {

                if (gunaTextBox1.Text != "" && gunaTextBox2.Text != "" && gunaTextBox3.Text != "" && gunaTextBox4.Text != "" && gunaComboBox1.Text != "" && gunaComboBox2.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("update koga set name=N'" + gunaTextBox1.Text + "',code=N'" + gunaTextBox2.Text + "',nusar=N'" + gunaTextBox4.Text + "',jor=N'" + gunaComboBox1.Text + "',hadad=N'" + gunaTextBox3.Text + "',lang=N'" + gunaComboBox2.Text + "' where code=N'"+koga.code+"'", con);
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("تکایە هەموو بۆشایەکان بە دروستی پڕبکەوە", "سەرکەوتوو نەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("تکایە هەموو بۆشایەکان بە دروستی پڕبکەوە", "سەرکەوتوو نەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            con.Close();

        }
    }
}
