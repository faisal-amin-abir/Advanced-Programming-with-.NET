using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15)]

        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
