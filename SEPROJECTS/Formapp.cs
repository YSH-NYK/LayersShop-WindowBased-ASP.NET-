using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEPROJECTS
{
    public partial class Formapp : Form
    {
        public Formapp()
        {
            
            InitializeComponent();
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(8);
            if(progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Form6 fm = new Form6();
                fm.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
