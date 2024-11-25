using System;
using System.Windows.Forms;

namespace Foodprep.cs
{
    public partial class Profile : Form
    {
        private string _username;
        private string _email;


        // Constructor yang menerima parameter username dan email

        public Profile(string username, string email)
        {
            InitializeComponent();
            _username = username;
            _email = email;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            // Tampilkan data pada label
            label2.Text = $"{_username}";
            label3.Text = $"{_email}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Collection collection = new Collection(_username, _email);
            collection.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(_username, _email);
            profile.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard(_username, _email);
            dashboardForm.Show();
            this.Hide();
        }
    }
}
