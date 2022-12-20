using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dtos.User
{
    public class UserRegisterDto
    {
        [Required,MinLength(2, ErrorMessage ="Please enter at least 2 characters")]
        public string First_Name { get; set; } = String.Empty;
        [Required,MinLength(2, ErrorMessage ="Please enter at least 2 characters")]
        public string Last_Name { get; set; } = String.Empty;
        [Required,EmailAddress]
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        
    }
}