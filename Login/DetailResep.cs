using Newtonsoft.Json.Linq;
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
    public partial class DetailResep : Form
    {
        private string _username;
        private string _email;
        private const string apiKey = "311147236b684840849f074ca4e294e2"; // Ganti dengan API Key Anda
        private const string recipeUrl = "https://api.spoonacular.com/recipes/";

        public DetailResep(string recipeId, string username, string email)
        {
            InitializeComponent();
            LoadRecipeDetails(recipeId);
            _username = username;
            _email = email;

        }
        private async void LoadRecipeDetails(string recipeId)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(recipeUrl + recipeId + "/information?apiKey=" + apiKey);
                var recipe = JObject.Parse(response);

                labelTitle.Text = recipe["title"].ToString();
                pictureBoxRecipe.ImageLocation = recipe["image"].ToString();
                txtDescription.Text = recipe["summary"].ToString();
                txtSteps.Text = string.Join(Environment.NewLine, recipe["analyzedInstructions"][0]["steps"].Select(step => step["step"].ToString()));
            }
        }
        private void DetailResep_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(_username, _email);
            dashboard.Show();
            this.Hide();
        }
    }
}
