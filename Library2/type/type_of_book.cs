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
    public partial class type_of_book : UserControl
    {
        SqlConnection con = Connection.con;
        public type_of_book()
        {
            InitializeComponent();
            getdata();
        }

        private void type_of_book_Load(object sender, EventArgs e)
        {
            gunaTextBox1.Focus();
        }
        private void getdata()
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select id,jor from jor_book", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
            design();
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

           // dataGridView1.Columns["id"].HeaderText = "ژمارە";
            dataGridView1.Columns["jor"].HeaderText = "جۆری کتێب";


            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns["id"].Width = 40;
            dataGridView1.Columns["id"].Visible = false;

        }

        private void insert()
        {
            con.Close();
            con.Open();
            if (gunaTextBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert jor_book values(N'" + gunaTextBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                getdata();
                gunaTextBox1.Clear();
                gunaTextBox1.Focus();
            }
            else
            {
                MessageBox.Show("تکایە جۆری کتێب بنوسە", "سەرکەوتو نەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gunaTextBox1.Focus();
            }
            con.Close();
        }
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void gunaTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insert();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult dd = MessageBox.Show("دڵنیای لە سڕینەوە", "ئاگاداربە", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dd == DialogResult.Yes)
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from jor_book where id=N'" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    getdata();
                    con.Close();
                }
            }
        }
    }
}
