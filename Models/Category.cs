using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        // public int Product_Id { get; set; }
        [Required]
        [MinLength(5), MaxLength(500)]
        public string Category_Name { get; set; } = "IOS";
        public ICollection<Product> Products { get; set; }
    }
}