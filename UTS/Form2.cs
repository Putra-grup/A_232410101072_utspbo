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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else if (textBox2.Text == "")
            {
                button1.Enabled = false;
            }
            else if (textBox3.Text != textBox2.Text)
            {
                button1.Enabled = false;
            }
            else if (textBox3.Text == textBox2.Text)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                button1.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox2.Text)
            {
                button1.Enabled = false;
            }
            else if (textBox3.Text == textBox2.Text)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form1 = new Form3();

            this.Hide();

            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();

            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
