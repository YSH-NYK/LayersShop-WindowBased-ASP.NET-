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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Form2 fn = new Form2();
            this.Hide();
            fn.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Form13 f3 = new Form13();
            this.Hide();
            f3.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 fn = new Form14();
            this.Hide();
            fn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form13 fn = new Form13();
            this.Hide();
            fn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form6 fn = new Form6();
            this.Hide();
            fn.Show();

        }
    }
}
