namespace winForm_book_librarySystem
{
    partial class LoginForm
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pnlLogoIcon = new System.Windows.Forms.Panel();
            this.lblLogoIcon = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.pnlFeatIcon1 = new System.Windows.Forms.Panel();
            this.lblFeatIcon1 = new System.Windows.Forms.Label();
            this.lblFeature1 = new System.Windows.Forms.Label();
            this.pnlFeatIcon2 = new System.Windows.Forms.Panel();
            this.lblFeatIcon2 = new System.Windows.Forms.Label();
            this.lblFeature2 = new System.Windows.Forms.Label();
            this.pnlFeatIcon3 = new System.Windows.Forms.Panel();
            this.lblFeatIcon3 = new System.Windows.Forms.Label();
            this.lblFeature3 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcomeSub = new System.Windows.Forms.Label();
            this.lblSignInAs = new System.Windows.Forms.Label();
            this.pnlRoleSelect = new System.Windows.Forms.Panel();
            this.btnRoleStudent = new System.Windows.Forms.Button();
            this.btnRoleLibrarian = new System.Windows.Forms.Button();
            this.btnRoleAdmin = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.panelLeft.SuspendLayout();
            this.pnlLogoIcon.SuspendLayout();
            this.pnlFeatIcon1.SuspendLayout();
            this.pnlFeatIcon2.SuspendLayout();
            this.pnlFeatIcon3.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.pnlRoleSelect.SuspendLayout();
            this.SuspendLayout();

            // ── Set Control Names for Theme Engine ────────────────────────────
            this.panelLeft.Name = "panelLeft";
            this.pnlLogoIcon.Name = "pnlLogoIcon";
            this.lblLogoIcon.Name = "lblLogoIcon";
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.pnlFeatIcon1.Name = "pnlFeatIcon1";
            this.lblFeatIcon1.Name = "lblFeatIcon1";
            this.lblFeature1.Name = "lblFeature1";
            this.pnlFeatIcon2.Name = "pnlFeatIcon2";
            this.lblFeatIcon2.Name = "lblFeatIcon2";
            this.lblFeature2.Name = "lblFeature2";
            this.pnlFeatIcon3.Name = "pnlFeatIcon3";
            this.lblFeatIcon3.Name = "lblFeatIcon3";
            this.lblFeature3.Name = "lblFeature3";
            this.panelRight.Name = "panelRight";
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcomeSub.Name = "lblWelcomeSub";
            this.lblSignInAs.Name = "lblSignInAs";
            this.pnlRoleSelect.Name = "pnlRoleSelect";
            this.btnRoleStudent.Name = "btnRoleStudent";
            this.btnRoleLibrarian.Name = "btnRoleLibrarian";
            this.btnRoleAdmin.Name = "btnRoleAdmin";
            this.lblEmail.Name = "lblEmail";
            this.txtEmail.Name = "txtEmail";
            this.lblPassword.Name = "lblPassword";
            this.txtPassword.Name = "txtPassword";
            this.btnLogin.Name = "btnLogin";
            this.lnkForgot.Name = "lnkForgot";

            // ── Form ──────────────────────────────────────────────────────────
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Text = "Enhanced Library Book Reservation System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 248);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // ── panelLeft (Dark Navy Sidebar) ──────────────────────────────────
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 280;
            this.panelLeft.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlLogoIcon, this.lblAppTitle, this.lblAppSubtitle,
                this.pnlFeatIcon1, this.lblFeature1,
                this.pnlFeatIcon2, this.lblFeature2,
                this.pnlFeatIcon3, this.lblFeature3 });

            // Logo Icon Container
            this.pnlLogoIcon.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.pnlLogoIcon.Location = new System.Drawing.Point(30, 30);
            this.pnlLogoIcon.Size = new System.Drawing.Size(48, 48);
            this.pnlLogoIcon.Controls.Add(this.lblLogoIcon);

            this.lblLogoIcon.Text = "📖";
            this.lblLogoIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 18F);
            this.lblLogoIcon.ForeColor = System.Drawing.Color.FromArgb(26, 26, 46);
            this.lblLogoIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogoIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblAppTitle.Text = "Enhanced Library\nBook Reservation\nSystem";
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.Location = new System.Drawing.Point(30, 95);
            this.lblAppTitle.Size = new System.Drawing.Size(220, 85);
            this.lblAppTitle.AutoSize = false;

            this.lblAppSubtitle.Text = "University of Cebu — CCS Library";
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(113, 113, 122);
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAppSubtitle.Location = new System.Drawing.Point(30, 440);
            this.lblAppSubtitle.Size = new System.Drawing.Size(220, 20);

            // Feature 1: Search & Reserve
            this.pnlFeatIcon1.BackColor = Color.FromArgb(28, 25, 48);
            this.pnlFeatIcon1.Location = new System.Drawing.Point(30, 215);
            this.pnlFeatIcon1.Size = new System.Drawing.Size(32, 32);
            this.pnlFeatIcon1.Controls.Add(this.lblFeatIcon1);

            this.lblFeatIcon1.Text = "🔍";
            this.lblFeatIcon1.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.lblFeatIcon1.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblFeatIcon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFeatIcon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblFeature1.Text = "Search and reserve\nbooks anytime";
            this.lblFeature1.ForeColor = System.Drawing.Color.FromArgb(160, 160, 190);
            this.lblFeature1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFeature1.Location = new System.Drawing.Point(74, 213);
            this.lblFeature1.Size = new System.Drawing.Size(185, 36);

            // Feature 2: Get notified
            this.pnlFeatIcon2.BackColor = Color.FromArgb(28, 25, 48);
            this.pnlFeatIcon2.Location = new System.Drawing.Point(30, 275);
            this.pnlFeatIcon2.Size = new System.Drawing.Size(32, 32);
            this.pnlFeatIcon2.Controls.Add(this.lblFeatIcon2);

            this.lblFeatIcon2.Text = "🔔";
            this.lblFeatIcon2.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.lblFeatIcon2.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblFeatIcon2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFeatIcon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblFeature2.Text = "Get notified on\navailability";
            this.lblFeature2.ForeColor = System.Drawing.Color.FromArgb(160, 160, 190);
            this.lblFeature2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFeature2.Location = new System.Drawing.Point(74, 273);
            this.lblFeature2.Size = new System.Drawing.Size(185, 36);

            // Feature 3: Real-time analytics
            this.pnlFeatIcon3.BackColor = Color.FromArgb(28, 25, 48);
            this.pnlFeatIcon3.Location = new System.Drawing.Point(30, 335);
            this.pnlFeatIcon3.Size = new System.Drawing.Size(32, 32);
            this.pnlFeatIcon3.Controls.Add(this.lblFeatIcon3);

            this.lblFeatIcon3.Text = "📊";
            this.lblFeatIcon3.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.lblFeatIcon3.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblFeatIcon3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFeatIcon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblFeature3.Text = "Real-time analytics\nand reports";
            this.lblFeature3.ForeColor = System.Drawing.Color.FromArgb(160, 160, 190);
            this.lblFeature3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFeature3.Location = new System.Drawing.Point(74, 333);
            this.lblFeature3.Size = new System.Drawing.Size(185, 36);


            // ── panelRight (Creamy White Form Area) ──────────────────────────
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(245, 245, 248);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblWelcome, this.lblWelcomeSub, this.lblSignInAs,
                this.pnlRoleSelect, this.lblEmail, this.txtEmail,
                this.lblPassword, this.txtPassword, this.btnLogin, this.lnkForgot });

            int lx = 55; // left offset inside panelRight

            this.lblWelcome.Text = "Welcome back";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.lblWelcome.Location = new System.Drawing.Point(lx, 44);
            this.lblWelcome.Size = new System.Drawing.Size(300, 36);

            this.lblWelcomeSub.Text = "Sign in to your account to continue";
            this.lblWelcomeSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblWelcomeSub.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblWelcomeSub.Location = new System.Drawing.Point(lx, 83);
            this.lblWelcomeSub.Size = new System.Drawing.Size(360, 20);

            this.lblSignInAs.Text = "Sign in as";
            this.lblSignInAs.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSignInAs.ForeColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.lblSignInAs.Location = new System.Drawing.Point(lx, 120);
            this.lblSignInAs.Size = new System.Drawing.Size(80, 20);

            // Role selector panel
            this.pnlRoleSelect.Location = new System.Drawing.Point(lx, 143);
            this.pnlRoleSelect.Size = new System.Drawing.Size(360, 38);
            this.pnlRoleSelect.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoleSelect.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnRoleStudent, this.btnRoleLibrarian, this.btnRoleAdmin });

            this.btnRoleStudent.Text = "🎓  Student";
            this.btnRoleStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRoleStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleStudent.Location = new System.Drawing.Point(0, 0);
            this.btnRoleStudent.Size = new System.Drawing.Size(112, 36);
            this.btnRoleStudent.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnRoleLibrarian.Text = "📚  Librarian";
            this.btnRoleLibrarian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRoleLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleLibrarian.Location = new System.Drawing.Point(120, 0);
            this.btnRoleLibrarian.Size = new System.Drawing.Size(112, 36);
            this.btnRoleLibrarian.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnRoleAdmin.Text = "🛡️  Admin";
            this.btnRoleAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRoleAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleAdmin.Location = new System.Drawing.Point(240, 0);
            this.btnRoleAdmin.Size = new System.Drawing.Size(112, 36);
            this.btnRoleAdmin.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblEmail.Text = "Email address";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.lblEmail.Location = new System.Drawing.Point(lx, 196);
            this.lblEmail.Size = new System.Drawing.Size(120, 20);

            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(lx, 218);
            this.txtEmail.Size = new System.Drawing.Size(360, 28);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.PlaceholderText = "you@ucebu.edu.ph";

            this.lblPassword.Text = "Password";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.lblPassword.Location = new System.Drawing.Point(lx, 263);
            this.lblPassword.Size = new System.Drawing.Size(80, 20);

            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Location = new System.Drawing.Point(lx, 285);
            this.txtPassword.Size = new System.Drawing.Size(360, 28);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.PlaceholderText = "Enter your password";

            this.btnLogin.Text = "Sign in to library";
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(lx, 334);
            this.btnLogin.Size = new System.Drawing.Size(360, 42);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lnkForgot.Text = "Forgot your password? Reset it";
            this.lnkForgot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkForgot.LinkColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lnkForgot.ActiveLinkColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lnkForgot.VisitedLinkColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lnkForgot.Location = new System.Drawing.Point(lx + 60, 390);
            this.lnkForgot.Size = new System.Drawing.Size(240, 20);
            this.lnkForgot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.panelLeft.ResumeLayout(false);
            this.pnlLogoIcon.ResumeLayout(false);
            this.pnlFeatIcon1.ResumeLayout(false);
            this.pnlFeatIcon2.ResumeLayout(false);
            this.pnlFeatIcon3.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.pnlRoleSelect.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel pnlLogoIcon;
        private System.Windows.Forms.Label lblLogoIcon;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Panel pnlFeatIcon1;
        private System.Windows.Forms.Label lblFeatIcon1;
        private System.Windows.Forms.Label lblFeature1;
        private System.Windows.Forms.Panel pnlFeatIcon2;
        private System.Windows.Forms.Label lblFeatIcon2;
        private System.Windows.Forms.Label lblFeature2;
        private System.Windows.Forms.Panel pnlFeatIcon3;
        private System.Windows.Forms.Label lblFeatIcon3;
        private System.Windows.Forms.Label lblFeature3;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcomeSub;
        private System.Windows.Forms.Label lblSignInAs;
        private System.Windows.Forms.Panel pnlRoleSelect;
        private System.Windows.Forms.Button btnRoleStudent;
        private System.Windows.Forms.Button btnRoleLibrarian;
        private System.Windows.Forms.Button btnRoleAdmin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkForgot;
    }
}
