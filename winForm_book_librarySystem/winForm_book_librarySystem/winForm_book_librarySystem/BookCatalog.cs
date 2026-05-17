using System;
using System.Linq;
using System.Windows.Forms;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class BookCatalog : Form
    {
        private string currentGenre = "All";
        private string currentStatusFilter = "All";
        private string searchText = "";
        private int? selectedBookId = null;

        public BookCatalog()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
            StyleComponents();
            SetupRoleSecurityAndNavigation();
        }

        public BookCatalog(string initialSearch) : this()
        {
            txtSearch.Text = initialSearch;
            searchText = initialSearch;
            LoadBooks();
        }

        private void StyleComponents()
        {
            // Sidebar buttons styling
            ThemeSettings.StyleNavButton(btnNavDashboard, false);
            ThemeSettings.StyleNavButton(btnNavCatalog, true);
            ThemeSettings.StyleNavButton(btnNavReservations, false);
            ThemeSettings.StyleNavButton(btnNavMembers, false);

            ThemeSettings.StyleNavButton(btnGenreAll, true);
            ThemeSettings.StyleNavButton(btnGenreProgramming, false);
            ThemeSettings.StyleNavButton(btnGenreDatabase, false);
            ThemeSettings.StyleNavButton(btnGenreNetworking, false);
            ThemeSettings.StyleNavButton(btnGenreMath, false);
            ThemeSettings.StyleNavButton(btnGenreAI, false);

            ThemeSettings.StyleNavButton(btnNavReports, false);
            ThemeSettings.StyleNavButton(btnNavNotifications, false);
            ThemeSettings.StyleNavButton(btnNavSettings, false);

            // Filter pills styling
            ThemeSettings.StyleButtonSolidGold(btnFilterAll);
            ThemeSettings.StyleButtonGoldOutline(btnFilterAvailable);
            ThemeSettings.StyleButtonGoldOutline(btnFilterTaken);
            ThemeSettings.StyleButtonGoldOutline(btnFilterLowStock);

            // Other buttons
            ThemeSettings.StyleButtonSolidGold(btnAddBook);
            ThemeSettings.StyleButtonSolidGold(btnReserve);
            ThemeSettings.StyleButtonSecondary(btnEdit);
            ThemeSettings.StyleButtonDanger(btnDelete);

            // TextBox styling
            ThemeSettings.StyleTextBox(txtSearch);
            
            // Rounding
            ThemeSettings.MakeRoundedControl(pnlDetailIcon, 8, null, 0);
        }

        private void AdjustSidebarLayout()
        {
            // Position top nav buttons dynamically
            int startY = 70;
            int spacing = 38;

            btnNavDashboard.Location = new System.Drawing.Point(0, startY);
            startY += spacing;

            btnNavCatalog.Location = new System.Drawing.Point(0, startY);
            startY += spacing;

            btnNavReservations.Location = new System.Drawing.Point(0, startY);
            startY += spacing;

            if (btnNavMembers.Visible)
            {
                btnNavMembers.Location = new System.Drawing.Point(0, startY);
                startY += spacing;
            }

            // Genre header
            startY += 8;
            lblSidebarGenre.Location = new System.Drawing.Point(14, startY);
            startY += 18;

            btnGenreAll.Location = new System.Drawing.Point(0, startY);
            startY += spacing;

            btnGenreProgramming.Location = new System.Drawing.Point(0, startY);
            startY += spacing;

            btnGenreDatabase.Location = new System.Drawing.Point(0, startY);
            startY += spacing;

            btnGenreNetworking.Location = new System.Drawing.Point(0, startY);
            startY += spacing;

            btnGenreMath.Location = new System.Drawing.Point(0, startY);
            startY += spacing;

            btnGenreAI.Location = new System.Drawing.Point(0, startY);

            // Position bottom footer buttons dynamically from y = 510
            int bottomY = 510;
            if (btnNavReports.Visible)
            {
                btnNavReports.Location = new System.Drawing.Point(0, bottomY);
                bottomY += 36;
            }

            btnNavNotifications.Location = new System.Drawing.Point(0, bottomY);
            bottomY += 36;

            btnNavSettings.Location = new System.Drawing.Point(0, bottomY);
        }

        private void SetupRoleSecurityAndNavigation()
        {
            // Dynamically show logged in user profile
            if (!string.IsNullOrEmpty(Session.CurrentUserName))
            {
                lblUserName.Text = Session.CurrentUserName;
                lblUserRole.Text = Session.CurrentUserRole;
            }

            // Role-based action access control
            if (Session.CurrentUserRole == "Student")
            {
                btnAddBook.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnReserve.Visible = true;
                btnNavReports.Visible = false; // Hide reports in the sidebar for student
                btnNavMembers.Visible = false; // Hide members in the sidebar for student
            }
            else
            {
                btnAddBook.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                btnReserve.Visible = false;
                btnNavReports.Visible = true; // Show reports in the sidebar for admin/librarian
                btnNavMembers.Visible = true; // Show members in the sidebar for admin/librarian
            }

            AdjustSidebarLayout();

            // Wire up event click handlers
            btnNavDashboard.Click += (s, e) => this.Close(); // Return to parent dashboard
            
            btnNavReservations.Click += (s, e) => {
                if (Session.CurrentUserRole == "Student")
                {
                    using (var form = new ReservationForm())
                    {
                        this.Hide();
                        form.ShowDialog(this);
                        this.Show();
                        LoadBooks();
                    }
                }
                else
                {
                    using (var form = new ManageReservationsForm())
                    {
                        this.Hide();
                        form.ShowDialog(this);
                        this.Show();
                        LoadBooks();
                    }
                }
            };

            btnNavReports.Click += (s, e) => {
                using (var form = new ReportsForm())
                {
                    this.Hide();
                    form.ShowDialog(this);
                    this.Show();
                    LoadBooks();
                }
            };

            btnNavNotifications.Click += (s, e) => {
                using (var form = new NotificationsForm())
                {
                    this.Hide();
                    form.ShowDialog(this);
                    this.Show();
                    LoadBooks();
                }
            };

            // Wire up sidebar genre switches
            btnGenreAll.Click += (s, e) => SwitchGenre("All", btnGenreAll);
            btnGenreProgramming.Click += (s, e) => SwitchGenre("Programming", btnGenreProgramming);
            btnGenreDatabase.Click += (s, e) => SwitchGenre("Database", btnGenreDatabase);
            btnGenreNetworking.Click += (s, e) => SwitchGenre("Networking", btnGenreNetworking);
            btnGenreMath.Click += (s, e) => SwitchGenre("Mathematics", btnGenreMath);
            btnGenreAI.Click += (s, e) => SwitchGenre("AI & ML", btnGenreAI);

            // Wire up top filter pills
            btnFilterAll.Click += (s, e) => SwitchStatusFilter("All", btnFilterAll);
            btnFilterAvailable.Click += (s, e) => SwitchStatusFilter("Available", btnFilterAvailable);
            btnFilterTaken.Click += (s, e) => SwitchStatusFilter("Taken", btnFilterTaken);
            btnFilterLowStock.Click += (s, e) => SwitchStatusFilter("Low Stock", btnFilterLowStock);

            // Wire up real-time search
            txtSearch.TextChanged += (s, e) => {
                searchText = txtSearch.Text;
                LoadBooks();
            };

            // Wire up action buttons
            btnReserve.Click += btnReserve_Click;
            
            btnAddBook.Click += (s, e) => {
                using (var form = new BookManagementForm())
                {
                    form.ShowDialog(this);
                    LoadBooks();
                }
            };
            btnEdit.Click += (s, e) => {
                using (var form = new BookManagementForm())
                {
                    form.ShowDialog(this);
                    LoadBooks();
                }
            };
            btnDelete.Click += btnDelete_Click;

            // Wire up Settings button
            btnNavSettings.Click += (s, e) => {
                using (var form = new SettingsForm())
                {
                    form.ShowDialog(this);
                    LoadBooks();
                }
            };

            // Load initial book list
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    var query = context.Books.AsQueryable();

                    // 1. Filter by Genre (from sidebar)
                    if (currentGenre != "All")
                    {
                        query = query.Where(b => b.Genre == currentGenre);
                    }

                    // 2. Filter by Search Text
                    if (!string.IsNullOrWhiteSpace(searchText))
                    {
                        query = query.Where(b => b.Title.Contains(searchText) || b.Author.Contains(searchText) || b.Genre.Contains(searchText));
                    }

                    // 3. Filter by Status Tab
                    if (currentStatusFilter == "Available")
                    {
                        query = query.Where(b => b.AvailableCopies > 0);
                    }
                    else if (currentStatusFilter == "Taken")
                    {
                        query = query.Where(b => b.AvailableCopies == 0);
                    }
                    else if (currentStatusFilter == "Low Stock")
                    {
                        query = query.Where(b => b.AvailableCopies > 0 && b.AvailableCopies <= 2);
                    }

                    var booksList = query.ToList();
                    lblResultCount.Text = $"Showing {booksList.Count} books";

                    PopulateBookCards(booksList);

                    // Auto-select first book if list has items and no book is selected
                    if (booksList.Count > 0)
                    {
                        if (!selectedBookId.HasValue || !booksList.Any(b => b.BookID == selectedBookId.Value))
                        {
                            SelectBook(booksList[0].BookID);
                        }
                        else
                        {
                            SelectBook(selectedBookId.Value);
                        }
                    }
                    else
                    {
                        selectedBookId = null;
                        lblDetailBookName.Text = "No Book Selected";
                        lblDetailAuthor.Text = "—";
                        lblDetailGenreVal.Text = "—";
                        lblDetailISBNVal.Text = "—";
                        lblDetailCopiesVal.Text = "—";
                        lblDetailAvailVal.Text = "—";
                        lblDetailStatusVal.Text = "—";
                        lblDetailStatusVal.BackColor = Color.Transparent;
                        lblDetailStatusVal.ForeColor = ThemeSettings.TextPrimary;
                        btnReserve.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateBookCards(System.Collections.Generic.List<winForm_book_librarySystem.Models.Book> books)
        {
            flowBooks.Controls.Clear();

            foreach (var book in books)
            {
                Panel card = new Panel();
                card.Width = 146;
                card.Height = 210;
                card.Cursor = Cursors.Hand;
                card.Tag = book.BookID;

                // Color palette based on genre/id to match premium mockup style
                Color cardBg = ThemeSettings.CardBg;
                Color iconBg = Color.FromArgb(240, 240, 245);
                Color textMuted = Color.FromArgb(120, 120, 140);
                string emoji = "📖";

                int type = book.BookID % 6;
                if (type == 0) { iconBg = Color.FromArgb(238, 230, 255); } // Purple
                else if (type == 1) { iconBg = Color.FromArgb(230, 250, 240); } // Green
                else if (type == 2) { iconBg = Color.FromArgb(255, 248, 220); } // Gold
                else if (type == 3) { iconBg = Color.FromArgb(255, 235, 235); } // Red
                else if (type == 4) { iconBg = Color.FromArgb(230, 245, 255); } // Blue
                else { iconBg = Color.FromArgb(255, 240, 245); } // Pink

                // Rounded Card Border
                bool isSelected = selectedBookId == book.BookID;
                Color borderCol = isSelected ? ThemeSettings.Gold : ThemeSettings.BorderColor;
                int borderThick = isSelected ? 2 : 1;

                card.BackColor = cardBg;

                // Top Icon Panel
                Panel iconPanel = new Panel();
                iconPanel.Size = new System.Drawing.Size(122, 72);
                iconPanel.Location = new System.Drawing.Point(12, 10);
                iconPanel.BackColor = iconBg;
                iconPanel.Enabled = false; // Clicks pass through to card panel

                Label lblEmoji = new Label();
                lblEmoji.Text = emoji;
                lblEmoji.Font = new Font("Segoe UI Emoji", 20F);
                lblEmoji.Dock = DockStyle.Fill;
                lblEmoji.TextAlign = ContentAlignment.MiddleCenter;
                iconPanel.Controls.Add(lblEmoji);
                card.Controls.Add(iconPanel);

                // Title
                Label lblTitle = new Label();
                lblTitle.Text = book.Title;
                lblTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                lblTitle.ForeColor = ThemeSettings.TextPrimary;
                lblTitle.Location = new System.Drawing.Point(12, 90);
                lblTitle.Size = new System.Drawing.Size(122, 34);
                lblTitle.Enabled = false;
                card.Controls.Add(lblTitle);

                // Author
                Label lblAuthor = new Label();
                lblAuthor.Text = book.Author;
                lblAuthor.Font = new Font("Segoe UI", 7.5F);
                lblAuthor.ForeColor = textMuted;
                lblAuthor.Location = new System.Drawing.Point(12, 126);
                lblAuthor.Size = new System.Drawing.Size(122, 16);
                lblAuthor.Enabled = false;
                card.Controls.Add(lblAuthor);

                // Status Badge
                Label lblBadge = new Label();
                string status = book.AvailableCopies > 0 ? "Available" : "Taken";
                if (book.AvailableCopies > 0 && book.AvailableCopies <= 2)
                {
                    status = "Low stock";
                }
                lblBadge.Text = status;
                lblBadge.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
                lblBadge.TextAlign = ContentAlignment.MiddleCenter;
                lblBadge.Location = new System.Drawing.Point(12, 150);
                lblBadge.Size = new System.Drawing.Size(58, 20);
                lblBadge.Enabled = false;

                if (status == "Available")
                {
                    lblBadge.BackColor = Color.FromArgb(230, 245, 233);
                    lblBadge.ForeColor = Color.FromArgb(46, 125, 50);
                }
                else if (status == "Low stock")
                {
                    lblBadge.BackColor = Color.FromArgb(255, 243, 224);
                    lblBadge.ForeColor = Color.FromArgb(239, 108, 0);
                }
                else
                {
                    lblBadge.BackColor = Color.FromArgb(255, 235, 235);
                    lblBadge.ForeColor = Color.FromArgb(198, 40, 40);
                }
                card.Controls.Add(lblBadge);

                // Copies Info
                Label lblCopies = new Label();
                lblCopies.Text = $"{book.AvailableCopies}/{book.TotalCopies}\ncopies";
                lblCopies.Font = new Font("Segoe UI", 7F);
                lblCopies.ForeColor = textMuted;
                lblCopies.Location = new System.Drawing.Point(74, 146);
                lblCopies.Size = new System.Drawing.Size(60, 24);
                lblCopies.TextAlign = ContentAlignment.MiddleRight;
                lblCopies.Enabled = false;
                card.Controls.Add(lblCopies);

                // Styling Rounded corners using ThemeSettings GDI+ painter
                ThemeSettings.MakeRoundedControl(card, 12, borderCol, borderThick);
                ThemeSettings.MakeRoundedControl(iconPanel, 8, null, 0);
                ThemeSettings.MakeRoundedControl(lblBadge, 6, null, 0);

                // Click event handles selection
                card.Click += (sender, e) => {
                    SelectBook(book.BookID);
                };

                flowBooks.Controls.Add(card);
            }
        }

        private void SelectBook(int bookId)
        {
            selectedBookId = bookId;

            // Re-draw card borders to highlight selected one
            foreach (Control ctrl in flowBooks.Controls)
            {
                if (ctrl is Panel card && card.Tag is int id)
                {
                    bool isSel = id == selectedBookId;
                    Color borderCol = isSel ? ThemeSettings.Gold : ThemeSettings.BorderColor;
                    int borderThick = isSel ? 2 : 1;
                    ThemeSettings.MakeRoundedControl(card, 12, borderCol, borderThick);
                }
            }

            // Sync selections to detail panel
            try
            {
                using (var context = new LibraryContext())
                {
                    var book = context.Books.Find(bookId);
                    if (book != null)
                    {
                        lblDetailBookName.Text = book.Title;
                        lblDetailAuthor.Text = book.Author;
                        lblDetailGenreVal.Text = book.Genre;
                        lblDetailISBNVal.Text = $"978-013468{book.BookID:D4}"; // mock ISBN
                        lblDetailCopiesVal.Text = book.TotalCopies.ToString();
                        lblDetailAvailVal.Text = $"{book.AvailableCopies} copies";
                        
                        string status = book.AvailableCopies > 0 ? "Available" : "Taken";
                        if (book.AvailableCopies > 0 && book.AvailableCopies <= 2)
                        {
                            status = "Low stock";
                        }
                        lblDetailStatusVal.Text = status;

                        if (status == "Available")
                        {
                            lblDetailStatusVal.BackColor = Color.FromArgb(230, 245, 233);
                            lblDetailStatusVal.ForeColor = Color.FromArgb(46, 125, 50);
                        }
                        else if (status == "Low stock")
                        {
                            lblDetailStatusVal.BackColor = Color.FromArgb(255, 243, 224);
                            lblDetailStatusVal.ForeColor = Color.FromArgb(239, 108, 0);
                        }
                        else
                        {
                            lblDetailStatusVal.BackColor = Color.FromArgb(255, 235, 235);
                            lblDetailStatusVal.ForeColor = Color.FromArgb(198, 40, 40);
                        }
                        ThemeSettings.MakeRoundedControl(lblDetailStatusVal, 6, null, 0);

                        // Icon detail color sync
                        int type = book.BookID % 6;
                        Color iconBg = Color.FromArgb(230, 245, 233);
                        if (type == 0) iconBg = Color.FromArgb(238, 230, 255);
                        else if (type == 1) iconBg = Color.FromArgb(230, 250, 240);
                        else if (type == 2) iconBg = Color.FromArgb(255, 248, 220);
                        else if (type == 3) iconBg = Color.FromArgb(255, 235, 235);
                        else if (type == 4) iconBg = Color.FromArgb(230, 245, 255);
                        else iconBg = Color.FromArgb(255, 240, 245);

                        pnlDetailIcon.BackColor = iconBg;
                        ThemeSettings.MakeRoundedControl(pnlDetailIcon, 8, null, 0);

                        if (Session.CurrentUserRole == "Student")
                        {
                            btnReserve.Enabled = book.AvailableCopies > 0;
                        }
                    }
                }
            }
            catch { }
        }

        private void SwitchGenre(string genre, Button activeBtn)
        {
            currentGenre = genre;
            LoadBooks();

            // Highlight active sidebar navigation tab
            Button[] genreButtons = { btnGenreAll, btnGenreProgramming, btnGenreDatabase, btnGenreNetworking, btnGenreMath, btnGenreAI };
            foreach (var btn in genreButtons)
            {
                ThemeSettings.StyleNavButton(btn, btn == activeBtn);
            }
        }

        private void SwitchStatusFilter(string status, Button activeBtn)
        {
            currentStatusFilter = status;
            LoadBooks();

            // Highlight active top filter pill
            Button[] filterButtons = { btnFilterAll, btnFilterAvailable, btnFilterTaken, btnFilterLowStock };
            foreach (var btn in filterButtons)
            {
                if (btn == activeBtn)
                {
                    ThemeSettings.StyleButtonSolidGold(btn);
                }
                else
                {
                    ThemeSettings.StyleButtonGoldOutline(btn);
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (selectedBookId.HasValue)
            {
                try
                {
                    using (var context = new LibraryContext())
                    {
                        var book = context.Books.Find(selectedBookId.Value);
                        if (book != null && book.AvailableCopies > 0)
                        {
                            var reservation = new Reservation
                            {
                                UserID = Session.CurrentUserId,
                                BookID = book.BookID,
                                ReservedDate = DateTime.Now,
                                Status = "Pending"
                            };

                            book.AvailableCopies -= 1;
                            context.Reservations.Add(reservation);
                            context.SaveChanges();

                            MessageBox.Show("Book reserved successfully! Status: Pending Librarian Approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooks();
                        }
                        else
                        {
                            MessageBox.Show("This book is currently out of stock and cannot be reserved.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error making reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBookId.HasValue)
            {
                if (MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (var context = new LibraryContext())
                        {
                            var book = context.Books.Find(selectedBookId.Value);
                            if (book != null)
                            {
                                context.Books.Remove(book);
                                context.SaveChanges();
                                MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadBooks();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
