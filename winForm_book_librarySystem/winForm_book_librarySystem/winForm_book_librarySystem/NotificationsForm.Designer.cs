namespace winForm_book_librarySystem
{
    partial class NotificationsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvNotifications;

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
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Text = "Your Notifications";

            this.dgvNotifications.Location = new System.Drawing.Point(20, 20);
            this.dgvNotifications.Size = new System.Drawing.Size(560, 360);
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.Controls.Add(this.dgvNotifications);

            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
