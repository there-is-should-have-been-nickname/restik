using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restik.Models
{
    public class Cuisine
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(800)]
        public string Description { get; set; }
    }
}
