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
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
        public int PlaceId { get; set; }
        public Place Place { get; set; }
        public int? EventId { get; set; }
        public Event Event { get; set; }
        public int? CuisineId { get; set; }
        public Cuisine Cuisine { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
