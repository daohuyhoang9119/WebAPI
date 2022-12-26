using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.CartItem;

namespace WebAPI.Dtos.Cart
{
    public class GetCartDto
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public List<GetCartItemDto> CartItems { get; set; }
    }
}