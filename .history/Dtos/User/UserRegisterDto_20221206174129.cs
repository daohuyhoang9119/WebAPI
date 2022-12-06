using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Dtos.User
{
    public class UserRegisterDto
    {
        public string First_Name { get; set; } = String.Empty;
        public string Last_Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        
    }
}