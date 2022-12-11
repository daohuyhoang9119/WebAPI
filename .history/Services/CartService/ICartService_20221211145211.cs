using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.CartService
{
    public interface ICartService
    {
        Task<ServiceResponse<List<CartItem>>> GetCartList();
    }
}