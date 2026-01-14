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
    public partial class progres : Form
    {
        public progres()
        {
            InitializeComponent();
            progress.Value = 0;
            progress.Minimum = 0;
            progress.Maximum = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress.Value += 1;
            progress.Text = progress.Value.ToString() + '%';
           
            if (progress.Value == 100)
            {  
                timer1.Stop();
                login ll = new login();
                ll.Show();
                this.Hide();
            }
        }

        private void progress_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
