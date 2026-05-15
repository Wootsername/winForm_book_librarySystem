using System;
using System.Linq;
using System.Windows.Forms;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class LibrarianDashboard : Form
    {
        public LibrarianDashboard()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    int totalBooks = context.Books.Sum(b => (int?)b.TotalCopies) ?? 0;
                    int activeReservations = context.Reservations.Count(r => r.Status == "Pending" || r.Status == "Approved");
                    
                    var thresholdDate = DateTime.Now.AddDays(-14);
                    int overdueCount = context.Reservations.Count(r => r.Status == "Approved" && r.ReservedDate < thresholdDate);

                    lblTotalBooks.Text = $"Total Books: {totalBooks}";
                    lblActiveReservations.Text = $"Active Reservations: {activeReservations}";
                    lblOverdueCount.Text = $"Overdue Count: {overdueCount}";

                    var recentDate = DateTime.Now.Date.AddDays(-7);
                    var recentTransactions = context.Reservations
                        .Where(r => r.ReservedDate >= recentDate)
                        .GroupBy(r => r.ReservedDate.Date)
                        .Select(g => new { Date = g.Key, Count = g.Count() })
                        .OrderBy(g => g.Date)
                        .ToList();

                    chartTransactions.Series["Transactions"].Points.Clear();
                    foreach (var trans in recentTransactions)
                    {
                        chartTransactions.Series["Transactions"].Points.AddXY(trans.Date.ToShortDateString(), trans.Count);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }

        private void LibrarianDashboard_Activated(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            using (var form = new BookManagementForm())
            {
                form.ShowDialog();
            }
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            using (var form = new ManageReservationsForm())
            {
                form.ShowDialog();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            using (var form = new ReportsForm())
            {
                form.ShowDialog();
            }
        }
    }
}
