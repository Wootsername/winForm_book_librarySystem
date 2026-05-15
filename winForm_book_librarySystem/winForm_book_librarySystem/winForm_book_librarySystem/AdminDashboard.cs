using System;
using System.Linq;
using System.Windows.Forms;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
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
                    int totalUsers = context.Users.Count();
                    int totalBooks = context.Books.Sum(b => (int?)b.TotalCopies) ?? 0;
                    int totalReservations = context.Reservations.Count();

                    int pending = context.Reservations.Count(r => r.Status == "Pending");
                    int approved = context.Reservations.Count(r => r.Status == "Approved");
                    int returned = context.Reservations.Count(r => r.Status == "Returned");
                    int cancelled = context.Reservations.Count(r => r.Status == "Cancelled");

                    lblTotalUsers.Text = $"Total Users: {totalUsers}";
                    lblTotalBooks.Text = $"Total Books: {totalBooks}";
                    lblTotalReservations.Text = $"Total Reservations: {totalReservations}";

                    lblPending.Text = $"Pending: {pending}";
                    lblApproved.Text = $"Approved: {approved}";
                    lblReturned.Text = $"Returned: {returned}";
                    lblCancelled.Text = $"Cancelled: {cancelled}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }

        private void AdminDashboard_Activated(object sender, EventArgs e)
        {
            LoadDashboardData();
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
