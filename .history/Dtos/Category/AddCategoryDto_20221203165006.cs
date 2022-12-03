using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Dtos.Category
{
    public class AddCategoryDto
    {
        public int Product_Id { get; set; }
        public int Category_Name { get; set; }
    }
}