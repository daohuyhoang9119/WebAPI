using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        // public int Product_Id { get; set; }
        public string Category_Name { get; set; } = "IOS";
        public ICollection<Product> Products { get; set; }
    }
}