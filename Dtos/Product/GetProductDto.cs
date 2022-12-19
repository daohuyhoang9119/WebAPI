using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Dtos.Product
{
    public class GetProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = "Iphone";
        public int Price { get; set; } = 22000;
        public int Category_Id { get; set; }
        public int Discount { get; set; } = 10;
        public int Rating_Average { get; set; } = 5;
        public string Description { get; set; } = "Best option for u guy";
        public string Brand_Name { get; set; } = "Apple";
        public string ImageUrl_1 { get; set; } = String.Empty;
        public string ImageUrl_2 { get; set; } = String.Empty;
        public string ImageUrl_3 { get; set; } = String.Empty;
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}