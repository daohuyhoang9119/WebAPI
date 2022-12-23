using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Dtos.CartItem;

namespace WebAPI.Services.CartService
{
    public class CartService : ICartService
    {
        // private static List<CartItem> cart = new List<CartItem>{
        //     new CartItem(),
        //     new CartItem{Id = 1, Name = "Ip11"},
        //     new CartItem{Id = 2, Name = "Ip12"},
        //     new CartItem{Id = 3, Name = "Samsung Galaxy"},
        //     new CartItem{Id = 4, Name = "Samsung Galaxy s21"},
        // };

        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
      
        public CartService(IMapper mapper, DataContext context,IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ServiceResponse<List<CartItem>>> AddCartItem(int productId)
        {
            var serviceRespone = new  ServiceResponse<List<CartItem>>();
            var product = await _context.Product.FirstAsync(c => c.Id == productId);
            // int card_Id = await GetCart(GetUserId());

            //Create a new cartItem
            var newCartItem = new CartItem();
            // newCartItem.Cart_Id = card_Id;
            newCartItem.Name = product.Title;
            newCartItem.Quantity = 1;
            newCartItem.Price = product.Price;
            _context.CartItem.Add(newCartItem);
            await _context.SaveChangesAsync();

            serviceRespone.Data= await _context.CartItem.Where(item => item.Id == newCartItem.Cart_Id).ToListAsync();
            // tao cai cart
            var cart = new Cart();
            cart.Total_Amount = 0;

            return serviceRespone;
        }

        public Task<ServiceResponse<List<CartItem>>> DeleteCartItem(int cartItem_id)
        {
            throw new NotImplementedException();
        }

        
        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User
                    .FindFirstValue(ClaimTypes.NameIdentifier));

        // private async Task<int> GetCart(int user_id)
        // {
        //     Cart cart = await  _context.Cart.FirstOrDefaultAsync(x => x.User_Id == user_id);
        //     if (cart != null){
        //         return cart.Id;
        //     }else{
        //         Cart newCart = new Cart(){
        //         };
        //         _context.Cart.Add(newCart);
        //         _context.SaveChanges();
        //         return newCart.Id;
        //     }
        // }

        public Task<ServiceResponse<List<CartItem>>> GetCartList()
        {
            
            throw new NotImplementedException();
        }

        
    }
}