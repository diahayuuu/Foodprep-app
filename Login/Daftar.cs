﻿using Npgsql;
using System;
using System.Windows.Forms;

namespace Foodprep.cs
{
    public partial class DaftarForm : FormBase // Turunan dari FormBase
    {
        public DaftarForm()
        {
            InitializeComponent();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika jika diperlukan, misalnya validasi email.
        }
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika jika diperlukan, misalnya validasi password.
        }
        private void DaftarForm_Load(object sender, EventArgs e)
        {
            // Tambahkan logika untuk inisialisasi form jika diperlukan.
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnDaftar_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ShowErrorMessage("Mohon isi semua kolom!");
            }
            else
            {
                string connString = "Host=localhost;Port=5432;Username=postgres;Password=diahayu123;Database=Foodprep";

                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO tb_users (username, email, password) VALUES (@username, @email, @password)";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("username", username);
                            cmd.Parameters.AddWithValue("email", email);
                            cmd.Parameters.AddWithValue("password", password);

                            cmd.ExecuteNonQuery();
                        }

                        ShowSuccessMessage("Pendaftaran Berhasil!");
                    }
                    catch (Exception ex)
                    {
                        ShowErrorMessage("Terjadi kesalahan: " + ex.Message);
                    }
                }
            }
        }
    }
}
