using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace WebAPI.Services.CartService
{
    public class CartService : ICartService
    {
        private static List<CartItem> cart = new List<CartItem>{
            new CartItem(),
            new CartItem{Id = 1, Name = "Ip11"},
            new CartItem{Id = 2, Name = "Ip12"},
            new CartItem{Id = 3, Name = "Samsung Galaxy"},
            new CartItem{Id = 4, Name = "Samsung Galaxy s21"},
        };

        private readonly IMapper _mapper;

      
        public CartService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<ServiceResponse<List<CartItem>>> AddCartItem(CartItem newCartItem)
        {
            // var serviceRespone = new  ServiceResponse<List<CartItem>>();
            // cart.Add(_mapper.Map<Cartegory>(newCartItem));
            // serviceRespone.Data = category.Select(c => _mapper.Map<GetCategoryDto>(c)).ToList();
            // return serviceRespone;
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