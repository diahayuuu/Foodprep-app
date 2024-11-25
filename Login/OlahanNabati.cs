using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Foodprep.cs
{
    public partial class OlahanNabati : Form
    {
        private string _username;
        private string _email;
        public OlahanNabati(string username, string email)
        {
            InitializeComponent();
            _username = username;
            _email = email;
        }

        private void label7_Click(object sender, EventArgs e)
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard(_username, _email);
            dashboardForm.Show();
            this.Hide();
        }

        private void OlahanNabati_Load(object sender, EventArgs e)
        {

        }
    }
}
