using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Cart
    {
        public int Id { get; set; } //PK
        public double Total_Amount { get; set; }
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public DateTime Updated_At { get; set; } = DateTime.UtcNow;
        
        public User User { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}