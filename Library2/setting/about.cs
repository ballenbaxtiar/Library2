using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Library2
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           Process.Start("https://www.facebook.com/profile.php?id=100010353331934");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/akar_muhammad600/");       
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.snapchat.com/add/akar.it?share_id=rPxeZCcdQT+pbHeoLwdTWw&locale=en_US&sid=8a2ec7b50dd24e1faed9f4259a8273bb\r\n");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/akar_it");        
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/1i.hama.i1/");       
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/C9hama");        
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.snapchat.com/05lMbsWQ");
        }
    }
}
