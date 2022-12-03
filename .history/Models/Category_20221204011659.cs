using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public int Category_Name { get; set; }
    }
}