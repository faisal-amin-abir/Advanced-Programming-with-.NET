using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public int CustomerId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public virtual User User { get; set; }
    }
}
