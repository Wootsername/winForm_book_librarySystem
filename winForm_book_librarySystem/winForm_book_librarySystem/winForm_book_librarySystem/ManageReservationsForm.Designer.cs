namespace winForm_book_librarySystem
{
    partial class ManageReservationsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMarkReturned;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbFilter;

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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMarkReturned = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Text = "Manage Reservations";

            this.cmbFilter.Location = new System.Drawing.Point(20, 20);
            this.cmbFilter.Size = new System.Drawing.Size(150, 21);
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Items.AddRange(new object[] { "All", "Pending", "Approved", "Returned", "Cancelled" });
            this.cmbFilter.SelectedIndex = 1; // Default to Pending
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);

            this.btnRefresh.Location = new System.Drawing.Point(180, 18);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.dgvReservations.Location = new System.Drawing.Point(20, 50);
            this.dgvReservations.Size = new System.Drawing.Size(850, 380);
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.ReadOnly = true;

            this.btnApprove.Location = new System.Drawing.Point(20, 440);
            this.btnApprove.Text = "Approve";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);

            this.btnCancel.Location = new System.Drawing.Point(110, 440);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.btnMarkReturned.Location = new System.Drawing.Point(200, 440);
            this.btnMarkReturned.Text = "Mark Returned";
            this.btnMarkReturned.Width = 100;
            this.btnMarkReturned.Click += new System.EventHandler(this.btnMarkReturned_Click);

            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMarkReturned);

            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
