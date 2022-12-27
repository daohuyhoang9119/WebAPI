using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.CartItem;

namespace WebAPI.Services.CartService
{
    public interface ICartService
    {
        Task<ServiceResponse<List<GetCartItemDto>>> GetCart();
        // Task<int> GetCart(int user_id);
        Task<ServiceResponse<AddCartItemDto>> AddCartItem(int productId, int quantity);
        Task<ServiceResponse<GetCartItemDto>> RemoveCartItem(int productId, int quantity);
    }
}