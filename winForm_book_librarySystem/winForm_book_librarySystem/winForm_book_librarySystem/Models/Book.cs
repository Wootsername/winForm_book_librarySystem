using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace winForm_book_librarySystem.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Author { get; set; }

        [MaxLength(50)]
        public string Genre { get; set; }

        public int TotalCopies { get; set; }

        public int AvailableCopies { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
