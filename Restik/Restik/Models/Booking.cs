using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restik.Models
{
    public class Booking
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Number { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int NumberPlaces { get; set; }
        public int? EventId { get; set; }
        public Event? Event { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
