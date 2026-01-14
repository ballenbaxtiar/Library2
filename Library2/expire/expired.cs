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
    public partial class expired : UserControl
    {
        SqlConnection con = Connection.con;

        public expired()
        {
            InitializeComponent();
            getdata();
            expire();

        }

        private void expired_Load(object sender, EventArgs e)
        {
            getdata();
            expire();
        }
        void expire()
        {
            con.Close();
            con.Open();
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                DateTime date = DateTime.Parse(dr.Cells["datehenanawa"].Value.ToString());
                TimeSpan ts = date - DateTime.Now;
                if (ts.Days < 0)
                {
                    dr.DefaultCellStyle.BackColor = Color.Red;
                }
                if (ts.Days == 0)
                {
                    dr.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
            con.Close();
        }
        void getdata()
        {
            con.Close();
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter dd = new SqlDataAdapter("select * from get_book", con);
            dd.Fill(dt);
            dataGridView1.DataSource = dt;
            design();
            con.Close();
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


            dataGridView1.Columns["id"].Visible = false;

        }

        private void gunaGradientCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
