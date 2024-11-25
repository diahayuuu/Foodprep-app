using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Foodprep.cs
{
    public partial class Sayur : Form
    {
        private string _username;
        private string _email;
        private DataTable vegetablesTable;
        public Sayur(string username, string email)
        {
            InitializeComponent();
            _username = username;
            _email = email;
        }

        private void Sayur_Load(object sender, EventArgs e)
        {
            LoadVegetablesData();
        }
        private void LoadVegetablesData()
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=diahayu123;Database=Foodprep";

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name AS \"Name\", storage_method AS \"Storage Method\", storage_duration AS \"Duration\" FROM vegetables";
                    using (var adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        vegetablesTable = new DataTable();
                        adapter.Fill(vegetablesTable);

                        // Set DataTable ke DataGridView untuk ditampilkan
                        dataGridViewVegetables.DataSource = vegetablesTable;
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
            string vegetablesName = txtVegetables.Text.Trim();

            if (string.IsNullOrWhiteSpace(vegetablesName))
            {
                MessageBox.Show("Please enter a vegetable name to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataView view = new DataView(vegetablesTable);
            view.RowFilter = $"Name LIKE '%{vegetablesName}%'";

            dataGridViewVegetables.DataSource = view;

            if (view.Count == 0)
            {
                MessageBox.Show("No matching vegetables found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}
