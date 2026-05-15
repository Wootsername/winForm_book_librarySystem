namespace winForm_book_librarySystem
{
    partial class BookManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblTotalCopies;
        private System.Windows.Forms.NumericUpDown numTotalCopies;
        private System.Windows.Forms.Label lblAvailableCopies;
        private System.Windows.Forms.NumericUpDown numAvailableCopies;
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblTotalCopies = new System.Windows.Forms.Label();
            this.numTotalCopies = new System.Windows.Forms.NumericUpDown();
            this.lblAvailableCopies = new System.Windows.Forms.Label();
            this.numAvailableCopies = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableCopies)).BeginInit();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Text = "Book Management";

            // Search
            this.txtSearch.Location = new System.Drawing.Point(300, 20);
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.btnSearch.Location = new System.Drawing.Point(510, 18);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnRefresh.Location = new System.Drawing.Point(590, 18);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // DataGridView
            this.dgvBooks.Location = new System.Drawing.Point(300, 50);
            this.dgvBooks.Size = new System.Drawing.Size(580, 380);
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.ReadOnly = true;

            // Buttons under DGV
            this.btnAdd.Location = new System.Drawing.Point(300, 440);
            this.btnAdd.Text = "Add New";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            
            this.btnEdit.Location = new System.Drawing.Point(390, 440);
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            
            this.btnDelete.Location = new System.Drawing.Point(480, 440);
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Input Fields (Left Side)
            int labelX = 20, inputX = 120, startY = 50, spacingY = 40;

            this.lblTitle.Location = new System.Drawing.Point(labelX, startY);
            this.lblTitle.Text = "Title:";
            this.txtTitle.Location = new System.Drawing.Point(inputX, startY);
            this.txtTitle.Size = new System.Drawing.Size(150, 20);

            this.lblAuthor.Location = new System.Drawing.Point(labelX, startY + spacingY);
            this.lblAuthor.Text = "Author:";
            this.txtAuthor.Location = new System.Drawing.Point(inputX, startY + spacingY);
            this.txtAuthor.Size = new System.Drawing.Size(150, 20);

            this.lblGenre.Location = new System.Drawing.Point(labelX, startY + 2 * spacingY);
            this.lblGenre.Text = "Genre:";
            this.txtGenre.Location = new System.Drawing.Point(inputX, startY + 2 * spacingY);
            this.txtGenre.Size = new System.Drawing.Size(150, 20);

            this.lblTotalCopies.Location = new System.Drawing.Point(labelX, startY + 3 * spacingY);
            this.lblTotalCopies.Text = "Total Copies:";
            this.numTotalCopies.Location = new System.Drawing.Point(inputX, startY + 3 * spacingY);
            this.numTotalCopies.Size = new System.Drawing.Size(150, 20);

            this.lblAvailableCopies.Location = new System.Drawing.Point(labelX, startY + 4 * spacingY);
            this.lblAvailableCopies.Text = "Available Copies:";
            this.numAvailableCopies.Location = new System.Drawing.Point(inputX, startY + 4 * spacingY);
            this.numAvailableCopies.Size = new System.Drawing.Size(150, 20);

            this.btnSave.Location = new System.Drawing.Point(120, startY + 5 * spacingY);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            
            this.btnClear.Location = new System.Drawing.Point(200, startY + 5 * spacingY);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Add Controls
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblTotalCopies);
            this.Controls.Add(this.numTotalCopies);
            this.Controls.Add(this.lblAvailableCopies);
            this.Controls.Add(this.numAvailableCopies);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
