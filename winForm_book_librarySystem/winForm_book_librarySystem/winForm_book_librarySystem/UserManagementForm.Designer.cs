namespace winForm_book_librarySystem
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();

            // Form Settings
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Text = "User Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // Search Box and Refresh
            this.txtSearch.Location = new System.Drawing.Point(320, 20);
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.PlaceholderText = "🔍 Search users by name or email...";
            
            this.btnSearch.Location = new System.Drawing.Point(530, 18);
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnRefresh.Location = new System.Drawing.Point(615, 18);
            this.btnRefresh.Size = new System.Drawing.Size(75, 27);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // Users DataGridView
            this.dgvUsers.Location = new System.Drawing.Point(320, 60);
            this.dgvUsers.Size = new System.Drawing.Size(550, 360);
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.ReadOnly = true;

            // CRUD action buttons
            this.btnAdd.Location = new System.Drawing.Point(320, 435);
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.Text = "➕ Add User";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Location = new System.Drawing.Point(420, 435);
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.Text = "✏️ Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Location = new System.Drawing.Point(520, 435);
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.Text = "❌ Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Input Fields Left panel setup
            int labelX = 20, inputX = 120, startY = 60, spacingY = 50;

            // Full Name input
            this.lblFullName.Location = new System.Drawing.Point(labelX, startY);
            this.lblFullName.Size = new System.Drawing.Size(90, 20);
            this.lblFullName.Text = "Full Name:";
            this.txtFullName.Location = new System.Drawing.Point(inputX, startY);
            this.txtFullName.Size = new System.Drawing.Size(180, 23);

            // Email input
            this.lblEmail.Location = new System.Drawing.Point(labelX, startY + spacingY);
            this.lblEmail.Size = new System.Drawing.Size(90, 20);
            this.lblEmail.Text = "Email Address:";
            this.txtEmail.Location = new System.Drawing.Point(inputX, startY + spacingY);
            this.txtEmail.Size = new System.Drawing.Size(180, 23);

            // Password input
            this.lblPassword.Location = new System.Drawing.Point(labelX, startY + 2 * spacingY);
            this.lblPassword.Size = new System.Drawing.Size(90, 20);
            this.lblPassword.Text = "Password:";
            this.txtPassword.Location = new System.Drawing.Point(inputX, startY + 2 * spacingY);
            this.txtPassword.Size = new System.Drawing.Size(180, 23);
            this.txtPassword.UseSystemPasswordChar = true;

            // Role selection ComboBox
            this.lblRole.Location = new System.Drawing.Point(labelX, startY + 3 * spacingY);
            this.lblRole.Size = new System.Drawing.Size(90, 20);
            this.lblRole.Text = "System Role:";
            this.cmbRole.Location = new System.Drawing.Point(inputX, startY + 3 * spacingY);
            this.cmbRole.Size = new System.Drawing.Size(180, 25);
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "Student", "Librarian", "Admin" });

            // Action save & clear buttons
            this.btnSave.Location = new System.Drawing.Point(120, startY + 4 * spacingY);
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnClear.Location = new System.Drawing.Point(210, startY + 4 * spacingY);
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Add all controls to Form
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
