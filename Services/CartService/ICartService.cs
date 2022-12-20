using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.CartItem;

namespace WebAPI.Services.CartService
{
    public interface ICartService
    {
        Task<ServiceResponse<List<CartItem>>> GetCartList();
        Task<ServiceResponse<List<CartItem>>> AddCartItem(int productId);
        Task<ServiceResponse<List<CartItem>>> DeleteCartItem(int cartItem_id);
    }
}