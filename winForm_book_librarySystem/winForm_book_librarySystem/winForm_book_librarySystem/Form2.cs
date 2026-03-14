using System;
using System.Windows.Forms;

namespace winForm_book_librarySystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new Form3())
            {
                frm.ShowDialog(this);
            }
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new Form4())
            {
                frm.ShowDialog(this);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}