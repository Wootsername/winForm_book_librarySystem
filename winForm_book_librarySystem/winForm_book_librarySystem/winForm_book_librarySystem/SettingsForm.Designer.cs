using System;

namespace winForm_book_librarySystem
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkNotifications;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelCard = new Panel();
            lblName = new Label();
            txtDisplayName = new TextBox();
            lblPass = new Label();
            txtPassword = new TextBox();
            chkNotifications = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            panelCard.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(40, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Settings";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Location = new Point(40, 58);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(470, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Configure your library profile, credentials, and notifications alerts.";
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // panelCard
            // 
            panelCard.Controls.Add(lblName);
            panelCard.Controls.Add(txtDisplayName);
            panelCard.Controls.Add(lblPass);
            panelCard.Controls.Add(txtPassword);
            panelCard.Controls.Add(chkNotifications);
            panelCard.Controls.Add(btnSave);
            panelCard.Controls.Add(btnCancel);
            panelCard.Location = new Point(40, 92);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(470, 340);
            panelCard.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Location = new Point(30, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(410, 18);
            lblName.TabIndex = 0;
            lblName.Text = "FULL DISPLAY NAME";
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(30, 48);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(410, 23);
            txtDisplayName.TabIndex = 1;
            // 
            // lblPass
            // 
            lblPass.Location = new Point(30, 95);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(410, 18);
            lblPass.TabIndex = 2;
            lblPass.Text = "NEW PASSWORD (LEAVE BLANK TO KEEP UNCHANGED)";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(410, 23);
            txtPassword.TabIndex = 3;
            // 
            // chkNotifications
            // 
            chkNotifications.Checked = true;
            chkNotifications.CheckState = CheckState.Checked;
            chkNotifications.Location = new Point(30, 175);
            chkNotifications.Name = "chkNotifications";
            chkNotifications.Size = new Size(410, 40);
            chkNotifications.TabIndex = 4;
            chkNotifications.Text = "Enable Email notifications for upcoming reservations & overdue warnings";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(280, 265);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Changes";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(110, 265);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            // 
            // SettingsForm
            // 
            ClientSize = new Size(550, 480);
            Controls.Add(panelCard);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Settings — Library System";
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ResumeLayout(false);
        }
    }
}
