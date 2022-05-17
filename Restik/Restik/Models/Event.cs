using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restik.Models
{
    public class Event
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Type { get; set; }
        List<Booking> Bookings { get; set; }
    }
}
