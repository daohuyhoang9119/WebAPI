using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Quantity { get; set; } = 0;
        public double Price { get; set; } = 0;
        public string? Image_Url { get; set; }
        public int Product_Id {get;set;}
        public Product? product { get; set; }
        public int Order_Id { get; set; }
        public Order? order { get; set; }
    }
}