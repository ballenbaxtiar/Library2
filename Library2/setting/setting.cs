using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            change_name cc = new change_name();
            cc.ShowDialog();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            about aa = new about();
            aa.ShowDialog();
           
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            change_language ll = new change_language();
            ll.ShowDialog();
        }

        private void setting_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ببورە ئەم بەشە لە ئێستادا بەردەست نیە", "",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
