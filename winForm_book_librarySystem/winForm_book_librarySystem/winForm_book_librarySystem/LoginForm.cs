using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class LoginForm : Form
    {
        private string selectedRole = "Student";

        public LoginForm()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
            StyleComponents();
            SetupEventHandlers();
        }

        private void StyleComponents()
        {
            // Left sidebar logo container
            ThemeSettings.MakeRoundedControl(pnlLogoIcon, 12, null, 0);

            // Left feature icons
            ThemeSettings.MakeRoundedControl(pnlFeatIcon1, 8, null, 0);
            ThemeSettings.MakeRoundedControl(pnlFeatIcon2, 8, null, 0);
            ThemeSettings.MakeRoundedControl(pnlFeatIcon3, 8, null, 0);

            // TextBoxes
            ThemeSettings.StyleTextBox(txtEmail);
            ThemeSettings.StyleTextBox(txtPassword);

            // Login Button
            ThemeSettings.StyleButtonSolidGold(btnLogin);
        }

        private void SetupEventHandlers()
        {
            btnRoleStudent.Click += BtnRoleStudent_Click;
            btnRoleLibrarian.Click += BtnRoleLibrarian_Click;
            btnRoleAdmin.Click += BtnRoleAdmin_Click;
            btnLogin.Click += BtnLogin_Click;
            lnkForgot.LinkClicked += LnkForgot_LinkClicked;

            // Set default role button appearance
            UpdateRoleButtonAppearance();
        }

        private void BtnRoleStudent_Click(object sender, EventArgs e)
        {
            selectedRole = "Student";
            UpdateRoleButtonAppearance();
        }

        private void BtnRoleLibrarian_Click(object sender, EventArgs e)
        {
            selectedRole = "Librarian";
            UpdateRoleButtonAppearance();
        }

        private void BtnRoleAdmin_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";
            UpdateRoleButtonAppearance();
        }

        private void UpdateRoleButtonAppearance()
        {
            // Reset all buttons
            ThemeSettings.StyleButtonSecondary(btnRoleStudent);
            ThemeSettings.StyleButtonSecondary(btnRoleLibrarian);
            ThemeSettings.StyleButtonSecondary(btnRoleAdmin);

            // Highlight selected role
            Button selectedBtn = null;
            switch (selectedRole)
            {
                case "Student":
                    selectedBtn = btnRoleStudent;
                    break;
                case "Librarian":
                    selectedBtn = btnRoleLibrarian;
                    break;
                case "Admin":
                    selectedBtn = btnRoleAdmin;
                    break;
            }

            if (selectedBtn != null)
            {
                selectedBtn.BackColor = ThemeSettings.GoldLight;
                selectedBtn.ForeColor = ThemeSettings.Gold;
                selectedBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                ThemeSettings.MakeRoundedControl(selectedBtn, 8, ThemeSettings.Gold, 1);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new LibraryContext())
                {
                    var user = context.Users
                        .AsNoTracking()
                        .FirstOrDefault(u => u.Email == email && u.Role == selectedRole);

                    if (user == null)
                    {
                        MessageBox.Show($"Invalid credentials for {selectedRole} role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtPassword.Focus();
                        return;
                    }

                    // Simple password check (in production, use proper hashing)
                    if (user.Password != password)
                    {
                        MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtPassword.Focus();
                        return;
                    }

                    // Store user session
                    Session.CurrentUserId = user.UserID;
                    Session.CurrentUserName = user.FullName;
                    Session.CurrentUserRole = user.Role;

                    // Navigate to appropriate dashboard
                    OpenDashboard(user.Role);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenDashboard(string role)
        {
            Form dashboard = null;

            switch (role)
            {
                case "Student":
                    dashboard = new StudentDashboard();
                    break;
                case "Librarian":
                    dashboard = new LibrarianDashboard();
                    break;
                case "Admin":
                    dashboard = new AdminDashboard();
                    break;
            }

            if (dashboard != null)
            {
                this.Hide();
                dashboard.ShowDialog(this);
                this.Show();
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }
        }

        private void LnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact the library administrator to reset your password.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

