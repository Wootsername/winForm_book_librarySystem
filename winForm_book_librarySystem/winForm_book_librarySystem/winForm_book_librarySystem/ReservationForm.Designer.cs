namespace winForm_book_librarySystem
{
    partial class ReservationForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReserve;

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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Reserve a Book";

            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            
            this.btnSearch.Location = new System.Drawing.Point(230, 18);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            
            this.btnRefresh.Location = new System.Drawing.Point(310, 18);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.dgvBooks.Location = new System.Drawing.Point(20, 50);
            this.dgvBooks.Size = new System.Drawing.Size(750, 340);
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.ReadOnly = true;

            this.btnReserve.Location = new System.Drawing.Point(20, 400);
            this.btnReserve.Size = new System.Drawing.Size(100, 30);
            this.btnReserve.Text = "Borrow Book";
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);

            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnReserve);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
