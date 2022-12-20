using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Dtos.CartItem;

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
        private readonly DataContext _context;
      
        public CartService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<CartItem>>> AddCartItem(int productId)
        {
            var serviceRespone = new  ServiceResponse<List<CartItem>>();
            var product = await _context.Product.FirstAsync(c => c.Id == productId);
            var newCartItem = new CartItem();
            newCartItem.Name = product.Title;
            newCartItem.Quantity = 1;
            newCartItem.Price = product.Price;
            _context.CartItem.Add(newCartItem);
            await _context.SaveChangesAsync();
            var listCart = _context.Cart.Where(cart => cart.Id == newCartItem.Cart_Id);

            //  _context.Cart.Add(cartItem);
            // serviceRespone.Data = await _context.Product
            //     .Select(c => _mapper.Map<GetProductDto>(c))
            //     .ToListAsync();
            return serviceRespone;
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