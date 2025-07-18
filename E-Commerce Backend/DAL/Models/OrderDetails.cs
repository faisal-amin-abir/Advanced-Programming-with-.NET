﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
