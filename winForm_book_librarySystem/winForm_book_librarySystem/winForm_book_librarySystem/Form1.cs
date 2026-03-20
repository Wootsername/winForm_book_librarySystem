using System;
using System.Windows.Forms;

namespace winForm_book_librarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            panelHero.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            lblHeroTitle.ForeColor = System.Drawing.Color.White;
            lblHeroSubtitle.ForeColor = System.Drawing.Color.White;
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
