using System;
using System.Linq;
using System.Windows.Forms;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email format.");
                return;
            }

            lblError.Visible = false;

            try
            {
                using (var context = new LibraryContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.Email == txtEmail.Text && u.Password == txtPassword.Text);

                    if (user != null)
                    {
                        Session.CurrentUserId = user.UserID;
                        Session.CurrentUserRole = user.Role;
                        Session.CurrentUserName = user.FullName;

                        Hide();
                        Form dashboard = null;

                        if (user.Role == "Student")
                        {
                            dashboard = new StudentDashboard();
                        }
                        else if (user.Role == "Librarian")
                        {
                            dashboard = new LibrarianDashboard();
                        }
                        else if (user.Role == "Admin")
                        {
                            dashboard = new AdminDashboard();
                        }
                        
                        if (dashboard != null)
                        {
                            dashboard.FormClosed += (s, args) => Show();
                            dashboard.Show();
                            txtPassword.Clear();
                        }
                        else
                        {
                            lblError.Text = "Invalid user role.";
                            lblError.Visible = true;
                            Show();
                        }
                    }
                    else
                    {
                        lblError.Text = "Invalid email or password.";
                        lblError.Visible = true;
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Database connection error.";
                lblError.Visible = true;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
