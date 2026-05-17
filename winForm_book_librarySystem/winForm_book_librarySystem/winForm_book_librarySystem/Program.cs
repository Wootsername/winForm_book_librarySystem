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
                // Auto-setup database, seed default users and dummy books
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

                    if (!context.Books.Any())
                    {
                        context.Books.AddRange(
                            new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Classic", TotalCopies = 5, AvailableCopies = 5 },
                            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic", TotalCopies = 3, AvailableCopies = 3 },
                            new Book { Title = "1984", Author = "George Orwell", Genre = "Dystopian", TotalCopies = 8, AvailableCopies = 8 },
                            new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", TotalCopies = 4, AvailableCopies = 4 },
                            new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Classic", TotalCopies = 6, AvailableCopies = 6 }
                        );
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(new LoginForm());
        }
    }
}
