using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Foodprep.cs
{
    public partial class FormPenyimpanan : Form
    {
        private string _username;
        private string _email;
        private Collection collectionForm; // Tambahkan variabel untuk menyimpan instance Collection

        public FormPenyimpanan(string username, string email)
        {
            InitializeComponent();
            collectionForm = new Collection(_username, _email); // Inisialisasi instance Collection saat form dibuat
            _username = username;
            _email = email;
        }

        private void FormPenyimpanan_Load(object sender, EventArgs e)
        {
            // Bisa ditambahkan logika lain saat form dimuat, jika diperlukan
        }

        private void btnBuah_Click(object sender, EventArgs e)
        {
            Buah buah = new Buah(_username, _email);
            buah.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(_username, _email);
            dashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tampilkan form Collection
            collectionForm.Show();
        }

        private void btnDaging_Click(object sender, EventArgs e)
        {
            // Kirimkan instance Collection ke form Daging
            Daging dagingForm = new Daging(collectionForm);
            dagingForm.Show();
            this.Hide(); // Opsional: sembunyikan form ini
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ikan ikan = new Ikan(_username, _email);
            ikan.Show();
            this.Hide();
        }

        private void btnSayur_Click(object sender, EventArgs e)
        {
            Sayur sayur = new Sayur(_username, _email);
            sayur.Show();
            this.Hide();
        }

        private void btnNabati_Click(object sender, EventArgs e)
        {
            OlahanNabati olahanNabati = new OlahanNabati(_username, _email);
            olahanNabati.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OlahanSusu olahanSusu = new OlahanSusu(_username, _email);
            olahanSusu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(_username, _email);
            profile.Show();
            this.Hide();
        }
    }
}
