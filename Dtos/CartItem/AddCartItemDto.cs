using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Dtos.CartItem
{
    public class AddCartItemDto
    {
        public int Cart_Id { get; set; }
        public int Product_Id { get; set; }
        public int Order_Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Quantity { get; set; } = 0;
        public double Price { get; set; } = 0;
    }
}