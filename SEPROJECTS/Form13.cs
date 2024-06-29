using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEPROJECTS
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
   
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        { 
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Form13 f3 = new Form13();
            this.Hide();
            f3.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 fn = new Form14();
            this.Hide();
            fn.Show();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Items.Add("Dark");
            if (comboBox6.SelectedIndex == 0)
            {
                Form8 fn = new Form8();
                this.Hide();
                fn.Show();
            }
            comboBox6.Items.Add("CyberForce");
            if (comboBox6.SelectedIndex == 1)
            {
                Form9 fn = new Form9();
                this.Hide();
                fn.Show();
            }
            comboBox6.Items.Add("The Ripple");
            if (comboBox6.SelectedIndex == 2)
            {
                Form11 fn = new Form11();
                this.Hide();
                fn.Show();
            }
            comboBox6.Items.Add("Into The Woods");
            if (comboBox6.SelectedIndex == 3)
            {
                Form10 fn = new Form10();
                this.Hide();
                fn.Show();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            Form13 fn = new Form13();
            this.Hide();
            fn.Show();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

            Form6 fn = new Form6();
            this.Hide();
            fn.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Form2 fn = new Form2();
            this.Hide();
            fn.Show();

        }
    }
}
