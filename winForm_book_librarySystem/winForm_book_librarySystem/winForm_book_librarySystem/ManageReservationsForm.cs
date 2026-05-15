using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class ManageReservationsForm : Form
    {
        public ManageReservationsForm()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
            LoadReservations();
        }

        private void LoadReservations()
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    string filter = cmbFilter.SelectedItem?.ToString() ?? "All";
                    var query = context.Reservations
                        .Include(r => r.User)
                        .Include(r => r.Book)
                        .AsQueryable();

                    if (filter != "All")
                    {
                        query = query.Where(r => r.Status == filter);
                    }

                    dgvReservations.DataSource = query.Select(r => new {
                        r.ReservationID,
                        StudentName = r.User.FullName,
                        BookTitle = r.Book.Title,
                        r.ReservedDate,
                        r.Status,
                        r.BookID
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message);
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void UpdateReservationStatus(string newStatus)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                int reservationId = (int)dgvReservations.SelectedRows[0].Cells["ReservationID"].Value;
                string currentStatus = dgvReservations.SelectedRows[0].Cells["Status"].Value.ToString();
                int bookId = (int)dgvReservations.SelectedRows[0].Cells["BookID"].Value;

                try
                {
                    using (var context = new LibraryContext())
                    {
                        var reservation = context.Reservations.Find(reservationId);
                        if (reservation != null)
                        {
                            if (newStatus == "Approved" && currentStatus != "Pending")
                            {
                                MessageBox.Show("Only Pending reservations can be Approved.");
                                return;
                            }
                            if (newStatus == "Returned" && currentStatus != "Approved")
                            {
                                MessageBox.Show("Only Approved reservations can be marked as Returned.");
                                return;
                            }
                            if (newStatus == "Cancelled" && (currentStatus == "Returned" || currentStatus == "Cancelled"))
                            {
                                MessageBox.Show("Cannot cancel a Returned or already Cancelled reservation.");
                                return;
                            }

                            reservation.Status = newStatus;

                            var book = context.Books.Find(bookId);
                            if (book != null)
                            {
                                if (newStatus == "Returned" || (newStatus == "Cancelled" && currentStatus == "Pending"))
                                {
                                    book.AvailableCopies += 1;
                                }

                                if (newStatus == "Approved" || newStatus == "Cancelled")
                                {
                                    var notification = new Notification
                                    {
                                        UserID = reservation.UserID,
                                        Message = $"Your reservation for the book '{book.Title}' has been {newStatus.ToLower()}.",
                                        DateSent = DateTime.Now,
                                        IsRead = false
                                    };
                                    context.Notifications.Add(notification);
                                }
                            }

                            context.SaveChanges();
                            MessageBox.Show($"Reservation marked as {newStatus}.");
                            LoadReservations();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating reservation: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation.");
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateReservationStatus("Approved");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateReservationStatus("Cancelled");
        }

        private void btnMarkReturned_Click(object sender, EventArgs e)
        {
            UpdateReservationStatus("Returned");
        }
    }
}
