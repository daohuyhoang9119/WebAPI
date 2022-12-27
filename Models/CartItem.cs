using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Quantity { get; set; } = 0;
        public double Price { get; set; } = 0;
        public string? Image_Url { get; set; }
        public int Product_Id {get;set;}
        public Product? product { get; set; }
        public int Cart_Id { get; set; }
        public Cart? cart { get; set; }
        
    }
}