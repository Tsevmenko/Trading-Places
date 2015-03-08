using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Current password is requied field")]
        public string Password { get; set; }
        public int IdType { get; set; }
    }
}