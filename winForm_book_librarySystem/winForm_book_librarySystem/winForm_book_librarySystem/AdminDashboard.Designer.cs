namespace winForm_book_librarySystem
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblTotalReservations;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblApproved;
        private System.Windows.Forms.Label lblReturned;
        private System.Windows.Forms.Label lblCancelled;
        private System.Windows.Forms.Button btnReports;

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
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblTotalReservations = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblApproved = new System.Windows.Forms.Label();
            this.lblReturned = new System.Windows.Forms.Label();
            this.lblCancelled = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Text = "Admin Dashboard";
            this.Activated += new System.EventHandler(this.AdminDashboard_Activated);

            this.btnReports.Location = new System.Drawing.Point(400, 30);
            this.btnReports.Size = new System.Drawing.Size(150, 40);
            this.btnReports.Text = "View Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsers.Location = new System.Drawing.Point(30, 30);
            this.lblTotalUsers.Text = "Total Users: 0";

            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooks.Location = new System.Drawing.Point(30, 70);
            this.lblTotalBooks.Text = "Total Books: 0";

            this.lblTotalReservations.AutoSize = true;
            this.lblTotalReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalReservations.Location = new System.Drawing.Point(30, 110);
            this.lblTotalReservations.Text = "Total Reservations: 0";

            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            this.lblPending.Location = new System.Drawing.Point(50, 150);
            this.lblPending.Text = "Pending: 0";

            this.lblApproved.AutoSize = true;
            this.lblApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            this.lblApproved.Location = new System.Drawing.Point(50, 180);
            this.lblApproved.Text = "Approved: 0";

            this.lblReturned.AutoSize = true;
            this.lblReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            this.lblReturned.Location = new System.Drawing.Point(50, 210);
            this.lblReturned.Text = "Returned: 0";

            this.lblCancelled.AutoSize = true;
            this.lblCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            this.lblCancelled.Location = new System.Drawing.Point(50, 240);
            this.lblCancelled.Text = "Cancelled: 0";

            this.Controls.Add(this.lblTotalUsers);
            this.Controls.Add(this.lblTotalBooks);
            this.Controls.Add(this.lblTotalReservations);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblApproved);
            this.Controls.Add(this.lblReturned);
            this.Controls.Add(this.lblCancelled);
            this.Controls.Add(this.btnReports);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
