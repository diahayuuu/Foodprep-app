using System;
using System.Windows.Forms;

namespace Foodprep.cs
{
    public class FormBase : Form
    {
        protected void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
