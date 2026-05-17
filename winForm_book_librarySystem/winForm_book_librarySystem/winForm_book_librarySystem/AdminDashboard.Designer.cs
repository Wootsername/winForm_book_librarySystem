namespace winForm_book_librarySystem
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarLogo = new System.Windows.Forms.Label();
            this.lblSidebarHeader = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavUsers = new System.Windows.Forms.Button();
            this.btnNavInventory = new System.Windows.Forms.Button();
            this.btnNavReservations = new System.Windows.Forms.Button();
            this.btnNavAnalytics = new System.Windows.Forms.Button();
            this.btnNavReports = new System.Windows.Forms.Button();
            this.btnNavSettings = new System.Windows.Forms.Button();
            this.pnlUserProfile = new System.Windows.Forms.Panel();
            this.pnlUserInitials = new System.Windows.Forms.Panel();
            this.lblUserInitials = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTopHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderAvatar = new System.Windows.Forms.Label();
            
            this.pnlKpiUsers = new System.Windows.Forms.Panel();
            this.lblKpiUsersIcon = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label(); // Reused legacy label
            this.lblKpiUsersSub = new System.Windows.Forms.Label();
            
            this.pnlKpiBooks = new System.Windows.Forms.Panel();
            this.lblKpiBooksIcon = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label(); // Reused legacy label
            this.lblKpiBooksSub = new System.Windows.Forms.Label();
            
            this.pnlKpiReservations = new System.Windows.Forms.Panel();
            this.lblKpiResIcon = new System.Windows.Forms.Label();
            this.lblTotalReservations = new System.Windows.Forms.Label(); // Reused legacy label
            this.lblKpiResSub = new System.Windows.Forms.Label();
            
            this.pnlStatusCard = new System.Windows.Forms.Panel();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.pnlStatusRow1 = new System.Windows.Forms.Panel();
            this.lblPending = new System.Windows.Forms.Label(); // Reused legacy label
            this.pnlStatusRow2 = new System.Windows.Forms.Panel();
            this.lblApproved = new System.Windows.Forms.Label(); // Reused legacy label
            this.pnlStatusRow3 = new System.Windows.Forms.Panel();
            this.lblReturned = new System.Windows.Forms.Label(); // Reused legacy label
            this.pnlStatusRow4 = new System.Windows.Forms.Panel();
            this.lblCancelled = new System.Windows.Forms.Label(); // Reused legacy label
            
            this.pnlActionCard = new System.Windows.Forms.Panel();
            this.lblActionTitle = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button(); // Reused legacy button
            this.lblActionDesc = new System.Windows.Forms.Label();

            this.panelSidebar.SuspendLayout();
            this.pnlUserProfile.SuspendLayout();
            this.pnlUserInitials.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelTopHeader.SuspendLayout();
            this.pnlKpiUsers.SuspendLayout();
            this.pnlKpiBooks.SuspendLayout();
            this.pnlKpiReservations.SuspendLayout();
            this.pnlStatusCard.SuspendLayout();
            this.pnlStatusRow1.SuspendLayout();
            this.pnlStatusRow2.SuspendLayout();
            this.pnlStatusRow3.SuspendLayout();
            this.pnlStatusRow4.SuspendLayout();
            this.pnlActionCard.SuspendLayout();
            this.SuspendLayout();

            // Set Control Names for Theme Engine
            this.panelSidebar.Name = "panelSidebar";
            this.lblSidebarLogo.Name = "lblSidebarLogo";
            this.lblSidebarHeader.Name = "lblSidebarHeader";
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavUsers.Name = "btnNavUsers";
            this.btnNavInventory.Name = "btnNavInventory";
            this.btnNavReservations.Name = "btnNavReservations";
            this.btnNavAnalytics.Name = "btnNavAnalytics";
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavSettings.Name = "btnNavSettings";
            this.pnlUserProfile.Name = "pnlUserProfile";
            this.pnlUserInitials.Name = "pnlUserInitials";
            this.lblUserInitials.Name = "lblUserInitials";
            this.lblUserName.Name = "lblUserName";
            this.lblUserRole.Name = "lblUserRole";
            
            this.panelMain.Name = "panelMain";
            this.panelTopHeader.Name = "panelTopHeader";
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblHeaderAvatar.Name = "lblHeaderAvatar";
            
            this.pnlKpiUsers.Name = "pnlKpiUsers";
            this.lblKpiUsersIcon.Name = "lblKpiUsersIcon";
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblKpiUsersSub.Name = "lblKpiUsersSub";
            
            this.pnlKpiBooks.Name = "pnlKpiBooks";
            this.lblKpiBooksIcon.Name = "lblKpiBooksIcon";
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblKpiBooksSub.Name = "lblKpiBooksSub";
            
            this.pnlKpiReservations.Name = "pnlKpiReservations";
            this.lblKpiResIcon.Name = "lblKpiResIcon";
            this.lblTotalReservations.Name = "lblTotalReservations";
            this.lblKpiResSub.Name = "lblKpiResSub";
            
            this.pnlStatusCard.Name = "pnlStatusCard";
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.pnlStatusRow1.Name = "pnlStatusRow1";
            this.lblPending.Name = "lblPending";
            this.pnlStatusRow2.Name = "pnlStatusRow2";
            this.lblApproved.Name = "lblApproved";
            this.pnlStatusRow3.Name = "pnlStatusRow3";
            this.lblReturned.Name = "lblReturned";
            this.pnlStatusRow4.Name = "pnlStatusRow4";
            this.lblCancelled.Name = "lblCancelled";
            
            this.pnlActionCard.Name = "pnlActionCard";
            this.lblActionTitle.Name = "lblActionTitle";
            this.btnReports.Name = "btnReportsSolid";
            this.lblActionDesc.Name = "lblActionDesc";

            // ── Form Canvas ───────────────────────────────────────────────────
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Admin Dashboard — Enhanced Library System";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 248);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Activated += new System.EventHandler(this.AdminDashboard_Activated);

            // ── Left Sidebar Panel ─────────────────────────────────────────────
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Width = 200;
            this.panelSidebar.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSidebarLogo, this.lblSidebarHeader,
                this.btnNavDashboard, this.btnNavUsers, this.btnNavInventory, this.btnNavReservations,
                this.btnNavAnalytics, this.btnNavReports, this.btnNavSettings,
                this.pnlUserProfile
            });

            this.lblSidebarLogo.Text = "🛡️  Library Admin";
            this.lblSidebarLogo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSidebarLogo.ForeColor = System.Drawing.Color.White;
            this.lblSidebarLogo.Location = new System.Drawing.Point(14, 20);
            this.lblSidebarLogo.Size = new System.Drawing.Size(172, 28);

            this.lblSidebarHeader.Text = "OVERVIEW";
            this.lblSidebarHeader.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSidebarHeader.ForeColor = System.Drawing.Color.FromArgb(100, 100, 130);
            this.lblSidebarHeader.Location = new System.Drawing.Point(14, 75);
            this.lblSidebarHeader.Size = new System.Drawing.Size(172, 18);

            // Nav Buttons
            this.btnNavDashboard.Text = "📊  Dashboard";
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnNavDashboard.Size = new System.Drawing.Size(200, 36);

            this.btnNavUsers.Text = "👥  User management";
            this.btnNavUsers.Location = new System.Drawing.Point(0, 140);
            this.btnNavUsers.Size = new System.Drawing.Size(200, 36);

            this.btnNavInventory.Text = "📚  Book inventory";
            this.btnNavInventory.Location = new System.Drawing.Point(0, 180);
            this.btnNavInventory.Size = new System.Drawing.Size(200, 36);

            this.btnNavReservations.Text = "📅  Reservations";
            this.btnNavReservations.Location = new System.Drawing.Point(0, 220);
            this.btnNavReservations.Size = new System.Drawing.Size(200, 36);

            this.btnNavAnalytics.Text = "📈  Analytics";
            this.btnNavAnalytics.Location = new System.Drawing.Point(0, 260);
            this.btnNavAnalytics.Size = new System.Drawing.Size(200, 36);

            this.btnNavReports.Text = "📄  Generate reports";
            this.btnNavReports.Location = new System.Drawing.Point(0, 300);
            this.btnNavReports.Size = new System.Drawing.Size(200, 36);

            this.btnNavSettings.Text = "⚙️  Settings";
            this.btnNavSettings.Location = new System.Drawing.Point(0, 340);
            this.btnNavSettings.Size = new System.Drawing.Size(200, 36);

            // Bottom Profile Widget
            this.pnlUserProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserProfile.Height = 60;
            this.pnlUserProfile.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserProfile.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlUserInitials, this.lblUserName, this.lblUserRole
            });

            this.pnlUserInitials.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.pnlUserInitials.Location = new System.Drawing.Point(14, 10);
            this.pnlUserInitials.Size = new System.Drawing.Size(36, 36);
            this.pnlUserInitials.Controls.Add(this.lblUserInitials);

            this.lblUserInitials.Text = "AD";
            this.lblUserInitials.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUserInitials.ForeColor = System.Drawing.Color.FromArgb(26, 26, 46);
            this.lblUserInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblUserName.Text = "Administrator";
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(58, 10);
            this.lblUserName.Size = new System.Drawing.Size(130, 18);

            this.lblUserRole.Text = "Super admin";
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(120, 120, 150);
            this.lblUserRole.Location = new System.Drawing.Point(58, 28);
            this.lblUserRole.Size = new System.Drawing.Size(100, 18);


            // ── Right Main Area Panel ──────────────────────────────────────────
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelTopHeader, this.pnlKpiUsers, this.pnlKpiBooks, this.pnlKpiReservations,
                this.pnlStatusCard, this.pnlActionCard
            });

            // Top Header Panel
            this.panelTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopHeader.Height = 70;
            this.panelTopHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelTopHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPageTitle, this.lblPageSubtitle, this.lblHeaderAvatar
            });

            this.lblPageTitle.Text = "Admin dashboard";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.lblPageTitle.Location = new System.Drawing.Point(24, 12);
            this.lblPageTitle.Size = new System.Drawing.Size(250, 32);

            this.lblPageSubtitle.Text = "System overview — CCS Library Panel";
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblPageSubtitle.Location = new System.Drawing.Point(24, 44);
            this.lblPageSubtitle.Size = new System.Drawing.Size(300, 20);

            // Circular avatar on header
            this.lblHeaderAvatar.Text = "AD";
            this.lblHeaderAvatar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHeaderAvatar.ForeColor = System.Drawing.Color.FromArgb(26, 26, 46);
            this.lblHeaderAvatar.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblHeaderAvatar.Location = new System.Drawing.Point(738, 17);
            this.lblHeaderAvatar.Size = new System.Drawing.Size(32, 32);
            this.lblHeaderAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            // ── KPI Card 1 (Total Users) ──────────────────────────────────────
            this.pnlKpiUsers.Location = new System.Drawing.Point(24, 85);
            this.pnlKpiUsers.Size = new System.Drawing.Size(230, 95);
            this.pnlKpiUsers.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblKpiUsersIcon, this.lblTotalUsers, this.lblKpiUsersSub
            });

            this.lblKpiUsersIcon.Text = "👥";
            this.lblKpiUsersIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.lblKpiUsersIcon.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblKpiUsersIcon.Location = new System.Drawing.Point(16, 12);
            this.lblKpiUsersIcon.Size = new System.Drawing.Size(24, 20);

            // Reused legacy label (Total Users)
            this.lblTotalUsers.Text = "Total Users: 0";
            this.lblTotalUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsers.ForeColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.lblTotalUsers.Location = new System.Drawing.Point(12, 36);
            this.lblTotalUsers.Size = new System.Drawing.Size(200, 24);

            this.lblKpiUsersSub.Text = "↑ 14 new this month";
            this.lblKpiUsersSub.Font = new System.Drawing.Font("Segoe UI", 8F, FontStyle.Bold);
            this.lblKpiUsersSub.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblKpiUsersSub.Location = new System.Drawing.Point(16, 70);
            this.lblKpiUsersSub.Size = new System.Drawing.Size(200, 18);


            // ── KPI Card 2 (Total Books) ──────────────────────────────────────
            this.pnlKpiBooks.Location = new System.Drawing.Point(278, 85);
            this.pnlKpiBooks.Size = new System.Drawing.Size(230, 95);
            this.pnlKpiBooks.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblKpiBooksIcon, this.lblTotalBooks, this.lblKpiBooksSub
            });

            this.lblKpiBooksIcon.Text = "📚";
            this.lblKpiBooksIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.lblKpiBooksIcon.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblKpiBooksIcon.Location = new System.Drawing.Point(16, 12);
            this.lblKpiBooksIcon.Size = new System.Drawing.Size(24, 20);

            // Reused legacy label (Total Books)
            this.lblTotalBooks.Text = "Total Books: 0";
            this.lblTotalBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooks.ForeColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.lblTotalBooks.Location = new System.Drawing.Point(12, 36);
            this.lblTotalBooks.Size = new System.Drawing.Size(200, 24);

            this.lblKpiBooksSub.Text = "↑ 12 added this week";
            this.lblKpiBooksSub.Font = new System.Drawing.Font("Segoe UI", 8F, FontStyle.Bold);
            this.lblKpiBooksSub.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblKpiBooksSub.Location = new System.Drawing.Point(16, 70);
            this.lblKpiBooksSub.Size = new System.Drawing.Size(200, 18);


            // ── KPI Card 3 (Total Reservations) ───────────────────────────────
            this.pnlKpiReservations.Location = new System.Drawing.Point(532, 85);
            this.pnlKpiReservations.Size = new System.Drawing.Size(238, 95);
            this.pnlKpiReservations.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblKpiResIcon, this.lblTotalReservations, this.lblKpiResSub
            });

            this.lblKpiResIcon.Text = "📅";
            this.lblKpiResIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.lblKpiResIcon.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblKpiResIcon.Location = new System.Drawing.Point(16, 12);
            this.lblKpiResIcon.Size = new System.Drawing.Size(24, 20);

            // Reused legacy label (Total Reservations)
            this.lblTotalReservations.Text = "Total Reservations: 0";
            this.lblTotalReservations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalReservations.ForeColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.lblTotalReservations.Location = new System.Drawing.Point(12, 36);
            this.lblTotalReservations.Size = new System.Drawing.Size(215, 24);

            this.lblKpiResSub.Text = "All time total";
            this.lblKpiResSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblKpiResSub.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblKpiResSub.Location = new System.Drawing.Point(16, 70);
            this.lblKpiResSub.Size = new System.Drawing.Size(200, 18);


            // ── Left Column Card (Status Overview Card) ───────────────────────
            this.pnlStatusCard.Location = new System.Drawing.Point(24, 195);
            this.pnlStatusCard.Size = new System.Drawing.Size(484, 375);
            this.pnlStatusCard.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblStatusTitle,
                this.pnlStatusRow1, this.pnlStatusRow2, this.pnlStatusRow3, this.pnlStatusRow4
            });

            this.lblStatusTitle.Text = "Reservation status summary";
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.lblStatusTitle.Location = new System.Drawing.Point(16, 16);
            this.lblStatusTitle.Size = new System.Drawing.Size(250, 22);

            // Status Row 1 (Pending)
            this.pnlStatusRow1.Location = new System.Drawing.Point(16, 54);
            this.pnlStatusRow1.Size = new System.Drawing.Size(450, 60);
            this.pnlStatusRow1.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatusRow1.Controls.Add(this.lblPending);
            
            this.lblPending.Text = "Pending: 0";
            this.lblPending.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPending.ForeColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.lblPending.Location = new System.Drawing.Point(16, 18);
            this.lblPending.Size = new System.Drawing.Size(400, 24);

            // Status Row 2 (Approved)
            this.pnlStatusRow2.Location = new System.Drawing.Point(16, 124);
            this.pnlStatusRow2.Size = new System.Drawing.Size(450, 60);
            this.pnlStatusRow2.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatusRow2.Controls.Add(this.lblApproved);

            this.lblApproved.Text = "Approved: 0";
            this.lblApproved.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblApproved.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.lblApproved.Location = new System.Drawing.Point(16, 18);
            this.lblApproved.Size = new System.Drawing.Size(400, 24);

            // Status Row 3 (Returned)
            this.pnlStatusRow3.Location = new System.Drawing.Point(16, 194);
            this.pnlStatusRow3.Size = new System.Drawing.Size(450, 60);
            this.pnlStatusRow3.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatusRow3.Controls.Add(this.lblReturned);

            this.lblReturned.Text = "Returned: 0";
            this.lblReturned.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReturned.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblReturned.Location = new System.Drawing.Point(16, 18);
            this.lblReturned.Size = new System.Drawing.Size(400, 24);

            // Status Row 4 (Cancelled)
            this.pnlStatusRow4.Location = new System.Drawing.Point(16, 264);
            this.pnlStatusRow4.Size = new System.Drawing.Size(450, 60);
            this.pnlStatusRow4.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatusRow4.Controls.Add(this.lblCancelled);

            this.lblCancelled.Text = "Cancelled: 0";
            this.lblCancelled.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCancelled.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.lblCancelled.Location = new System.Drawing.Point(16, 18);
            this.lblCancelled.Size = new System.Drawing.Size(400, 24);


            // ── Right Column Card (Action Card) ───────────────────────────────
            this.pnlActionCard.Location = new System.Drawing.Point(532, 195);
            this.pnlActionCard.Size = new System.Drawing.Size(238, 375);
            this.pnlActionCard.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblActionTitle, this.btnReports, this.lblActionDesc
            });

            this.lblActionTitle.Text = "Quick actions";
            this.lblActionTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblActionTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.lblActionTitle.Location = new System.Drawing.Point(16, 16);
            this.lblActionTitle.Size = new System.Drawing.Size(150, 22);

            // Reused legacy Reports Button
            this.btnReports.Text = "📊  View Reports";
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Location = new System.Drawing.Point(16, 54);
            this.btnReports.Size = new System.Drawing.Size(206, 42);
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            this.lblActionDesc.Text = "Generate system-wide analytics, print PDF catalogs, check pending student approvals, and monitor logs.";
            this.lblActionDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblActionDesc.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblActionDesc.Location = new System.Drawing.Point(16, 115);
            this.lblActionDesc.Size = new System.Drawing.Size(206, 100);


            // ── Add to Canvas ───────────────────────────────────────────────
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);

            this.panelSidebar.ResumeLayout(false);
            this.pnlUserProfile.ResumeLayout(false);
            this.pnlUserInitials.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelTopHeader.ResumeLayout(false);
            this.panelTopHeader.PerformLayout();
            this.pnlKpiUsers.ResumeLayout(false);
            this.pnlKpiBooks.ResumeLayout(false);
            this.pnlKpiReservations.ResumeLayout(false);
            this.pnlStatusCard.ResumeLayout(false);
            this.pnlStatusRow1.ResumeLayout(false);
            this.pnlStatusRow2.ResumeLayout(false);
            this.pnlStatusRow3.ResumeLayout(false);
            this.pnlStatusRow4.ResumeLayout(false);
            this.pnlActionCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSidebarLogo;
        private System.Windows.Forms.Label lblSidebarHeader;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavUsers;
        private System.Windows.Forms.Button btnNavInventory;
        private System.Windows.Forms.Button btnNavReservations;
        private System.Windows.Forms.Button btnNavAnalytics;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnNavSettings;
        
        private System.Windows.Forms.Panel pnlUserProfile;
        private System.Windows.Forms.Panel pnlUserInitials;
        private System.Windows.Forms.Label lblUserInitials;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTopHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Label lblHeaderAvatar;

        private System.Windows.Forms.Panel pnlKpiUsers;
        private System.Windows.Forms.Label lblKpiUsersIcon;
        private System.Windows.Forms.Label lblTotalUsers;

        private System.Windows.Forms.Panel pnlKpiBooks;
        private System.Windows.Forms.Label lblKpiBooksIcon;
        private System.Windows.Forms.Label lblTotalBooks;

        private System.Windows.Forms.Panel pnlKpiReservations;
        private System.Windows.Forms.Label lblKpiResIcon;
        private System.Windows.Forms.Label lblTotalReservations;
        private System.Windows.Forms.Label lblKpiUsersSub;
        private System.Windows.Forms.Label lblKpiBooksSub;
        private System.Windows.Forms.Label lblKpiResSub;

        private System.Windows.Forms.Panel pnlStatusCard;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Panel pnlStatusRow1;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Panel pnlStatusRow2;
        private System.Windows.Forms.Label lblApproved;
        private System.Windows.Forms.Panel pnlStatusRow3;
        private System.Windows.Forms.Label lblReturned;
        private System.Windows.Forms.Panel pnlStatusRow4;
        private System.Windows.Forms.Label lblCancelled;
        
        private System.Windows.Forms.Panel pnlActionCard;
        private System.Windows.Forms.Label lblActionTitle;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label lblActionDesc;
    }
}
