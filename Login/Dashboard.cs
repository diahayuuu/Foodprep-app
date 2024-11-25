using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodprep.cs
{
    public partial class Dashboard : Form
    {
        private string _username;
        private string _email;

        public Dashboard(string username, string email)
        {
            InitializeComponent();
            _username = username;
            _email = email;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPenyimpanan_Click(object sender, EventArgs e)
        {
            FormPenyimpanan formPenyimpanan = new FormPenyimpanan(_username, _email);
            formPenyimpanan.Show();
        }

        private void btnResep_Click(object sender, EventArgs e)
        {
            Resep resep = new Resep(_username, _email);
            resep.Show();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
