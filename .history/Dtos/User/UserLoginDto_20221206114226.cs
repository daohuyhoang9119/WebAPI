using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Dtos.User
{
    public class UserLoginDto
    {
        public string UserEmail { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
}