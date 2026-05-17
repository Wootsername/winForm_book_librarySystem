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
            StyleComponents();
            UpdateUserProfileDisplay();
            LoadDashboardData();

            // Wire up event handlers
            btnReserveBook.Click += btnReserveBook_Click;
            btnNotifications.Click += btnNotifications_Click;
            this.Activated += StudentDashboard_Activated;

            // Wire up header search bar to launch Book Catalog with search prefilled
            txtHeaderSearch.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true; // Prevent beep sound
                    string query = txtHeaderSearch.Text.Trim();
                    if (!string.IsNullOrEmpty(query))
                    {
                        txtHeaderSearch.Text = ""; // Clear for next time
                        using (var form = new BookCatalog(query))
                        {
                            this.Hide();
                            form.ShowDialog(this);
                            this.Show();
                            UpdateUserProfileDisplay();
                            LoadDashboardData();
                        }
                    }
                }
            };

            // Wire up sidebar navigation routing
            btnNavDashboard.Click += (s, e) => ShowNormalDashboardLayout();
            btnNavBrowse.Click += (s, e) => {
                using (var form = new BookCatalog())
                {
                    this.Hide();
                    form.ShowDialog(this);
                    this.Show();
                    UpdateUserProfileDisplay();
                    LoadDashboardData();
                }
            };
            btnNavReservations.Click += (s, e) => {
                using (var form = new ReservationForm())
                {
                    this.Hide();
                    form.ShowDialog(this);
                    this.Show();
                    UpdateUserProfileDisplay();
                    LoadDashboardData();
                }
            };
            btnNavHistory.Click += (s, e) => ShowHistoryDashboardLayout();
            btnNavProfile.Click += (s, e) => {
                using (var form = new SettingsForm())
                {
                    form.ShowDialog(this);
                    UpdateUserProfileDisplay();
                }
            };
        }

        private void StyleComponents()
        {
            // Sidebar styling
            ThemeSettings.StyleSidebar(panelSidebar);

            // Nav buttons styling
            ThemeSettings.StyleNavButton(btnNavDashboard, true);
            ThemeSettings.StyleNavButton(btnNavBrowse, false);
            ThemeSettings.StyleNavButton(btnNavReservations, false);
            ThemeSettings.StyleNavButton(btnNavHistory, false);
            ThemeSettings.StyleNavButton(btnNavProfile, false);

            // Circular avatar and initials
            ThemeSettings.MakeRoundedControl(pnlUserInitials, 18, null, 0);
            ThemeSettings.MakeRoundedControl(lblHeaderAvatar, 16, null, 0);

            // TextBoxes
            ThemeSettings.StyleTextBox(txtHeaderSearch);

            // Buttons
            ThemeSettings.StyleButtonSecondary(btnNotifications);
            ThemeSettings.StyleButtonGoldOutline(btnReserveBook);

            // Card panel stylings
            ThemeSettings.ApplyCardStyle(pnlKpiBorrowed);
            ThemeSettings.ApplyCardStyle(pnlKpiActive);
            ThemeSettings.ApplyCardStyle(pnlKpiReturned);
            ThemeSettings.ApplyCardStyle(pnlLeftCard);
            ThemeSettings.ApplyCardStyle(pnlRightCard);

            // GridViews
            ThemeSettings.StyleGridView(dgvHistory);
            ThemeSettings.StyleGridView(dgvActiveReservations);
        }

        private void UpdateUserProfileDisplay()
        {
            string userName = Session.CurrentUserName;
            if (string.IsNullOrEmpty(userName))
            {
                userName = "Student";
            }

            lblWelcome.Text = $"Welcome, {userName}!";
            lblUserName.Text = userName;

            // Generate initials
            string initials = "";
            var parts = userName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 0)
            {
                initials += parts[0][0].ToString().ToUpper();
                if (parts.Length > 1)
                {
                    initials += parts[parts.Length - 1][0].ToString().ToUpper();
                }
            }
            if (string.IsNullOrEmpty(initials))
            {
                initials = "ST";
            }

            lblUserInitials.Text = initials;
            lblHeaderAvatar.Text = initials;
        }

        private void ShowNormalDashboardLayout()
        {
            ThemeSettings.StyleNavButton(btnNavDashboard, true);
            ThemeSettings.StyleNavButton(btnNavHistory, false);

            pnlRightCard.Visible = true;
            pnlLeftCard.Width = 365;
            dgvHistory.Width = 333;
            lblLeftCardTitle.Text = "Borrow History";
            btnReserveBook.Visible = true;

            LoadDashboardData();
        }

        private void ShowHistoryDashboardLayout()
        {
            ThemeSettings.StyleNavButton(btnNavDashboard, false);
            ThemeSettings.StyleNavButton(btnNavHistory, true);

            pnlRightCard.Visible = false;
            pnlLeftCard.Width = 756;
            dgvHistory.Width = 724;
            lblLeftCardTitle.Text = "Your Complete Borrowing History";
            btnReserveBook.Visible = false;

            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    int userId = Session.CurrentUserId;

                    // 1. Fetch KPI Statistics from the database
                    int approvedCount = context.Reservations.Count(r => r.UserID == userId && r.Status == "Approved");
                    int pendingCount = context.Reservations.Count(r => r.UserID == userId && r.Status == "Pending");
                    int allTimeCount = context.Reservations.Count(r => r.UserID == userId);

                    lblKpiBorrowedNum.Text = approvedCount.ToString();
                    lblKpiBorrowedSub.Text = approvedCount == 1 ? "✓ 1 active borrowing" : $"✓ {approvedCount} active borrowings";

                    lblKpiActiveNum.Text = pendingCount.ToString();
                    lblKpiActiveSub.Text = pendingCount == 1 ? "⌛ 1 pending approval" : $"⌛ {pendingCount} pending approvals";

                    lblKpiReturnedNum.Text = allTimeCount.ToString();
                    lblKpiReturnedSub.Text = "All time total";

                    // 2. Fetch Grid lists
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
            UpdateUserProfileDisplay();
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
