using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Enums;

namespace WebAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public OrderStatus Status { get; set; }
        public virtual ICollection<CartItem> Order_Products { get; set; } = new List<CartItem>();
        
    }
}