using System;
using System.Windows.Forms;

namespace winForm_book_librarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.Equals(txtUsername.Text, "admin", StringComparison.OrdinalIgnoreCase) &&
                txtPassword.Text == "password")
            {
                Hide();
                using (var menu = new Form2())
                {
                    menu.ShowDialog(this);
                }
                Show();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
                lblError.Visible = true;
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
