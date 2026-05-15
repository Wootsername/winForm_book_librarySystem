namespace winForm_book_librarySystem
{
    partial class StudentDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnReserveBook;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.DataGridView dgvActiveReservations;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView dgvHistory;

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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnReserveBook = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.lblActive = new System.Windows.Forms.Label();
            this.dgvActiveReservations = new System.Windows.Forms.DataGridView();
            this.lblHistory = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "Student Dashboard";
            
            this.Activated += new System.EventHandler(this.StudentDashboard_Activated);

            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Text = "Welcome, Student!";

            this.btnReserveBook.Location = new System.Drawing.Point(630, 20);
            this.btnReserveBook.Size = new System.Drawing.Size(150, 30);
            this.btnReserveBook.Text = "Borrow a New Book";
            this.btnReserveBook.Click += new System.EventHandler(this.btnReserveBook_Click);

            this.btnNotifications.Location = new System.Drawing.Point(460, 20);
            this.btnNotifications.Size = new System.Drawing.Size(150, 30);
            this.btnNotifications.Text = "Notifications (0)";
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);

            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(20, 70);
            this.lblActive.Text = "Active Reservations:";

            this.dgvActiveReservations.Location = new System.Drawing.Point(20, 90);
            this.dgvActiveReservations.Size = new System.Drawing.Size(760, 200);
            this.dgvActiveReservations.ReadOnly = true;
            this.dgvActiveReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(20, 310);
            this.lblHistory.Text = "Borrowing History:";

            this.dgvHistory.Location = new System.Drawing.Point(20, 330);
            this.dgvHistory.Size = new System.Drawing.Size(760, 200);
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnReserveBook);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.dgvActiveReservations);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.dgvHistory);

            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
