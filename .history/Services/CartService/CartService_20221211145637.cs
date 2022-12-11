using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.CartService
{
    public class CartService : ICartService
    {
        public Task<ServiceResponse<List<CartItem>>> AddCartItem(CartItem newCartItem)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<CartItem>>> DeleteCartItem(int cartItem_id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<CartItem>>> GetCartList()
        {
            throw new NotImplementedException();
        }
    }
}