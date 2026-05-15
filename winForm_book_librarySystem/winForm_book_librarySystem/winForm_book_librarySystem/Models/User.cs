using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace winForm_book_librarySystem.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        [Required]
        [MaxLength(20)]
        public string Role { get; set; } // "Student", "Librarian", "Admin"

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
