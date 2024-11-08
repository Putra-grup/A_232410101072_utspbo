namespace UTS
{
    public partial class Form5 : Form
    {
        private Form4 _form4; // Field untuk menyimpan referensi Form4 yang aktif

        public Form5(Form4 form4)
        {
            InitializeComponent();
            _form4 = form4; // Simpan referensi Form4 yang diterima
        }



        public Mahasiswa getMahasiswa()
        {
            Mahasiswa newMahasiswa = new Mahasiswa
            {
                nama = textBox1.Text,
                email = textBox2.Text,
                no_hp = textBox3.Text
               
            };

            return newMahasiswa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form4.AddMahasiswa(getMahasiswa());
            this.Hide();
            _form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form1 = new Form4();
            this.Hide();
            form1.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
