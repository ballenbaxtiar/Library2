using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library2
{
    public partial class koga : UserControl
    {
        SqlConnection con = Connection.con;
        public koga()
        {
            InitializeComponent();
            getdata();
            getcombo();
            
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
        private void koga_Load(object sender, EventArgs e)
        {
            gunaTextBox1.Focus();
            getdata();
        }
        private void getdata()
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from koga  where hadad >0", con);
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

            dataGridView1.Columns["code"].HeaderText = "کۆد";
            dataGridView1.Columns["jor"].HeaderText = "جۆر";
            dataGridView1.Columns["name"].HeaderText = "ناو";
            dataGridView1.Columns["nusar"].HeaderText = "نوسەر";
            dataGridView1.Columns["hadad"].HeaderText = "عدد";
            dataGridView1.Columns["userr"].HeaderText = "بەکارهێنەر";
            dataGridView1.Columns["lang"].HeaderText = "زمان";


            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns["hadad"].Width = 50;

        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
                con.Close();
                con.Open();
            try
            {

                if (gunaTextBox1.Text!="" && gunaTextBox2.Text != "" && gunaTextBox3.Text != "" && gunaTextBox4.Text != "" && gunaComboBox1.Text != "" && gunaComboBox2.Text != "" )
                {
                   SqlCommand cmd = new SqlCommand("insert koga values(N'" + gunaTextBox1.Text + "',N'" + gunaTextBox2.Text + "',N'" + gunaTextBox4.Text + "',N'" + gunaComboBox1.Text + "',N'" + gunaTextBox3.Text + "',N'" + login.user + "',N'" + gunaComboBox2.Text + "')", con);
                   cmd.ExecuteNonQuery();
                   getdata();
                    gunaTextBox1.Clear();
                    gunaTextBox2.Clear();
                    gunaTextBox3.Clear();
                    gunaTextBox4.Clear();
                    gunaComboBox1.StartIndex = -1;
                    gunaTextBox1.Focus();
                }
              else
              {
                MessageBox.Show("تکایە هەموو بۆشایەکان بە دروستی پڕبکەوە", "سەرکەوتوو نەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);

              }
           
            }
            catch (Exception)
            {
                MessageBox.Show("تکایە هەموو بۆشایەکان بە دروستی پڕبکەوە", "سەرکەوتوو نەبوو", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gunaTextBox2.SelectAll();
                gunaTextBox2.Focus();

            }

            con.Close();

        }

        private void gunaComboBox1_DropDown(object sender, EventArgs e)
        {
        }
        public static string code = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult dd = MessageBox.Show("دڵنیای لە سڕینەوە", "ئاگاداربە", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dd == DialogResult.Yes)
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from koga where code=N'" + dataGridView1.CurrentRow.Cells["code"].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    getdata();
                    con.Close();
                }
            }
            if (e.ColumnIndex==1)
            {
                code = dataGridView1.CurrentRow.Cells["code"].Value.ToString();
                koga_update kk= new koga_update();
                kk.ShowDialog();
                getdata();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
