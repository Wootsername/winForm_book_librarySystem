namespace winForm_book_librarySystem
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Button btnLoadReport;
        private System.Windows.Forms.Button btnExportPDF;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

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
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.btnLoadReport = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Text = "Reports";

            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Items.AddRange(new object[] {
                "Books Availability",
                "All Reservations",
                "Student Borrowing History"
            });
            this.cmbReportType.Location = new System.Drawing.Point(20, 20);
            this.cmbReportType.Size = new System.Drawing.Size(200, 21);
            this.cmbReportType.SelectedIndex = 0;

            this.btnLoadReport.Location = new System.Drawing.Point(230, 18);
            this.btnLoadReport.Text = "Load Report";
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);

            this.btnExportPDF.Location = new System.Drawing.Point(320, 18);
            this.btnExportPDF.Text = "Export to PDF";
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);

            this.reportViewer1.Location = new System.Drawing.Point(20, 50);
            this.reportViewer1.Size = new System.Drawing.Size(850, 520);
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.btnLoadReport);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.reportViewer1);

            this.ResumeLayout(false);
        }
    }
}
