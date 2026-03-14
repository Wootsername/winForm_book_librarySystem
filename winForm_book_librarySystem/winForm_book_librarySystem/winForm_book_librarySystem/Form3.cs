using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace winForm_book_librarySystem
{
    public partial class Form3 : Form
    {
        private readonly BindingList<Book> _books = new BindingList<Book>();
        private readonly BindingSource _binding = new BindingSource();

        public Form3()
        {
            InitializeComponent();
            _binding.DataSource = _books;
            gridBooks.AutoGenerateColumns = true;
            gridBooks.DataSource = _binding;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearInputs();
            txtBookID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text)) { MessageBox.Show("Book ID is required."); return; }
            if (_books.Any(b => string.Equals(b.BookId, txtBookID.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Book ID already exists."); return;
            }

            _books.Add(new Book
            {
                BookId = txtBookID.Text.Trim(),
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim()
            });
            ClearInputs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = SelectedBook();
            if (selected == null) return;

            txtBookID.Text = selected.BookId;
            txtTitle.Text = selected.Title;
            txtAuthor.Text = selected.Author;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selected = SelectedBook();
            if (selected == null) return;

            selected.Title = txtTitle.Text.Trim();
            selected.Author = txtAuthor.Text.Trim();
            gridBooks.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = SelectedBook();
            if (selected == null) return;

            _books.Remove(selected);
            ClearInputs();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                _binding.DataSource = _books;
            }
            else
            {
                var term = txtSearch.Text.Trim().ToLowerInvariant();
                _binding.DataSource = _books.Where(b =>
                    b.BookId.ToLowerInvariant().Contains(term) ||
                    b.Title.ToLowerInvariant().Contains(term) ||
                    b.Author.ToLowerInvariant().Contains(term)).ToList();
            }

            gridBooks.DataSource = _binding;
        }

        private Book SelectedBook()
        {
            return gridBooks.CurrentRow?.DataBoundItem as Book;
        }

        private void ClearInputs()
        {
            txtBookID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
        }

        private class Book
        {
            public string BookId { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
        }
    }
}