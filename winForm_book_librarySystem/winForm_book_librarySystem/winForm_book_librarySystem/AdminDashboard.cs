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
            StyleComponents();
            LoadDashboardData();
            SetupEventHandlers();
        }

        private void StyleComponents()
        {
            // Sidebar styling
            ThemeSettings.StyleSidebar(panelSidebar);

            // Nav buttons styling
            ThemeSettings.StyleNavButton(btnNavDashboard, true);
            ThemeSettings.StyleNavButton(btnNavUsers, false);
            ThemeSettings.StyleNavButton(btnNavInventory, false);
            ThemeSettings.StyleNavButton(btnNavReservations, false);
            ThemeSettings.StyleNavButton(btnNavAnalytics, false);
            ThemeSettings.StyleNavButton(btnNavReports, false);
            ThemeSettings.StyleNavButton(btnNavSettings, false);

            // Circular avatar and initials
            ThemeSettings.MakeRoundedControl(pnlUserInitials, 18, null, 0);
            ThemeSettings.MakeRoundedControl(lblHeaderAvatar, 16, null, 0);



            // Buttons
            ThemeSettings.StyleButtonSolidGold(btnReports);

            // KPI Card panel stylings
            ThemeSettings.ApplyCardStyle(pnlKpiUsers);
            ThemeSettings.ApplyCardStyle(pnlKpiBooks);
            ThemeSettings.ApplyCardStyle(pnlKpiReservations);

            // Status Card and Action Card panel stylings
            ThemeSettings.ApplyCardStyle(pnlStatusCard);
            ThemeSettings.ApplyCardStyle(pnlActionCard);

            // Status rows rounding with custom border
            ThemeSettings.MakeRoundedControl(pnlStatusRow1, 8, ThemeSettings.BorderColor, 1);
            ThemeSettings.MakeRoundedControl(pnlStatusRow2, 8, ThemeSettings.BorderColor, 1);
            ThemeSettings.MakeRoundedControl(pnlStatusRow3, 8, ThemeSettings.BorderColor, 1);
            ThemeSettings.MakeRoundedControl(pnlStatusRow4, 8, ThemeSettings.BorderColor, 1);
        }

        private void SetupEventHandlers()
        {
            // Wire up event handlers
            btnReports.Click += btnReports_Click;
            btnNavReports.Click += btnReports_Click;
            this.Activated += AdminDashboard_Activated;



            // Wire up sidebar navigation routing
            btnNavDashboard.Click += (s, e) => LoadDashboardData();
            btnNavInventory.Click += (s, e) => {
                using (var form = new BookManagementForm())
                {
                    this.Hide();
                    form.ShowDialog(this);
                    this.Show();
                    LoadDashboardData();
                }
            };
            btnNavReservations.Click += (s, e) => {
                using (var form = new ManageReservationsForm())
                {
                    this.Hide();
                    form.ShowDialog(this);
                    this.Show();
                    LoadDashboardData();
                }
            };
            btnNavUsers.Click += (s, e) => {
                using (var form = new UserManagementForm())
                {
                    this.Hide();
                    form.ShowDialog(this);
                    this.Show();
                    LoadDashboardData();
                }
            };
            btnNavAnalytics.Click += (s, e) => LoadDashboardData();
            btnNavSettings.Click += (s, e) => {
                MessageBox.Show("System Settings are fully optimized.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
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
