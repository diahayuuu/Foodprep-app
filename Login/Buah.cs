using System;
using System.Data;
using System.Windows.Forms;
using Npgsql; 

namespace Foodprep.cs
{
    public partial class Buah : Form
    {
        private string _username;
        private string _email;
        private DataTable fruitsTable; // Variabel untuk menyimpan data tabel buah

        public Buah(string username, string email)
        {
            InitializeComponent();
            _username = username;
            _email = email;
        }

        private void Buah_Load(object sender, EventArgs e)
        {
            // Saat form dibuka, tampilkan semua data buah
            LoadFruitsData();
        }

        private void LoadFruitsData()
        {
            // Connection string untuk PostgreSQL
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=diahayu123;Database=Foodprep";

            try
            {
                // Membuka koneksi ke PostgreSQL
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Query untuk mengambil semua data buah
                    string query = "SELECT name AS \"Name\", storage_method AS \"Storage Method\", storage_duration AS \"Duration\" FROM fruits";

                    // Eksekusi query
                    using (var adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        fruitsTable = new DataTable();
                        adapter.Fill(fruitsTable);

                        // Set DataTable ke DataGridView untuk ditampilkan
                        dataGridViewFruits.DataSource = fruitsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Menangani exception jika koneksi atau query gagal
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Ambil input dari textBox untuk pencarian nama buah
            string fruitName = txtFruits.Text.Trim();

            // Validasi input untuk memastikan pengguna memasukkan nama buah
            if (string.IsNullOrWhiteSpace(fruitName))
            {
                MessageBox.Show("Please enter a fruit name to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gunakan DataView untuk memfilter DataTable
            DataView view = new DataView(fruitsTable);
            view.RowFilter = $"Name LIKE '%{fruitName}%'";

            // Set hasil filter ke DataGridView
            dataGridViewFruits.DataSource = view;

            // Beri pesan jika tidak ada data yang cocok
            if (view.Count == 0)
            {
                MessageBox.Show("No matching fruits found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtFruits_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewFruits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPenyimpanan formPenyimpanan = new FormPenyimpanan(_username, _email);
            formPenyimpanan.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Collection collection = new Collection(_username, _email);
            collection.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(_username, _email);
            profileForm.Show();
            this.Hide();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard(_username, _email);
            dashboardForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
