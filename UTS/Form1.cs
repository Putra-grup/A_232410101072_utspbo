namespace UTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();

            this.Hide();

            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form4 = new Form6();

            this.Hide();

            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            this.Hide();

            form4.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
