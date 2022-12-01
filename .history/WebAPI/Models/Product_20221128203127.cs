using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int Rating_Average { get; set; }
        public string Description { get; set; }
        public string Brand_Name { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}