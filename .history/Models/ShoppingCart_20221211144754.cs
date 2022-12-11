using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public virtual ICollection<CartItem> ShoppingCartList { get; set; } = new List<CartItem>();
    }
}