namespace winForm_book_librarySystem
{
    partial class LibrarianDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblActiveReservations;
        private System.Windows.Forms.Label lblOverdueCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTransactions;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnManageReservations;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblActiveReservations = new System.Windows.Forms.Label();
            this.lblOverdueCount = new System.Windows.Forms.Label();
            this.chartTransactions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnManageReservations = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.chartTransactions)).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "Librarian Dashboard";
            this.Activated += new System.EventHandler(this.LibrarianDashboard_Activated);

            this.btnManageBooks.Location = new System.Drawing.Point(20, 20);
            this.btnManageBooks.Size = new System.Drawing.Size(150, 40);
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);

            this.btnManageReservations.Location = new System.Drawing.Point(180, 20);
            this.btnManageReservations.Size = new System.Drawing.Size(150, 40);
            this.btnManageReservations.Text = "Manage Reservations";
            this.btnManageReservations.Click += new System.EventHandler(this.btnManageReservations_Click);

            this.btnReports.Location = new System.Drawing.Point(340, 20);
            this.btnReports.Size = new System.Drawing.Size(150, 40);
            this.btnReports.Text = "View Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            this.lblTotalBooks.Location = new System.Drawing.Point(20, 80);
            this.lblTotalBooks.Text = "Total Books: 0";

            this.lblActiveReservations.AutoSize = true;
            this.lblActiveReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            this.lblActiveReservations.Location = new System.Drawing.Point(20, 110);
            this.lblActiveReservations.Text = "Active Reservations: 0";

            this.lblOverdueCount.AutoSize = true;
            this.lblOverdueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            this.lblOverdueCount.Location = new System.Drawing.Point(20, 140);
            this.lblOverdueCount.Text = "Overdue Count: 0";

            chartArea1.Name = "ChartArea1";
            this.chartTransactions.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTransactions.Legends.Add(legend1);
            this.chartTransactions.Location = new System.Drawing.Point(20, 180);
            this.chartTransactions.Name = "chartTransactions";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Transactions";
            this.chartTransactions.Series.Add(series1);
            this.chartTransactions.Size = new System.Drawing.Size(750, 380);

            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.btnManageReservations);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.lblTotalBooks);
            this.Controls.Add(this.lblActiveReservations);
            this.Controls.Add(this.lblOverdueCount);
            this.Controls.Add(this.chartTransactions);

            ((System.ComponentModel.ISupportInitialize)(this.chartTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnReports;
    }
}
