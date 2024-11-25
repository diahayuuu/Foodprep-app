using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Foodprep.cs
{
    public partial class Collection : Form
    {
        private string _username;
        private string _email;
        public List<string> StoredData { get; set; } = new List<string>();

        public Collection(string username, string email)
        {
            InitializeComponent();
            _username = username;
            _email = email;
        }

        public void RefreshData()
        {
           
        }

        private void Collection_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(_username, _email);
            profileForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard(_username, _email);
            dashboardForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData(); // Tampilkan data saat form dimuat

            // Kosongkan tampilan sebelumnya
            this.Controls.Clear();
            InitializeComponent();

            // Tampilkan setiap item dalam StoredData
            int y = 50; // Awal posisi Y untuk data
            foreach (string data in StoredData)
            {
                Label label = new Label
                {
                    Text = data,
                    Location = new Point(20, y),
                    AutoSize = true
                };
                this.Controls.Add(label);
                y += 100; // Pindahkan posisi Y untuk label berikutnya
            }
        }
    }
}
