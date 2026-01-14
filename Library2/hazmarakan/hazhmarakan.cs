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
    public partial class hazhmarakan : UserControl
    {
        SqlConnection con = Connection.con;

        public hazhmarakan()
        {
            InitializeComponent();
            getdata();
        }

        private void hazhmarakan_Load(object sender, EventArgs e)
        {
            gunaTextBox2.Focus();
            getdata();
            
        }
        private void getdata()
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from loginn", con);
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

            dataGridView1.Columns["id"].HeaderText = "ژمارە";
            dataGridView1.Columns["user_name"].HeaderText = "ناوی بەکارهێنەر";
            dataGridView1.Columns["name"].HeaderText = "ناوی سیانی";
            dataGridView1.Columns["pass"].HeaderText = "وشەی نهێنی";
            dataGridView1.Columns["pla"].HeaderText = "پلە";



            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns["pla"].Width = 100;
            dataGridView1.Columns["id"].Visible = false;

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            if (gunaTextBox1.Text != "" && gunaTextBox2.Text != "" && gunaTextBox3.Text != "" &&  gunaComboBox2.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert loginn values(N'" + gunaTextBox2.Text + "',N'" + gunaTextBox3.Text + "',N'" + gunaTextBox1.Text + "',N'" + gunaComboBox2.Text + "')", con);
                cmd.ExecuteNonQuery();
                getdata();
                gunaTextBox1.Clear();
                gunaTextBox2.Clear();
                gunaTextBox3.Clear();
                gunaComboBox2.StartIndex = 1;
                gunaTextBox2.Focus();
            }
            else
            {
                MessageBox.Show("تکایە هەموو بۆشایەکان بە دروستی پڕبکەوە", "سەرکەوتوو نەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public static string id = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult dd = MessageBox.Show("دڵنیای لە سڕینەوە", "ئاگاداربە", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dd == DialogResult.Yes)
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from loginn where id=N'" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    getdata();
                    con.Close();
                }
            }
            if (e.ColumnIndex == 1)
            {
               id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                update_hazhmar kk = new update_hazhmar();
                kk.ShowDialog();
                getdata();

            }
        }
    }
}
