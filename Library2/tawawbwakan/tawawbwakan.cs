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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Library2
{
    public partial class tawawbwakan : UserControl
    {
        SqlConnection con = Connection.con;

        public tawawbwakan()
        {
            InitializeComponent();
            getdata();
        }

        private void tawawbwakan_Load(object sender, EventArgs e)
        {
            gunaTextBox2.Focus();
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

            dataGridView1.Columns["code"].HeaderText = "کۆد";
            dataGridView1.Columns["name"].HeaderText = "ناو";
            dataGridView1.Columns["nusar"].HeaderText = "نوسەر";
            dataGridView1.Columns["jor"].HeaderText = "جۆر";
            dataGridView1.Columns["hadad"].HeaderText = "عدد";
            dataGridView1.Columns["userr"].HeaderText = "بەکارهێنەر";
            dataGridView1.Columns["lang"].HeaderText = "زمان";


        }
        private void getdata()
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from koga where hadad<=0", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
            design();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (gunaTextBox3.Text != "0" && gunaTextBox2.Text != "")
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("update koga set hadad= N'" + gunaTextBox3.Text + "' where code= N'" + gunaTextBox2.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("نوێکردنەوە سەرکەوتووبوو");
                gunaTextBox3.Clear();
                gunaTextBox2.Clear();
                gunaTextBox2.Focus();
                getdata();
                con.Close();
            }
            else
            {
                MessageBox.Show("تکایە هەموو بۆشایەکان بە دروستی پڕبکەوە", "سەرکەوتوو نەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from koga where code= N'" + gunaTextBox2.Text + "' and hadad=0", con);
            SqlDataReader dd = cmd.ExecuteReader();
            if (dd.Read())
            {
                gunaTextBox3.Focus();
                gunaAdvenceButton1.Enabled = true;
            }
            else
            {
                gunaAdvenceButton1.Enabled = false;
            }
            con.Close();
        }
    }
}
