using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Enums;

namespace WebAPI.Models
{
    public class Order
    {
        public int Id { get; set; } = 0;
        public int User_Id { get; set; }
        public User User { get; set; }
        public String Status { get; set; } = "Pending";
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public double Total_Amount { get; set; }
        public virtual ICollection<CartItem> Order_Products { get; set; } = new List<CartItem>();
        
    }
}