using System;
using System.Linq;
using System.Windows.Forms;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class NotificationsForm : Form
    {
        public NotificationsForm()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    int userId = Session.CurrentUserId;
                    var notifications = context.Notifications
                        .Where(n => n.UserID == userId)
                        .OrderByDescending(n => n.DateSent)
                        .ToList();

                    dgvNotifications.DataSource = notifications.Select(n => new {
                        n.DateSent,
                        n.Message,
                        n.IsRead
                    }).ToList();

                    // Mark all as read
                    var unread = notifications.Where(n => !n.IsRead).ToList();
                    foreach (var n in unread)
                    {
                        n.IsRead = true;
                    }
                    if (unread.Any())
                    {
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notifications: " + ex.Message);
            }
        }
    }
}
