using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace winForm_book_librarySystem.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        [Required]
        public int UserID { get; set; }
        
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        [Required]
        public int BookID { get; set; }
        
        [ForeignKey("BookID")]
        public virtual Book Book { get; set; }

        [Required]
        public DateTime ReservedDate { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } // "Pending", "Approved", "Returned", "Cancelled"
    }
}
