using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else if (textBox3.Text == "")
            {
                button1.Enabled = false;
            }
            else if (textBox2.Text != textBox3.Text)
            {
                button1.Enabled = false;
            }
            else if (textBox2.Text == textBox3.Text)
            {
                button1.Enabled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            this.Hide();

            form4.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                button1.Enabled = false;
            }
            else if (textBox2.Text == textBox3.Text)
            {
                button1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                button1.Enabled = false;
            }
        }
    }
}
