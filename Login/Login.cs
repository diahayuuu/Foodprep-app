using Foodprep.cs;
using Npgsql;
using System;
using System.Windows.Forms;

namespace Foodprep.cs
{
    public partial class LoginForm : FormBase // Turunan dari FormBase
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDaftar_Click_1(object sender, EventArgs e)
        {
            DaftarForm daftarForm = new DaftarForm();
            daftarForm.Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e) //properti private yang hanya bisa diakses dalam kelas ini yaitu Login
        {
            string username = tbUsername.Text; // Ambil input username
            string password = tbPassword.Text; // Ambil input password

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ShowErrorMessage("Mohon isi semua kolom!");
                return;
            }

            string connString = "Host=localhost;Port=5432;Username=postgres;Password=diahayu123;Database=Foodprep";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Periksa keberadaan username dan password
                    string query = "SELECT email FROM tb_users WHERE username = @username AND password = @password";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);

                        var email = cmd.ExecuteScalar();

                        if (email != null)
                        {
                            ShowSuccessMessage("Login Berhasil!");

                            // Kirim data ke Dashboard
                            Dashboard dashboardForm = new Dashboard(username, email.ToString());
                            dashboardForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            ShowErrorMessage("Username atau Password salah!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("Terjadi kesalahan: " + ex.Message);
                }
            }
        }
    }
}
