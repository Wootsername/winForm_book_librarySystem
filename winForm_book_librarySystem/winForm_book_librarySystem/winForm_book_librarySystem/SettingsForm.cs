using System;
using System.Linq;
using System.Windows.Forms;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
            this.StartPosition = FormStartPosition.CenterParent; // Center perfectly in parent window
            LoadStudentAccountData();
            SetupEventHandlers();
        }

        private void LoadStudentAccountData()
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    int userId = Session.CurrentUserId;
                    var user = context.Users.Find(userId);
                    if (user != null)
                    {
                        txtDisplayName.Text = user.FullName;
                        txtPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Could not retrieve account details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading account data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupEventHandlers()
        {
            btnSave.Click += btnSave_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newName = txtDisplayName.Text.Trim();
            string newPassword = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Display name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new LibraryContext())
                {
                    int userId = Session.CurrentUserId;
                    var user = context.Users.Find(userId);
                    if (user != null)
                    {
                        user.FullName = newName;
                        if (!string.IsNullOrEmpty(newPassword))
                        {
                            user.Password = newPassword;
                        }

                        context.SaveChanges();

                        // Synchronize session values dynamically so that parent dashboard updates
                        Session.CurrentUserName = user.FullName;

                        MessageBox.Show("Account settings updated successfully!", "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save. Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving account settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
