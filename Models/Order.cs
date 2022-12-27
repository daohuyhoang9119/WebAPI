using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.CartItem;
using WebAPI.Enums;

namespace WebAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public User User { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public DateTime Updated_At { get; set; }
        public double Total_Amount { get; set; }
        public virtual ICollection<CartItem> Order_Products { get; set; } = new List<CartItem>();
        
    }
}