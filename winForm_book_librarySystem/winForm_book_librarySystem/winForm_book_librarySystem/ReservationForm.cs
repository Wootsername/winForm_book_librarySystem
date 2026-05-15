using System;
using System.Linq;
using System.Windows.Forms;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
            LoadAvailableBooks();
        }

        private void LoadAvailableBooks(string searchQuery = "")
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    // Only show books with available copies
                    var query = context.Books.Where(b => b.AvailableCopies > 0);
                    
                    if (!string.IsNullOrWhiteSpace(searchQuery))
                    {
                        query = query.Where(b => b.Title.Contains(searchQuery) || b.Author.Contains(searchQuery));
                    }

                    dgvBooks.DataSource = query.Select(b => new {
                        b.BookID,
                        b.Title,
                        b.Author,
                        b.Genre,
                        b.AvailableCopies
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAvailableBooks(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadAvailableBooks();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookID"].Value;

                try
                {
                    using (var context = new LibraryContext())
                    {
                        var book = context.Books.Find(bookId);
                        if (book != null && book.AvailableCopies > 0)
                        {
                            var reservation = new Reservation
                            {
                                UserID = Session.CurrentUserId,
                                BookID = bookId,
                                ReservedDate = DateTime.Now,
                                Status = "Pending"
                            };

                            book.AvailableCopies -= 1;

                            context.Reservations.Add(reservation);
                            context.SaveChanges();

                            MessageBox.Show("Borrow request submitted successfully! Status: Pending Librarian Approval.");
                            LoadAvailableBooks();
                        }
                        else
                        {
                            MessageBox.Show("This book is no longer available.");
                            LoadAvailableBooks();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reserving book: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to reserve.");
            }
        }
    }
}
