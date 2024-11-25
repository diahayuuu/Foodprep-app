using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Foodprep.cs
{
    public partial class Resep : Form
    {
        private string _username;
        private string _email;
        private const string apiKey = "311147236b684840849f074ca4e294e2"; // Ganti dengan API Key Anda
        private const string searchUrl = "https://api.spoonacular.com/recipes/complexSearch?apiKey=";
        public Resep(string username, string email)
        {
            InitializeComponent();
            _username = username;
            _email = email;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string query = txtBahan.Text;
            await SearchRecipes(query);
        }

        private async Task SearchRecipes(string query)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(searchUrl + apiKey + "&query=" + query);
                var json = JObject.Parse(response);
                var recipes = json["results"];

                listBoxResep.Items.Clear();
                foreach (var recipe in recipes)
                {
                    listBoxResep.Items.Add(new Recipe
                    {
                        Id = recipe["id"].ToString(),
                        Title = recipe["title"].ToString()
                    });
                }
            }
        }

        private void listBoxResep_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxResep.SelectedItem is Recipe selectedRecipe)
            {
                DetailResep detailResep = new DetailResep(selectedRecipe.Id, _username, _email);
                detailResep.Show();
            }
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
        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(_username, _email);
            dashboard.Show();
            this.Hide();
        }

        private void Resep_Load(object sender, EventArgs e)
        {

        }
    }
}
