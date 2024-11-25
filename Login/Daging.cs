using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Foodprep.cs
{
    public partial class Daging : Form
    {
        private string _username;
        private string _email;
        private Collection collectionForm;

        public Daging(Collection collection)
        {
            InitializeComponent();
            this.collectionForm = collection; // Terima instance Collection dari pemanggil
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Data yang ingin disimpan
            string data = @"
                1. Write down the date you bought it.
                2. Don't wash the meat.
                3. Cut the meat while it's still fresh.
                4. Marinate.
                5. Wrap the meat.
                6. Pay attention to the refrigerator temperature.";

            // Tambahkan data ke Collection
            collectionForm.StoredData.Add(data);

            // Refresh data di Collection
            collectionForm.RefreshData();

            // Tampilkan form Collection kembali
            collectionForm.Show();
            this.Hide(); // Sembunyikan form Daging
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Collection collection = new Collection(_username, _email);
            collection.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(_username, _email);
            profile.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormPenyimpanan formPenyimpanan = new FormPenyimpanan(_username, _email);
            formPenyimpanan.Show();
        }

        private void Daging_Load(object sender, EventArgs e)
        {

        }
    }
}
