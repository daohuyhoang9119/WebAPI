using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ServiceResponseLogin<T>
    {
        public User? Data { get; set; }
        // tokenUser
        public string tokenUser { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        
    }
}