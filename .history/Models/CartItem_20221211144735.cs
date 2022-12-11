using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public int ShoppingCart_Id { get; set; }
        public int Order_Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; } = 0;
        public double Price { get; set; } = 0;
        public DateTime Create_At { get; set; }
        public DateTime Update_At { get; set; }
        
    }
}