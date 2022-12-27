using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Dtos.OrderItem
{
    public class GetOrderItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Quantity { get; set; } = 0;
        public double Price { get; set; } = 0;
        public string? Image_Url { get; set; }
        public int Product_Id {get;set;}
        public int Order_Id { get; set; }
    }
}