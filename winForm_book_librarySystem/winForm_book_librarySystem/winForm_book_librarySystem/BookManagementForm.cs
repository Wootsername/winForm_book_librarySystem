using System;
using System.Linq;
using System.Windows.Forms;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class BookManagementForm : Form
    {
        private int? _editingBookId = null;

        public BookManagementForm()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
            LoadBooks();
            SetInputState(false);
        }

        private void LoadBooks(string searchQuery = "")
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    var query = context.Books.AsQueryable();
                    
                    if (!string.IsNullOrWhiteSpace(searchQuery))
                    {
                        query = query.Where(b => b.Title.Contains(searchQuery) || b.Author.Contains(searchQuery));
                    }

                    dgvBooks.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void SetInputState(bool enable)
        {
            txtTitle.Enabled = enable;
            txtAuthor.Enabled = enable;
            txtGenre.Enabled = enable;
            numTotalCopies.Enabled = enable;
            numAvailableCopies.Enabled = enable;
            btnSave.Enabled = enable;
            btnClear.Enabled = enable;
        }

        private void ClearInputs()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtGenre.Clear();
            numTotalCopies.Value = 0;
            numAvailableCopies.Value = 0;
            _editingBookId = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadBooks(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadBooks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetInputState(true);
            txtTitle.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                var row = dgvBooks.SelectedRows[0];
                _editingBookId = (int)row.Cells["BookID"].Value;
                txtTitle.Text = row.Cells["Title"].Value?.ToString();
                txtAuthor.Text = row.Cells["Author"].Value?.ToString();
                txtGenre.Text = row.Cells["Genre"].Value?.ToString();
                numTotalCopies.Value = Convert.ToDecimal(row.Cells["TotalCopies"].Value);
                numAvailableCopies.Value = Convert.ToDecimal(row.Cells["AvailableCopies"].Value);
                
                SetInputState(true);
            }
            else
            {
                MessageBox.Show("Please select a book to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookID"].Value;
                        using (var context = new LibraryContext())
                        {
                            var book = context.Books.Find(bookId);
                            if (book != null)
                            {
                                context.Books.Remove(book);
                                context.SaveChanges();
                                LoadBooks();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting book: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                MessageBox.Show("Please fill all required fields (Title, Author, Genre).");
                return;
            }

            try
            {
                using (var context = new LibraryContext())
                {
                    if (_editingBookId.HasValue)
                    {
                        // Update
                        var book = context.Books.Find(_editingBookId.Value);
                        if (book != null)
                        {
                            book.Title = txtTitle.Text;
                            book.Author = txtAuthor.Text;
                            book.Genre = txtGenre.Text;
                            book.TotalCopies = (int)numTotalCopies.Value;
                            book.AvailableCopies = (int)numAvailableCopies.Value;
                        }
                    }
                    else
                    {
                        // Add
                        var book = new Book
                        {
                            Title = txtTitle.Text,
                            Author = txtAuthor.Text,
                            Genre = txtGenre.Text,
                            TotalCopies = (int)numTotalCopies.Value,
                            AvailableCopies = (int)numAvailableCopies.Value
                        };
                        context.Books.Add(book);
                    }
                    context.SaveChanges();
                }

                ClearInputs();
                SetInputState(false);
                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving book: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetInputState(false);
        }
    }
}
