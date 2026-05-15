using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
            lblWelcome.Text = $"Welcome, {Session.CurrentUserName}!";
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    int userId = Session.CurrentUserId;

                    var activeReservations = context.Reservations
                        .Include(r => r.Book)
                        .Where(r => r.UserID == userId && (r.Status == "Pending" || r.Status == "Approved"))
                        .Select(r => new { r.ReservationID, BookTitle = r.Book.Title, r.ReservedDate, r.Status })
                        .ToList();

                    var historyReservations = context.Reservations
                        .Include(r => r.Book)
                        .Where(r => r.UserID == userId && (r.Status == "Returned" || r.Status == "Cancelled"))
                        .Select(r => new { r.ReservationID, BookTitle = r.Book.Title, r.ReservedDate, r.Status })
                        .ToList();

                    int unreadCount = context.Notifications.Count(n => n.UserID == userId && !n.IsRead);
                    btnNotifications.Text = $"Notifications ({unreadCount})";

                    dgvActiveReservations.DataSource = activeReservations;
                    dgvHistory.DataSource = historyReservations;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }

        private void StudentDashboard_Activated(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void btnReserveBook_Click(object sender, EventArgs e)
        {
            using (var form = new ReservationForm())
            {
                form.ShowDialog();
            }
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            using (var form = new NotificationsForm())
            {
                form.ShowDialog();
            }
            LoadDashboardData();
        }
    }
}
