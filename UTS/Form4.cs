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

    public partial class Form4 : Form
    {

        List<Mahasiswa> list = new List<Mahasiswa>();
        public Form4()
        {
            InitializeComponent();
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.nama = "Putra";
            mahasiswa.email = "Putra@example.com";
            mahasiswa.no_hp = 3;
            list.Add(mahasiswa);
    

            dataGridView1.DataSource = list;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form5 TambahData = new Form5(this);

            this.Hide();

            TambahData.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal void AddMahasiswa(Mahasiswa mahasiswa)
        {
            throw new NotImplementedException();
        }
    }

    public class Mahasiswa
    {
        public string nama { get; set; }
        public string email { get; set; }
        public int no_hp { get; set; } 
    }
}
