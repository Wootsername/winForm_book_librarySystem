namespace winForm_book_librarySystem
{
    partial class StudentDashboard
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
            panelSidebar = new Panel();
            lblSidebarLogo = new Label();
            lblSidebarHeader = new Label();
            btnNavDashboard = new Button();
            btnNavBrowse = new Button();
            btnNavReservations = new Button();
            btnNavHistory = new Button();
            btnNavProfile = new Button();
            pnlUserProfile = new Panel();
            pnlUserInitials = new Panel();
            lblUserInitials = new Label();
            lblUserName = new Label();
            lblUserRole = new Label();
            panelMain = new Panel();
            panelTopHeader = new Panel();
            lblPageTitle = new Label();
            lblWelcome = new Label();
            txtHeaderSearch = new TextBox();
            btnNotifications = new Button();
            lblHeaderAvatar = new Label();
            pnlKpiBorrowed = new Panel();
            lblKpiBorrowedTitle = new Label();
            lblKpiBorrowedNum = new Label();
            lblKpiBorrowedSub = new Label();
            pnlKpiActive = new Panel();
            lblKpiActiveTitle = new Label();
            lblKpiActiveNum = new Label();
            lblKpiActiveSub = new Label();
            pnlKpiReturned = new Panel();
            lblKpiReturnedTitle = new Label();
            lblKpiReturnedNum = new Label();
            lblKpiReturnedSub = new Label();
            pnlLeftCard = new Panel();
            lblLeftCardTitle = new Label();
            btnReserveBook = new Button();
            dgvHistory = new DataGridView();
            pnlRightCard = new Panel();
            lblRightCardTitle = new Label();
            dgvActiveReservations = new DataGridView();
            panelSidebar.SuspendLayout();
            pnlUserProfile.SuspendLayout();
            pnlUserInitials.SuspendLayout();
            panelMain.SuspendLayout();
            panelTopHeader.SuspendLayout();
            pnlKpiBorrowed.SuspendLayout();
            pnlKpiActive.SuspendLayout();
            pnlKpiReturned.SuspendLayout();
            pnlLeftCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            pnlRightCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActiveReservations).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(lblSidebarLogo);
            panelSidebar.Controls.Add(lblSidebarHeader);
            panelSidebar.Controls.Add(btnNavDashboard);
            panelSidebar.Controls.Add(btnNavBrowse);
            panelSidebar.Controls.Add(btnNavReservations);
            panelSidebar.Controls.Add(btnNavHistory);
            panelSidebar.Controls.Add(btnNavProfile);
            panelSidebar.Controls.Add(pnlUserProfile);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 600);
            panelSidebar.TabIndex = 1;
            // 
            // lblSidebarLogo
            // 
            lblSidebarLogo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSidebarLogo.ForeColor = Color.White;
            lblSidebarLogo.Location = new Point(14, 20);
            lblSidebarLogo.Name = "lblSidebarLogo";
            lblSidebarLogo.Size = new Size(172, 28);
            lblSidebarLogo.TabIndex = 0;
            lblSidebarLogo.Text = "📘  Library System";
            // 
            // lblSidebarHeader
            // 
            lblSidebarHeader.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblSidebarHeader.ForeColor = Color.FromArgb(100, 100, 130);
            lblSidebarHeader.Location = new Point(14, 75);
            lblSidebarHeader.Name = "lblSidebarHeader";
            lblSidebarHeader.Size = new Size(172, 18);
            lblSidebarHeader.TabIndex = 1;
            lblSidebarHeader.Text = "STUDENT";
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Location = new Point(0, 100);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new Size(200, 36);
            btnNavDashboard.TabIndex = 2;
            btnNavDashboard.Text = "📊  Dashboard";
            // 
            // btnNavBrowse
            // 
            btnNavBrowse.Location = new Point(0, 140);
            btnNavBrowse.Name = "btnNavBrowse";
            btnNavBrowse.Size = new Size(200, 36);
            btnNavBrowse.TabIndex = 3;
            btnNavBrowse.Text = "📖  Browse books";
            // 
            // btnNavReservations
            // 
            btnNavReservations.Location = new Point(0, 180);
            btnNavReservations.Name = "btnNavReservations";
            btnNavReservations.Size = new Size(200, 36);
            btnNavReservations.TabIndex = 4;
            btnNavReservations.Text = "📅  My reservations";
            // 
            // btnNavHistory
            // 
            btnNavHistory.Location = new Point(0, 220);
            btnNavHistory.Name = "btnNavHistory";
            btnNavHistory.Size = new Size(200, 36);
            btnNavHistory.TabIndex = 5;
            btnNavHistory.Text = "⏳  Borrow history";
            // 
            // btnNavProfile
            // 
            btnNavProfile.Location = new Point(0, 260);
            btnNavProfile.Name = "btnNavProfile";
            btnNavProfile.Size = new Size(200, 36);
            btnNavProfile.TabIndex = 6;
            btnNavProfile.Text = "👤  My profile";
            // 
            // pnlUserProfile
            // 
            pnlUserProfile.BackColor = Color.Transparent;
            pnlUserProfile.Controls.Add(lblUserRole);
            pnlUserProfile.Controls.Add(lblUserName);
            pnlUserProfile.Controls.Add(pnlUserInitials);
            pnlUserProfile.Dock = DockStyle.Bottom;
            pnlUserProfile.Location = new Point(0, 540);
            pnlUserProfile.Name = "pnlUserProfile";
            pnlUserProfile.Size = new Size(200, 60);
            pnlUserProfile.TabIndex = 7;
            // 
            // pnlUserInitials
            // 
            pnlUserInitials.BackColor = Color.FromArgb(212, 175, 55);
            pnlUserInitials.Controls.Add(lblUserInitials);
            pnlUserInitials.Location = new Point(14, 10);
            pnlUserInitials.Name = "pnlUserInitials";
            pnlUserInitials.Size = new Size(36, 36);
            pnlUserInitials.TabIndex = 0;
            // 
            // lblUserInitials
            // 
            lblUserInitials.Dock = DockStyle.Fill;
            lblUserInitials.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserInitials.ForeColor = Color.FromArgb(26, 26, 46);
            lblUserInitials.Location = new Point(0, 0);
            lblUserInitials.Name = "lblUserInitials";
            lblUserInitials.Size = new Size(36, 36);
            lblUserInitials.TabIndex = 0;
            lblUserInitials.Text = "KG";
            lblUserInitials.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(58, 10);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(130, 18);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Karl Gaviola";
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new Font("Segoe UI", 8F);
            lblUserRole.ForeColor = Color.FromArgb(120, 120, 150);
            lblUserRole.Location = new Point(58, 28);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(100, 18);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "Student";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelTopHeader);
            panelMain.Controls.Add(pnlKpiBorrowed);
            panelMain.Controls.Add(pnlKpiActive);
            panelMain.Controls.Add(pnlKpiReturned);
            panelMain.Controls.Add(pnlLeftCard);
            panelMain.Controls.Add(pnlRightCard);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 600);
            panelMain.TabIndex = 0;
            // 
            // panelTopHeader
            // 
            panelTopHeader.BackColor = Color.Transparent;
            panelTopHeader.Controls.Add(lblPageTitle);
            panelTopHeader.Controls.Add(lblWelcome);
            panelTopHeader.Controls.Add(txtHeaderSearch);
            panelTopHeader.Controls.Add(btnNotifications);
            panelTopHeader.Controls.Add(lblHeaderAvatar);
            panelTopHeader.Dock = DockStyle.Top;
            panelTopHeader.Location = new Point(0, 0);
            panelTopHeader.Name = "panelTopHeader";
            panelTopHeader.Size = new Size(800, 70);
            panelTopHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(30, 30, 50);
            lblPageTitle.Location = new Point(24, 12);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(200, 32);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "My dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 9.5F);
            lblWelcome.ForeColor = Color.FromArgb(120, 120, 140);
            lblWelcome.Location = new Point(24, 44);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(300, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Student!";
            // 
            // txtHeaderSearch
            // 
            txtHeaderSearch.BorderStyle = BorderStyle.FixedSingle;
            txtHeaderSearch.Location = new Point(395, 20);
            txtHeaderSearch.Name = "txtHeaderSearch";
            txtHeaderSearch.PlaceholderText = "🔍 Search books...";
            txtHeaderSearch.Size = new Size(180, 23);
            txtHeaderSearch.TabIndex = 2;
            // 
            // btnNotifications
            // 
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            btnNotifications.Location = new Point(590, 18);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(140, 30);
            btnNotifications.TabIndex = 3;
            btnNotifications.Text = "Notifications (0)";
            // 
            // lblHeaderAvatar
            // 
            lblHeaderAvatar.BackColor = Color.FromArgb(212, 175, 55);
            lblHeaderAvatar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHeaderAvatar.ForeColor = Color.FromArgb(26, 26, 46);
            lblHeaderAvatar.Location = new Point(745, 17);
            lblHeaderAvatar.Name = "lblHeaderAvatar";
            lblHeaderAvatar.Size = new Size(32, 32);
            lblHeaderAvatar.TabIndex = 4;
            lblHeaderAvatar.Text = "ST";
            lblHeaderAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlKpiBorrowed
            // 
            pnlKpiBorrowed.Controls.Add(lblKpiBorrowedTitle);
            pnlKpiBorrowed.Controls.Add(lblKpiBorrowedNum);
            pnlKpiBorrowed.Controls.Add(lblKpiBorrowedSub);
            pnlKpiBorrowed.Location = new Point(24, 85);
            pnlKpiBorrowed.Name = "pnlKpiBorrowed";
            pnlKpiBorrowed.Size = new Size(230, 95);
            pnlKpiBorrowed.TabIndex = 1;
            // 
            // lblKpiBorrowedTitle
            // 
            lblKpiBorrowedTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKpiBorrowedTitle.ForeColor = Color.FromArgb(120, 120, 140);
            lblKpiBorrowedTitle.Location = new Point(16, 12);
            lblKpiBorrowedTitle.Name = "lblKpiBorrowedTitle";
            lblKpiBorrowedTitle.Size = new Size(120, 18);
            lblKpiBorrowedTitle.TabIndex = 0;
            lblKpiBorrowedTitle.Text = "Books borrowed";
            // 
            // lblKpiBorrowedNum
            // 
            lblKpiBorrowedNum.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblKpiBorrowedNum.ForeColor = Color.FromArgb(30, 30, 50);
            lblKpiBorrowedNum.Location = new Point(12, 32);
            lblKpiBorrowedNum.Name = "lblKpiBorrowedNum";
            lblKpiBorrowedNum.Size = new Size(100, 42);
            lblKpiBorrowedNum.TabIndex = 1;
            lblKpiBorrowedNum.Text = "3";
            // 
            // lblKpiBorrowedSub
            // 
            lblKpiBorrowedSub.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblKpiBorrowedSub.ForeColor = Color.FromArgb(46, 125, 50);
            lblKpiBorrowedSub.Location = new Point(16, 72);
            lblKpiBorrowedSub.Name = "lblKpiBorrowedSub";
            lblKpiBorrowedSub.Size = new Size(200, 18);
            lblKpiBorrowedSub.TabIndex = 2;
            lblKpiBorrowedSub.Text = "✓ 1 due this week";
            // 
            // pnlKpiActive
            // 
            pnlKpiActive.Controls.Add(lblKpiActiveTitle);
            pnlKpiActive.Controls.Add(lblKpiActiveNum);
            pnlKpiActive.Controls.Add(lblKpiActiveSub);
            pnlKpiActive.Location = new Point(278, 85);
            pnlKpiActive.Name = "pnlKpiActive";
            pnlKpiActive.Size = new Size(230, 95);
            pnlKpiActive.TabIndex = 2;
            // 
            // lblKpiActiveTitle
            // 
            lblKpiActiveTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKpiActiveTitle.ForeColor = Color.FromArgb(120, 120, 140);
            lblKpiActiveTitle.Location = new Point(16, 12);
            lblKpiActiveTitle.Name = "lblKpiActiveTitle";
            lblKpiActiveTitle.Size = new Size(140, 18);
            lblKpiActiveTitle.TabIndex = 0;
            lblKpiActiveTitle.Text = "Active reservations";
            // 
            // lblKpiActiveNum
            // 
            lblKpiActiveNum.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblKpiActiveNum.ForeColor = Color.FromArgb(30, 30, 50);
            lblKpiActiveNum.Location = new Point(12, 32);
            lblKpiActiveNum.Name = "lblKpiActiveNum";
            lblKpiActiveNum.Size = new Size(100, 42);
            lblKpiActiveNum.TabIndex = 1;
            lblKpiActiveNum.Text = "2";
            // 
            // lblKpiActiveSub
            // 
            lblKpiActiveSub.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblKpiActiveSub.ForeColor = Color.FromArgb(239, 108, 0);
            lblKpiActiveSub.Location = new Point(16, 72);
            lblKpiActiveSub.Name = "lblKpiActiveSub";
            lblKpiActiveSub.Size = new Size(200, 18);
            lblKpiActiveSub.TabIndex = 2;
            lblKpiActiveSub.Text = "⏳ 1 pending approval";
            // 
            // pnlKpiReturned
            // 
            pnlKpiReturned.Controls.Add(lblKpiReturnedTitle);
            pnlKpiReturned.Controls.Add(lblKpiReturnedNum);
            pnlKpiReturned.Controls.Add(lblKpiReturnedSub);
            pnlKpiReturned.Location = new Point(532, 85);
            pnlKpiReturned.Name = "pnlKpiReturned";
            pnlKpiReturned.Size = new Size(248, 95);
            pnlKpiReturned.TabIndex = 3;
            // 
            // lblKpiReturnedTitle
            // 
            lblKpiReturnedTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKpiReturnedTitle.ForeColor = Color.FromArgb(120, 120, 140);
            lblKpiReturnedTitle.Location = new Point(16, 12);
            lblKpiReturnedTitle.Name = "lblKpiReturnedTitle";
            lblKpiReturnedTitle.Size = new Size(120, 18);
            lblKpiReturnedTitle.TabIndex = 0;
            lblKpiReturnedTitle.Text = "Books returned";
            // 
            // lblKpiReturnedNum
            // 
            lblKpiReturnedNum.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblKpiReturnedNum.ForeColor = Color.FromArgb(30, 30, 50);
            lblKpiReturnedNum.Location = new Point(12, 32);
            lblKpiReturnedNum.Name = "lblKpiReturnedNum";
            lblKpiReturnedNum.Size = new Size(100, 42);
            lblKpiReturnedNum.TabIndex = 1;
            lblKpiReturnedNum.Text = "11";
            // 
            // lblKpiReturnedSub
            // 
            lblKpiReturnedSub.Font = new Font("Segoe UI", 8F);
            lblKpiReturnedSub.ForeColor = Color.FromArgb(120, 120, 140);
            lblKpiReturnedSub.Location = new Point(16, 72);
            lblKpiReturnedSub.Name = "lblKpiReturnedSub";
            lblKpiReturnedSub.Size = new Size(200, 18);
            lblKpiReturnedSub.TabIndex = 2;
            lblKpiReturnedSub.Text = "All time total";
            // 
            // pnlLeftCard
            // 
            pnlLeftCard.Controls.Add(lblLeftCardTitle);
            pnlLeftCard.Controls.Add(btnReserveBook);
            pnlLeftCard.Controls.Add(dgvHistory);
            pnlLeftCard.Location = new Point(24, 195);
            pnlLeftCard.Name = "pnlLeftCard";
            pnlLeftCard.Size = new Size(365, 375);
            pnlLeftCard.TabIndex = 4;
            // 
            // lblLeftCardTitle
            // 
            lblLeftCardTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLeftCardTitle.ForeColor = Color.FromArgb(30, 30, 50);
            lblLeftCardTitle.Location = new Point(16, 16);
            lblLeftCardTitle.Name = "lblLeftCardTitle";
            lblLeftCardTitle.Size = new Size(200, 22);
            lblLeftCardTitle.TabIndex = 0;
            lblLeftCardTitle.Text = "Currently borrowed / History";
            // 
            // btnReserveBook
            // 
            btnReserveBook.FlatStyle = FlatStyle.Flat;
            btnReserveBook.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnReserveBook.Location = new Point(234, 12);
            btnReserveBook.Name = "btnReserveBook";
            btnReserveBook.Size = new Size(115, 28);
            btnReserveBook.TabIndex = 1;
            btnReserveBook.Text = "+ Borrow Book";
            btnReserveBook.Click += btnReserveBook_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.Location = new Point(16, 54);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(333, 305);
            dgvHistory.TabIndex = 2;
            // 
            // pnlRightCard
            // 
            pnlRightCard.Controls.Add(lblRightCardTitle);
            pnlRightCard.Controls.Add(dgvActiveReservations);
            pnlRightCard.Location = new Point(409, 195);
            pnlRightCard.Name = "pnlRightCard";
            pnlRightCard.Size = new Size(371, 375);
            pnlRightCard.TabIndex = 5;
            // 
            // lblRightCardTitle
            // 
            lblRightCardTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRightCardTitle.ForeColor = Color.FromArgb(30, 30, 50);
            lblRightCardTitle.Location = new Point(16, 16);
            lblRightCardTitle.Name = "lblRightCardTitle";
            lblRightCardTitle.Size = new Size(200, 22);
            lblRightCardTitle.TabIndex = 0;
            lblRightCardTitle.Text = "Active reservations";
            // 
            // dgvActiveReservations
            // 
            dgvActiveReservations.Location = new Point(16, 54);
            dgvActiveReservations.Name = "dgvActiveReservations";
            dgvActiveReservations.ReadOnly = true;
            dgvActiveReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActiveReservations.Size = new Size(339, 305);
            dgvActiveReservations.TabIndex = 1;
            // 
            // StudentDashboard
            // 
            BackColor = Color.FromArgb(245, 245, 248);
            ClientSize = new Size(1000, 600);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Dashboard — Library System";
            Activated += StudentDashboard_Activated;
            panelSidebar.ResumeLayout(false);
            pnlUserProfile.ResumeLayout(false);
            pnlUserInitials.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelTopHeader.ResumeLayout(false);
            panelTopHeader.PerformLayout();
            pnlKpiBorrowed.ResumeLayout(false);
            pnlKpiActive.ResumeLayout(false);
            pnlKpiReturned.ResumeLayout(false);
            pnlLeftCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            pnlRightCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActiveReservations).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSidebarLogo;
        private System.Windows.Forms.Label lblSidebarHeader;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavBrowse;
        private System.Windows.Forms.Button btnNavReservations;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Button btnNavProfile;
        
        private System.Windows.Forms.Panel pnlUserProfile;
        private System.Windows.Forms.Panel pnlUserInitials;
        private System.Windows.Forms.Label lblUserInitials;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTopHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblWelcome; // Reused legacy label
        private System.Windows.Forms.TextBox txtHeaderSearch;
        private System.Windows.Forms.Button btnNotifications; // Reused legacy button
        private System.Windows.Forms.Label lblHeaderAvatar;

        private System.Windows.Forms.Panel pnlKpiBorrowed;
        private System.Windows.Forms.Label lblKpiBorrowedTitle;
        private System.Windows.Forms.Label lblKpiBorrowedNum;
        private System.Windows.Forms.Label lblKpiBorrowedSub;

        private System.Windows.Forms.Panel pnlKpiActive;
        private System.Windows.Forms.Label lblKpiActiveTitle;
        private System.Windows.Forms.Label lblKpiActiveNum;
        private System.Windows.Forms.Label lblKpiActiveSub;

        private System.Windows.Forms.Panel pnlKpiReturned;
        private System.Windows.Forms.Label lblKpiReturnedTitle;
        private System.Windows.Forms.Label lblKpiReturnedNum;
        private System.Windows.Forms.Label lblKpiReturnedSub;

        private System.Windows.Forms.Panel pnlLeftCard;
        private System.Windows.Forms.Label lblLeftCardTitle;
        private System.Windows.Forms.Button btnReserveBook; // Reused legacy button
        private System.Windows.Forms.DataGridView dgvHistory; // Reused legacy grid
        
        private System.Windows.Forms.Panel pnlRightCard;
        private System.Windows.Forms.Label lblRightCardTitle;
        private System.Windows.Forms.DataGridView dgvActiveReservations; // Reused legacy grid
    }
}
