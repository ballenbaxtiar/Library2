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
    public partial class back : UserControl
    {
        SqlConnection con = Connection.con;

        public back()
        {
            InitializeComponent();
            getdata();

        }

        private void back_Load(object sender, EventArgs e)
        {
            getdata();
            dataGridView1.Columns["stage"].Width = 50;
            dataGridView1.Columns["id"].Width = 50;
            gunaTextBox2.Focus();
        }
        private void getdata()
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from get_book ", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            design();
        }
        void update_koga()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("update koga set hadad +=1 where code = N'" + gunaTextBox3.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void delete_get_book()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from get_book where id= N'" + gunaTextBox1.Text + "' and codebook=N'"+ gunaTextBox3.Text+ "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void garanawa()
        {
            
                if (gunaTextBox1.Text != "" && gunaTextBox2.Text != "" && gunaTextBox3.Text != "")
                {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into back_book (student,dept,stage,code,phone,name,codebook,datebrdn,datehenanawa,userr) select student,dept,stage,code,phone,name,codebook,datebrdn,datehenanawa,userr from get_book where id= N'" + gunaTextBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                }
               else
               {
                 MessageBox.Show("تکایە زانیاریەکان بەدروستی پڕبکەوە", "سەرکەوتوونەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from get_book where id like N'" + gunaTextBox1.Text + "%'", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
           
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            garanawa();
            delete_get_book();

            update_koga();
            getdata();
            gunaTextBox1.Clear();
            gunaTextBox2.Clear();
            gunaTextBox3.Clear();
            gunaTextBox1.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
