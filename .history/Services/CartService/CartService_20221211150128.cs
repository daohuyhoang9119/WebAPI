using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace WebAPI.Services.CartService
{
    public class CartService : ICartService
    {
        private static List<CartItem> category = new List<CartItem>{
            new CartItem(),
            new CartItem{Id = 1, Name = "Ip11"},
            new CartItem{Id = 2, Name = "Ip12"},
            new CartItem{Id = 3, Name = "Samsung Galaxy"},
            new CartItem{Id = 4, Name = "Samsung Galaxy 1"},
        };

        private readonly IMapper _mapper;

      
        public CartService(IMapper mapper)
        {
            _mapper = mapper;
        }

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