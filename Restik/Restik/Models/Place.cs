using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restik.Models
{
    public class Place
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public bool IsOrdered { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
    }
}
