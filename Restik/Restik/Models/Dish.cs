using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restik.Models
{
    public class Dish
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string ImagePath { get; set; }
        public int CuisineId { get; set; }
        public Cuisine Cuisine { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
