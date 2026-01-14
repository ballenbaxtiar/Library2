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
    public partial class subhome : UserControl
    {
        SqlConnection con = Connection.con;

        public subhome()
        {
            InitializeComponent();
            getname();
            translate();
        }
        void translate()
        {
            Language.translate();
            btnparastn.Text = Language.backup;
            btnkoga.Text = Language.koga;
            btnhenanubrdn.Text = Language.get_back;
            btnbrdn.Text = Language.take_book;
            btnexpire.Text = Language.expired;
            btngaranawa.Text = Language.back;
            btnusers.Text = Language.user;
            btntype.Text = Language.type_book;
            btntawawbu.Text = Language.ended;
            saraky = Language.home;
        }
        void control(Control cc)
        {
            cc.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(cc);
        }
        public static string saraky = Language.home;
        private void btnparastn_Click(object sender, EventArgs e)
        {
            backup bb = new backup();
            control(bb);
            saraky = Language.backup;
        }

        private void subhome_Load(object sender, EventArgs e)
        {
            getname();

        }
        void getname()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from name", con);
            SqlDataReader dd = cmd.ExecuteReader();
            if (dd.Read())
            {
                label1.Text = dd["name"].ToString();
            }


            con.Close();
        }
        private void btntype_Click(object sender, EventArgs e)
        {
            type_of_book tt = new type_of_book();
            control(tt);
            saraky = Language.type_book;
        }

        private void btnkoga_Click(object sender, EventArgs e)
        {
            koga kk = new koga();
            control(kk);
            saraky = Language.koga;

        }

        private void btntawawbu_Click(object sender, EventArgs e)
        {
            tawawbwakan tt = new tawawbwakan();
            control(tt);
            saraky = Language.ended;
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            if (login.pla=="بەڕێوبەر")
            {
             hazhmarakan hh = new hazhmarakan();
             control(hh);
             saraky= Language.user;
            }
            else
            {
                MessageBox.Show("ناتوانی بچیتە ژورەوە چونکە تۆ کارمەندی","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
          
        }

        private void btnbrdn_Click(object sender, EventArgs e)
        {
            brdn bb = new brdn();
            control(bb);
            saraky = Language.take_book;
        }



        private void btngaranawa_Click(object sender, EventArgs e)
        {
            back bb = new back();
            control(bb);
            saraky = Language.back;
        }

        private void btnhenanubrdn_Click(object sender, EventArgs e)
        {
            henan_brdn hh = new henan_brdn();
            control(hh);
            saraky = Language.get_back;
        }

        private void btnexpire_Click(object sender, EventArgs e)
        {
            expired ee = new expired();
            control(ee);
            saraky = Language.expired;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
