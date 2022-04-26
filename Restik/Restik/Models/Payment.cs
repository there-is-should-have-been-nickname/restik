using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restik.Models
{
    public class Payment
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int Price { get; set; }
        public int NumberPlace { get; set; }
        public bool IsPaid { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
