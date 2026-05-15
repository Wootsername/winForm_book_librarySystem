using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Auto-setup database and seed default users
                using (var context = new LibraryContext())
                {
                    context.Database.Migrate();

                    if (!context.Users.Any(u => u.Role == "Admin"))
                    {
                        context.Users.Add(new User { FullName = "System Admin", Email = "admin@library.com", Password = "admin", Role = "Admin" });
                    }
                    if (!context.Users.Any(u => u.Role == "Librarian"))
                    {
                        context.Users.Add(new User { FullName = "Head Librarian", Email = "lib@library.com", Password = "lib", Role = "Librarian" });
                    }
                    if (!context.Users.Any(u => u.Role == "Student"))
                    {
                        context.Users.Add(new User { FullName = "John Doe", Email = "student@library.com", Password = "student", Role = "Student" });
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(new Form1());
        }
    }
}
