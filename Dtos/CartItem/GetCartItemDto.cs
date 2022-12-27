using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Dtos.CartItem
{
    public class GetCartItemDto
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public double Price { get; set; } = 0;
        public string? Image_Url { get; set; }
        public int Quantity { get; set; } = 0;
        public int Cart_Id { get; set; }
    }
}