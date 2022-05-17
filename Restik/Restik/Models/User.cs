using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restik.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(25)]
        public string Type { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        [MaxLength(100)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Mail { get; set; }
        [MaxLength(64)]
        public string Password { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
