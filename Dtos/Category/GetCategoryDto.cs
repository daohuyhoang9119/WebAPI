using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Dtos.Category
{
    public class GetCategoryDto
    {
        public int Id { get; set; }
        public string Category_Name { get; set; } = "hii";
    }
}