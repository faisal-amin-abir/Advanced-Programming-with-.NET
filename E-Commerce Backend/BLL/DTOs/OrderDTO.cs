using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        [Required]
        //[ForeignKey("User")]
        public int CustomerId { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
