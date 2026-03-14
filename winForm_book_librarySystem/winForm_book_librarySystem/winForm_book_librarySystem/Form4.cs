using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace winForm_book_librarySystem
{
    public partial class Form4 : Form
    {
        private readonly BindingList<Borrower> _borrowers = new BindingList<Borrower>();
        private readonly BindingSource _binding = new BindingSource();

        public Form4()
        {
            InitializeComponent();
            _binding.DataSource = _borrowers;
            gridBorrowers.AutoGenerateColumns = true;
            gridBorrowers.DataSource = _binding;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearInputs();
            txtBorrowerId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBorrowerId.Text)) { MessageBox.Show("Borrower ID is required."); return; }
            if (_borrowers.Any(b => string.Equals(b.BorrowerId, txtBorrowerId.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Borrower ID already exists."); return;
            }

            _borrowers.Add(new Borrower
            {
                BorrowerId = txtBorrowerId.Text.Trim(),
                Name = txtName.Text.Trim(),
                Contact = txtContact.Text.Trim()
            });
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = gridBorrowers.CurrentRow?.DataBoundItem as Borrower;
            if (selected == null) return;
            _borrowers.Remove(selected);
            ClearInputs();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                _binding.DataSource = _borrowers;
            }
            else
            {
                var term = txtSearch.Text.Trim().ToLowerInvariant();
                _binding.DataSource = _borrowers.Where(b =>
                    b.BorrowerId.ToLowerInvariant().Contains(term) ||
                    b.Name.ToLowerInvariant().Contains(term) ||
                    b.Contact.ToLowerInvariant().Contains(term)).ToList();
            }

            gridBorrowers.DataSource = _binding;
        }

        private void ClearInputs()
        {
            txtBorrowerId.Clear();
            txtName.Clear();
            txtContact.Clear();
        }

        private class Borrower
        {
            public string BorrowerId { get; set; }
            public string Name { get; set; }
            public string Contact { get; set; }
        }
    }
}