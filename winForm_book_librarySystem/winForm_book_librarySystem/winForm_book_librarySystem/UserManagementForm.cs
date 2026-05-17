using System;
using System.Linq;
using System.Windows.Forms;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class UserManagementForm : Form
    {
        private int? _editingUserId = null;

        public UserManagementForm()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
            LoadUsers();
            SetInputState(false);
        }

        private void LoadUsers(string searchQuery = "")
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    var query = context.Users.AsQueryable();

                    if (!string.IsNullOrWhiteSpace(searchQuery))
                    {
                        query = query.Where(u => u.FullName.Contains(searchQuery) || u.Email.Contains(searchQuery));
                    }

                    // Select properties to show in the Grid to avoid showing EF circular references
                    var usersList = query.Select(u => new
                    {
                        u.UserID,
                        u.FullName,
                        u.Email,
                        u.Role
                    }).ToList();

                    dgvUsers.DataSource = usersList;

                    // Clean up grid headers
                    if (dgvUsers.Columns["UserID"] != null) dgvUsers.Columns["UserID"].HeaderText = "User ID";
                    if (dgvUsers.Columns["FullName"] != null) dgvUsers.Columns["FullName"].HeaderText = "Full Name";
                    if (dgvUsers.Columns["Email"] != null) dgvUsers.Columns["Email"].HeaderText = "Email Address";
                    if (dgvUsers.Columns["Role"] != null) dgvUsers.Columns["Role"].HeaderText = "System Role";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user list: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetInputState(bool enable)
        {
            txtFullName.Enabled = enable;
            txtEmail.Enabled = enable;
            txtPassword.Enabled = enable;
            cmbRole.Enabled = enable;
            btnSave.Enabled = enable;
            btnClear.Enabled = enable;
        }

        private void ClearInputs()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            _editingUserId = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetInputState(true);
            txtFullName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                try
                {
                    var row = dgvUsers.SelectedRows[0];
                    int userId = (int)row.Cells["UserID"].Value;

                    using (var context = new LibraryContext())
                    {
                        var user = context.Users.Find(userId);
                        if (user != null)
                        {
                            _editingUserId = user.UserID;
                            txtFullName.Text = user.FullName;
                            txtEmail.Text = user.Email;
                            txtPassword.Text = user.Password;
                            cmbRole.SelectedItem = user.Role;

                            SetInputState(true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user row in the grid to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var row = dgvUsers.SelectedRows[0];
                int selectedUserId = (int)row.Cells["UserID"].Value;
                string fullName = row.Cells["FullName"].Value?.ToString();

                // Prevent self-deletion
                if (selectedUserId == Session.CurrentUserId)
                {
                    MessageBox.Show("Security Violation: You cannot delete your own active administrator account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show($"Are you sure you want to permanently delete user '{fullName}'? All their records will be erased.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (var context = new LibraryContext())
                        {
                            var user = context.Users.Find(selectedUserId);
                            if (user != null)
                            {
                                context.Users.Remove(user);
                                context.SaveChanges();
                                MessageBox.Show("User successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                ClearInputs();
                                SetInputState(false);
                                LoadUsers();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user row in the grid to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("All input fields are required to save a user account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new LibraryContext())
                {
                    // Email uniqueness check
                    var existingUser = context.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
                    if (existingUser != null && (_editingUserId == null || existingUser.UserID != _editingUserId))
                    {
                        MessageBox.Show("A user with this email address already exists in the system.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (_editingUserId != null)
                    {
                        // Editing mode
                        var user = context.Users.Find(_editingUserId.Value);
                        if (user != null)
                        {
                            // Prevent self-role modification away from Admin
                            if (user.UserID == Session.CurrentUserId && role != "Admin")
                            {
                                MessageBox.Show("Security Violation: You cannot revoke your own Administrator permissions.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            user.FullName = fullName;
                            user.Email = email;
                            user.Password = password;
                            user.Role = role;

                            context.SaveChanges();
                            MessageBox.Show("User details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Adding mode
                        var newUser = new User
                        {
                            FullName = fullName,
                            Email = email,
                            Password = password,
                            Role = role
                        };

                        context.Users.Add(newUser);
                        context.SaveChanges();
                        MessageBox.Show("New user account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClearInputs();
                    SetInputState(false);
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetInputState(false);
        }
    }
}
