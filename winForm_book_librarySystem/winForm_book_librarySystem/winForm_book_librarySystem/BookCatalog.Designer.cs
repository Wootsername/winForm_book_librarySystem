namespace winForm_book_librarySystem
{
    partial class BookCatalog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            lblLogoText = new Label();
            btnNavDashboard = new Button();
            btnNavCatalog = new Button();
            btnNavReservations = new Button();
            btnNavMembers = new Button();
            lblSidebarGenre = new Label();
            btnGenreAll = new Button();
            btnGenreProgramming = new Button();
            btnGenreDatabase = new Button();
            btnGenreNetworking = new Button();
            btnGenreMath = new Button();
            btnGenreAI = new Button();
            btnNavReports = new Button();
            btnNavNotifications = new Button();
            btnNavSettings = new Button();
            lblUserName = new Label();
            lblUserRole = new Label();
            panelMain = new Panel();
            lblPageTitle = new Label();
            btnAddBook = new Button();
            txtSearch = new TextBox();
            btnFilterAll = new Button();
            btnFilterAvailable = new Button();
            btnFilterTaken = new Button();
            btnFilterLowStock = new Button();
            lblResultCount = new Label();
            flowBooks = new FlowLayoutPanel();
            pnlDetail = new Panel();
            lblDetailTitle = new Label();
            pnlDetailIcon = new Panel();
            lblDetailIconEmoji = new Label();
            lblDetailBookName = new Label();
            lblDetailAuthor = new Label();
            lblDetailGenreKey = new Label();
            lblDetailGenreVal = new Label();
            lblDetailISBNKey = new Label();
            lblDetailISBNVal = new Label();
            lblDetailCopiesKey = new Label();
            lblDetailCopiesVal = new Label();
            lblDetailAvailKey = new Label();
            lblDetailAvailVal = new Label();
            lblDetailStatusKey = new Label();
            lblDetailStatusVal = new Label();
            btnReserve = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            pnlDetail.SuspendLayout();
            pnlDetailIcon.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(26, 26, 46);
            panelSidebar.Controls.Add(lblLogoText);
            panelSidebar.Controls.Add(btnNavDashboard);
            panelSidebar.Controls.Add(btnNavCatalog);
            panelSidebar.Controls.Add(btnNavReservations);
            panelSidebar.Controls.Add(btnNavMembers);
            panelSidebar.Controls.Add(lblSidebarGenre);
            panelSidebar.Controls.Add(btnGenreAll);
            panelSidebar.Controls.Add(btnGenreProgramming);
            panelSidebar.Controls.Add(btnGenreDatabase);
            panelSidebar.Controls.Add(btnGenreNetworking);
            panelSidebar.Controls.Add(btnGenreMath);
            panelSidebar.Controls.Add(btnGenreAI);
            panelSidebar.Controls.Add(btnNavReports);
            panelSidebar.Controls.Add(btnNavNotifications);
            panelSidebar.Controls.Add(btnNavSettings);
            panelSidebar.Controls.Add(lblUserName);
            panelSidebar.Controls.Add(lblUserRole);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 660);
            panelSidebar.TabIndex = 1;
            // 
            // lblLogoText
            // 
            lblLogoText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLogoText.ForeColor = Color.White;
            lblLogoText.Location = new Point(14, 20);
            lblLogoText.Name = "lblLogoText";
            lblLogoText.Size = new Size(172, 28);
            lblLogoText.TabIndex = 0;
            lblLogoText.Text = "Library System";
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Location = new Point(0, 70);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new Size(200, 36);
            btnNavDashboard.TabIndex = 1;
            btnNavDashboard.Text = "Dashboard";
            // 
            // btnNavCatalog
            // 
            btnNavCatalog.Location = new Point(0, 110);
            btnNavCatalog.Name = "btnNavCatalog";
            btnNavCatalog.Size = new Size(200, 36);
            btnNavCatalog.TabIndex = 2;
            btnNavCatalog.Text = "Book Catalog";
            // 
            // btnNavReservations
            // 
            btnNavReservations.Location = new Point(0, 150);
            btnNavReservations.Name = "btnNavReservations";
            btnNavReservations.Size = new Size(200, 36);
            btnNavReservations.TabIndex = 3;
            btnNavReservations.Text = "Reservations";
            // 
            // btnNavMembers
            // 
            btnNavMembers.Location = new Point(0, 190);
            btnNavMembers.Name = "btnNavMembers";
            btnNavMembers.Size = new Size(200, 36);
            btnNavMembers.TabIndex = 4;
            btnNavMembers.Text = "Members";
            // 
            // lblSidebarGenre
            // 
            lblSidebarGenre.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblSidebarGenre.ForeColor = Color.FromArgb(100, 100, 130);
            lblSidebarGenre.Location = new Point(14, 245);
            lblSidebarGenre.Name = "lblSidebarGenre";
            lblSidebarGenre.Size = new Size(172, 18);
            lblSidebarGenre.TabIndex = 5;
            lblSidebarGenre.Text = "FILTER BY GENRE";
            // 
            // btnGenreAll
            // 
            btnGenreAll.Location = new Point(0, 266);
            btnGenreAll.Name = "btnGenreAll";
            btnGenreAll.Size = new Size(200, 36);
            btnGenreAll.TabIndex = 6;
            btnGenreAll.Text = "All Genres";
            // 
            // btnGenreProgramming
            // 
            btnGenreProgramming.Location = new Point(0, 302);
            btnGenreProgramming.Name = "btnGenreProgramming";
            btnGenreProgramming.Size = new Size(200, 36);
            btnGenreProgramming.TabIndex = 7;
            btnGenreProgramming.Text = "Programming";
            // 
            // btnGenreDatabase
            // 
            btnGenreDatabase.Location = new Point(0, 338);
            btnGenreDatabase.Name = "btnGenreDatabase";
            btnGenreDatabase.Size = new Size(200, 36);
            btnGenreDatabase.TabIndex = 8;
            btnGenreDatabase.Text = "Database";
            // 
            // btnGenreNetworking
            // 
            btnGenreNetworking.Location = new Point(0, 374);
            btnGenreNetworking.Name = "btnGenreNetworking";
            btnGenreNetworking.Size = new Size(200, 36);
            btnGenreNetworking.TabIndex = 9;
            btnGenreNetworking.Text = "Networking";
            // 
            // btnGenreMath
            // 
            btnGenreMath.Location = new Point(0, 410);
            btnGenreMath.Name = "btnGenreMath";
            btnGenreMath.Size = new Size(200, 36);
            btnGenreMath.TabIndex = 10;
            btnGenreMath.Text = "Mathematics";
            // 
            // btnGenreAI
            // 
            btnGenreAI.Location = new Point(0, 446);
            btnGenreAI.Name = "btnGenreAI";
            btnGenreAI.Size = new Size(200, 36);
            btnGenreAI.TabIndex = 11;
            btnGenreAI.Text = "AI & ML";
            // 
            // btnNavReports
            // 
            btnNavReports.Location = new Point(0, 510);
            btnNavReports.Name = "btnNavReports";
            btnNavReports.Size = new Size(200, 36);
            btnNavReports.TabIndex = 12;
            btnNavReports.Text = "Reports";
            // 
            // btnNavNotifications
            // 
            btnNavNotifications.Location = new Point(0, 546);
            btnNavNotifications.Name = "btnNavNotifications";
            btnNavNotifications.Size = new Size(200, 36);
            btnNavNotifications.TabIndex = 13;
            btnNavNotifications.Text = "Notifications";
            // 
            // btnNavSettings
            // 
            btnNavSettings.Location = new Point(0, 582);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.Size = new Size(200, 36);
            btnNavSettings.TabIndex = 14;
            btnNavSettings.Text = "Settings";
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(14, 624);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(172, 20);
            lblUserName.TabIndex = 15;
            lblUserName.Text = "Karl Gaviola";
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new Font("Segoe UI", 8F);
            lblUserRole.ForeColor = Color.FromArgb(120, 120, 150);
            lblUserRole.Location = new Point(14, 644);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(100, 18);
            lblUserRole.TabIndex = 16;
            lblUserRole.Text = "Librarian";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(247, 247, 246);
            panelMain.Controls.Add(lblPageTitle);
            panelMain.Controls.Add(btnAddBook);
            panelMain.Controls.Add(txtSearch);
            panelMain.Controls.Add(btnFilterAll);
            panelMain.Controls.Add(btnFilterAvailable);
            panelMain.Controls.Add(btnFilterTaken);
            panelMain.Controls.Add(btnFilterLowStock);
            panelMain.Controls.Add(lblResultCount);
            panelMain.Controls.Add(flowBooks);
            panelMain.Controls.Add(pnlDetail);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(783, 660);
            panelMain.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(19, 17, 36);
            lblPageTitle.Location = new Point(19, 24);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(220, 32);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Book Catalog";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(671, 24);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(100, 32);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "+ Add Book";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(19, 68);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by title, author, ISBN...";
            txtSearch.Size = new Size(220, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnFilterAll
            // 
            btnFilterAll.Location = new Point(255, 68);
            btnFilterAll.Name = "btnFilterAll";
            btnFilterAll.Size = new Size(80, 28);
            btnFilterAll.TabIndex = 3;
            btnFilterAll.Text = "All";
            // 
            // btnFilterAvailable
            // 
            btnFilterAvailable.Location = new Point(343, 68);
            btnFilterAvailable.Name = "btnFilterAvailable";
            btnFilterAvailable.Size = new Size(80, 28);
            btnFilterAvailable.TabIndex = 4;
            btnFilterAvailable.Text = "Available";
            // 
            // btnFilterTaken
            // 
            btnFilterTaken.Location = new Point(431, 68);
            btnFilterTaken.Name = "btnFilterTaken";
            btnFilterTaken.Size = new Size(80, 28);
            btnFilterTaken.TabIndex = 5;
            btnFilterTaken.Text = "Taken";
            // 
            // btnFilterLowStock
            // 
            btnFilterLowStock.Location = new Point(519, 68);
            btnFilterLowStock.Name = "btnFilterLowStock";
            btnFilterLowStock.Size = new Size(80, 28);
            btnFilterLowStock.TabIndex = 6;
            btnFilterLowStock.Text = "Low Stock";
            // 
            // lblResultCount
            // 
            lblResultCount.Font = new Font("Segoe UI", 9F);
            lblResultCount.ForeColor = Color.Gray;
            lblResultCount.Location = new Point(19, 110);
            lblResultCount.Name = "lblResultCount";
            lblResultCount.Size = new Size(200, 20);
            lblResultCount.TabIndex = 7;
            lblResultCount.Text = "Showing 1,248 books";
            // 
            // flowBooks
            // 
            flowBooks.AutoScroll = true;
            flowBooks.BackColor = Color.Transparent;
            flowBooks.Location = new Point(19, 134);
            flowBooks.Name = "flowBooks";
            flowBooks.Size = new Size(480, 490);
            flowBooks.TabIndex = 8;
            // 
            // pnlDetail
            // 
            pnlDetail.Controls.Add(lblDetailTitle);
            pnlDetail.Controls.Add(pnlDetailIcon);
            pnlDetail.Controls.Add(lblDetailBookName);
            pnlDetail.Controls.Add(lblDetailAuthor);
            pnlDetail.Controls.Add(lblDetailGenreKey);
            pnlDetail.Controls.Add(lblDetailGenreVal);
            pnlDetail.Controls.Add(lblDetailISBNKey);
            pnlDetail.Controls.Add(lblDetailISBNVal);
            pnlDetail.Controls.Add(lblDetailCopiesKey);
            pnlDetail.Controls.Add(lblDetailCopiesVal);
            pnlDetail.Controls.Add(lblDetailAvailKey);
            pnlDetail.Controls.Add(lblDetailAvailVal);
            pnlDetail.Controls.Add(lblDetailStatusKey);
            pnlDetail.Controls.Add(lblDetailStatusVal);
            pnlDetail.Controls.Add(btnReserve);
            pnlDetail.Controls.Add(btnEdit);
            pnlDetail.Controls.Add(btnDelete);
            pnlDetail.Location = new Point(515, 134);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Size = new Size(256, 490);
            pnlDetail.TabIndex = 9;
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailTitle.ForeColor = Color.FromArgb(19, 17, 36);
            lblDetailTitle.Location = new Point(14, 12);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new Size(228, 22);
            lblDetailTitle.TabIndex = 0;
            lblDetailTitle.Text = "Book details";
            // 
            // pnlDetailIcon
            // 
            pnlDetailIcon.BackColor = Color.FromArgb(230, 245, 233);
            pnlDetailIcon.Controls.Add(lblDetailIconEmoji);
            pnlDetailIcon.Location = new Point(14, 42);
            pnlDetailIcon.Name = "pnlDetailIcon";
            pnlDetailIcon.Size = new Size(228, 76);
            pnlDetailIcon.TabIndex = 1;
            // 
            // lblDetailIconEmoji
            // 
            lblDetailIconEmoji.Dock = DockStyle.Fill;
            lblDetailIconEmoji.Enabled = false;
            lblDetailIconEmoji.Font = new Font("Segoe UI Emoji", 24F);
            lblDetailIconEmoji.Location = new Point(0, 0);
            lblDetailIconEmoji.Name = "lblDetailIconEmoji";
            lblDetailIconEmoji.Size = new Size(228, 76);
            lblDetailIconEmoji.TabIndex = 0;
            lblDetailIconEmoji.Text = "📖";
            lblDetailIconEmoji.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDetailBookName
            // 
            lblDetailBookName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDetailBookName.ForeColor = Color.FromArgb(19, 17, 36);
            lblDetailBookName.Location = new Point(14, 130);
            lblDetailBookName.Name = "lblDetailBookName";
            lblDetailBookName.Size = new Size(228, 24);
            lblDetailBookName.TabIndex = 2;
            lblDetailBookName.Text = "Design Patterns";
            // 
            // lblDetailAuthor
            // 
            lblDetailAuthor.Font = new Font("Segoe UI", 9F);
            lblDetailAuthor.ForeColor = Color.FromArgb(113, 113, 122);
            lblDetailAuthor.Location = new Point(14, 156);
            lblDetailAuthor.Name = "lblDetailAuthor";
            lblDetailAuthor.Size = new Size(228, 20);
            lblDetailAuthor.TabIndex = 3;
            lblDetailAuthor.Text = "Gang of Four";
            // 
            // lblDetailGenreKey
            // 
            lblDetailGenreKey.Font = new Font("Segoe UI", 9F);
            lblDetailGenreKey.ForeColor = Color.FromArgb(120, 120, 140);
            lblDetailGenreKey.Location = new Point(14, 195);
            lblDetailGenreKey.Name = "lblDetailGenreKey";
            lblDetailGenreKey.Size = new Size(96, 20);
            lblDetailGenreKey.TabIndex = 4;
            lblDetailGenreKey.Text = "Genre";
            // 
            // lblDetailGenreVal
            // 
            lblDetailGenreVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDetailGenreVal.ForeColor = Color.FromArgb(30, 30, 50);
            lblDetailGenreVal.Location = new Point(115, 195);
            lblDetailGenreVal.Name = "lblDetailGenreVal";
            lblDetailGenreVal.Size = new Size(127, 20);
            lblDetailGenreVal.TabIndex = 5;
            lblDetailGenreVal.Text = "Programming";
            // 
            // lblDetailISBNKey
            // 
            lblDetailISBNKey.Font = new Font("Segoe UI", 9F);
            lblDetailISBNKey.ForeColor = Color.FromArgb(120, 120, 140);
            lblDetailISBNKey.Location = new Point(14, 223);
            lblDetailISBNKey.Name = "lblDetailISBNKey";
            lblDetailISBNKey.Size = new Size(96, 20);
            lblDetailISBNKey.TabIndex = 6;
            lblDetailISBNKey.Text = "ISBN";
            // 
            // lblDetailISBNVal
            // 
            lblDetailISBNVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDetailISBNVal.ForeColor = Color.FromArgb(30, 30, 50);
            lblDetailISBNVal.Location = new Point(115, 223);
            lblDetailISBNVal.Name = "lblDetailISBNVal";
            lblDetailISBNVal.Size = new Size(127, 20);
            lblDetailISBNVal.TabIndex = 7;
            lblDetailISBNVal.Text = "978-0201633610";
            // 
            // lblDetailCopiesKey
            // 
            lblDetailCopiesKey.Font = new Font("Segoe UI", 9F);
            lblDetailCopiesKey.ForeColor = Color.FromArgb(120, 120, 140);
            lblDetailCopiesKey.Location = new Point(14, 251);
            lblDetailCopiesKey.Name = "lblDetailCopiesKey";
            lblDetailCopiesKey.Size = new Size(96, 20);
            lblDetailCopiesKey.TabIndex = 8;
            lblDetailCopiesKey.Text = "Total copies";
            // 
            // lblDetailCopiesVal
            // 
            lblDetailCopiesVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDetailCopiesVal.ForeColor = Color.FromArgb(30, 30, 50);
            lblDetailCopiesVal.Location = new Point(115, 251);
            lblDetailCopiesVal.Name = "lblDetailCopiesVal";
            lblDetailCopiesVal.Size = new Size(127, 20);
            lblDetailCopiesVal.TabIndex = 9;
            lblDetailCopiesVal.Text = "4";
            // 
            // lblDetailAvailKey
            // 
            lblDetailAvailKey.Font = new Font("Segoe UI", 9F);
            lblDetailAvailKey.ForeColor = Color.FromArgb(120, 120, 140);
            lblDetailAvailKey.Location = new Point(14, 279);
            lblDetailAvailKey.Name = "lblDetailAvailKey";
            lblDetailAvailKey.Size = new Size(96, 20);
            lblDetailAvailKey.TabIndex = 10;
            lblDetailAvailKey.Text = "Available";
            // 
            // lblDetailAvailVal
            // 
            lblDetailAvailVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDetailAvailVal.ForeColor = Color.FromArgb(30, 30, 50);
            lblDetailAvailVal.Location = new Point(115, 279);
            lblDetailAvailVal.Name = "lblDetailAvailVal";
            lblDetailAvailVal.Size = new Size(127, 20);
            lblDetailAvailVal.TabIndex = 11;
            lblDetailAvailVal.Text = "2 copies";
            // 
            // lblDetailStatusKey
            // 
            lblDetailStatusKey.Font = new Font("Segoe UI", 9F);
            lblDetailStatusKey.ForeColor = Color.FromArgb(120, 120, 140);
            lblDetailStatusKey.Location = new Point(14, 307);
            lblDetailStatusKey.Name = "lblDetailStatusKey";
            lblDetailStatusKey.Size = new Size(96, 20);
            lblDetailStatusKey.TabIndex = 12;
            lblDetailStatusKey.Text = "Status";
            // 
            // lblDetailStatusVal
            // 
            lblDetailStatusVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDetailStatusVal.ForeColor = Color.FromArgb(30, 30, 50);
            lblDetailStatusVal.Location = new Point(115, 307);
            lblDetailStatusVal.Name = "lblDetailStatusVal";
            lblDetailStatusVal.Size = new Size(127, 20);
            lblDetailStatusVal.TabIndex = 13;
            lblDetailStatusVal.Text = "Available";
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(14, 350);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(228, 38);
            btnReserve.TabIndex = 14;
            btnReserve.Text = "Reserve this book";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(14, 398);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 32);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(134, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 32);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            // 
            // BookCatalog
            // 
            BackColor = Color.FromArgb(245, 245, 248);
            ClientSize = new Size(983, 660);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BookCatalog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library System — Book Catalog";
            panelSidebar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            pnlDetail.ResumeLayout(false);
            pnlDetailIcon.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel     panelSidebar;
        private System.Windows.Forms.Label     lblLogoText;
        private System.Windows.Forms.Button    btnNavDashboard;
        private System.Windows.Forms.Button    btnNavCatalog;
        private System.Windows.Forms.Button    btnNavReservations;
        private System.Windows.Forms.Button    btnNavMembers;
        private System.Windows.Forms.Button    btnNavReports;
        private System.Windows.Forms.Button    btnNavNotifications;
        private System.Windows.Forms.Button    btnNavSettings;
        private System.Windows.Forms.Label     lblSidebarGenre;
        private System.Windows.Forms.Button    btnGenreAll;
        private System.Windows.Forms.Button    btnGenreProgramming;
        private System.Windows.Forms.Button    btnGenreDatabase;
        private System.Windows.Forms.Button    btnGenreNetworking;
        private System.Windows.Forms.Button    btnGenreMath;
        private System.Windows.Forms.Button    btnGenreAI;
        private System.Windows.Forms.Label     lblUserName;
        private System.Windows.Forms.Label     lblUserRole;
        private System.Windows.Forms.Panel     panelMain;
        private System.Windows.Forms.Label     lblPageTitle;
        private System.Windows.Forms.Button    btnAddBook;
        private System.Windows.Forms.TextBox   txtSearch;
        private System.Windows.Forms.Button    btnFilterAll;
        private System.Windows.Forms.Button    btnFilterAvailable;
        private System.Windows.Forms.Button    btnFilterTaken;
        private System.Windows.Forms.Button    btnFilterLowStock;
        private System.Windows.Forms.Label     lblResultCount;
        private System.Windows.Forms.FlowLayoutPanel flowBooks;
        private System.Windows.Forms.Panel     pnlDetailIcon;
        private System.Windows.Forms.Label     lblDetailIconEmoji;
        private System.Windows.Forms.Panel     pnlDetail;
        private System.Windows.Forms.Label     lblDetailTitle;
        private System.Windows.Forms.Label     lblDetailBookName;
        private System.Windows.Forms.Label     lblDetailAuthor;
        private System.Windows.Forms.Label     lblDetailGenreKey;
        private System.Windows.Forms.Label     lblDetailGenreVal;
        private System.Windows.Forms.Label     lblDetailISBNKey;
        private System.Windows.Forms.Label     lblDetailISBNVal;
        private System.Windows.Forms.Label     lblDetailCopiesKey;
        private System.Windows.Forms.Label     lblDetailCopiesVal;
        private System.Windows.Forms.Label     lblDetailAvailKey;
        private System.Windows.Forms.Label     lblDetailAvailVal;
        private System.Windows.Forms.Label     lblDetailStatusKey;
        private System.Windows.Forms.Label     lblDetailStatusVal;
        private System.Windows.Forms.Button    btnReserve;
        private System.Windows.Forms.Button    btnEdit;
        private System.Windows.Forms.Button    btnDelete;
    }
}
