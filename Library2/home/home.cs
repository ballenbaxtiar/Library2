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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            subhome ss = new subhome();
            control(ss);
          

        }
        void control(Control cc)
        {
            cc.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(cc);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }     
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            subhome ss = new subhome();
            control(ss);
            subhome.saraky = Language.home;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = subhome.saraky;
          

        }

        private void home_Load(object sender, EventArgs e)
        {
         
        }
       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            login ll = new login();
            ll.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            setting ss = new setting();
            ss.ShowDialog();
         }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
