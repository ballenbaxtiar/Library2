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
    public partial class henan_brdn : UserControl
    {
        SqlConnection con = Connection.con;

        public henan_brdn()
        {
            InitializeComponent();
            getdata();
            
            
        }

        private void henan_brdn_Load(object sender, EventArgs e)
        {
            gunaTextBox1.Focus();

            dataGridView1.Columns["stage"].Width = 50;
            dataGridView1.Columns["id"].Width = 50;

        }

        void design()
        {
            foreach (DataGridViewColumn dd in dataGridView1.Columns)
            {
                dd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("NRT Reg, 11.25pt", 10, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            // dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.Columns["id"].HeaderText = "ژمارە";
            dataGridView1.Columns["student"].HeaderText = "قوتابی";
            dataGridView1.Columns["dept"].HeaderText = "بەش";
            dataGridView1.Columns["stage"].HeaderText = "قۆناغ";
            dataGridView1.Columns["code"].HeaderText = "کۆدی باج";
            dataGridView1.Columns["phone"].HeaderText = "ژ.مۆبایل";
            dataGridView1.Columns["codebook"].HeaderText = "کۆدی کتێب";
            dataGridView1.Columns["name"].HeaderText = "ناوی کتێب";
            dataGridView1.Columns["datebrdn"].HeaderText = "ب.بردن";
            dataGridView1.Columns["datehenanawa"].HeaderText = "ب.هێنانەوە";
            dataGridView1.Columns["userr"].HeaderText = "بەکارهێنەر";

        }
        void getdata()
        {
            con.Close();
            con.Open();
            if (gunaRadioButton1.Checked==true)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dd = new SqlDataAdapter("select * from back_book where student like N'" + gunaTextBox1.Text + "%' or dept like N'" + gunaTextBox1.Text + "%' or stage like N'" + gunaTextBox1.Text + "%' or code like N'" + gunaTextBox1.Text + "%' or phone like N'" + gunaTextBox1.Text + "%' or codebook like N'" + gunaTextBox1.Text + "%' or name like N'" + gunaTextBox1.Text + "%'", con);
                dd.Fill(dt);
                dataGridView1.DataSource= dt;
                design();

            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dd = new SqlDataAdapter("select * from get_book where student like N'" + gunaTextBox1.Text + "%' or dept like N'" + gunaTextBox1.Text + "%' or stage like N'" + gunaTextBox1.Text + "%' or code like N'" + gunaTextBox1.Text + "%' or phone like N'" + gunaTextBox1.Text + "%' or codebook like N'" + gunaTextBox1.Text + "%' or name like N'" + gunaTextBox1.Text + "%'", con);
                dd.Fill(dt);
                dataGridView1.DataSource = dt;
                design();
            }




            con.Close();    
        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            getdata();
        }

        private void gunaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            getdata();
        }



        private void gunaTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
