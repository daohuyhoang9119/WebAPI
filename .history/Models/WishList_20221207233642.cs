using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class WishList
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Product_Id { get; set; }
        public DateTime Created_Time { get; set; }
    }
}