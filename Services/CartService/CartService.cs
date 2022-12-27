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
        public async Task<ServiceResponse<List<GetCartItemDto>>> GetCart()
        {
            var response = new ServiceResponse<List<GetCartItemDto>>();
            //Get cart by user id
            // var user = await _context.User.FirstAsync(c => c.Id == GetUserId());
            var cart = await _context.Cart.FirstOrDefaultAsync(c => c.User_Id == GetUserId());
            //validate
            if(cart == null) {
                response.Data = null;
                return response;
            }else{
                var listItem = await _context.CartItem.Where(c => c.Cart_Id == cart.Id)
                            .Select(c => _mapper.Map<GetCartItemDto>(c))
                            .ToListAsync();
                response.Data = listItem;
                return response;            
            }
            
        }
        public async Task<ServiceResponse<AddCartItemDto>> AddCartItem(int productId, int quantity)
        {
            var serviceRespone = new  ServiceResponse<AddCartItemDto>();
            //Find Cart with user id
            var cart = await _context.Cart.FirstOrDefaultAsync(c => c.User_Id == GetUserId());    
            if(cart == null){
                cart = CreateCart();
            }

            //Find product with id
            var product = await _context.Product.FirstAsync(c => c.Id == productId);
            if(product == null){
                serviceRespone.Data = null;
                return serviceRespone;
            }
            //Check if product was picked in cart list?
            //if not => add 
            CartItem existingCartItem = _context.CartItem.FirstOrDefault(x => x.Product_Id == product.Id && x.Cart_Id == cart.Id);
            if(existingCartItem != null){
                existingCartItem.Quantity += 1;
                _context.Entry(existingCartItem).State = EntityState.Modified;
                await _context.SaveChangesAsync() ;
            }else{
                CartItem cartitem = new CartItem{
                    Quantity = quantity,
                    Product_Id = productId,
                    Cart_Id = cart.Id,
                    Name = product.Title,
                    Price = product.Price,
                    Image_Url = product.ImageUrl_1,
                };
                _mapper.Map<GetCartItemDto>(cartitem);
                await _context.SaveChangesAsync();
                _context.CartItem.Add(cartitem);
            }

            // cart.AddItem(product,quantity);
            await _context.SaveChangesAsync();

            return serviceRespone ;
        }

        public async Task<ServiceResponse<GetCartItemDto>> RemoveCartItem(int productId, int quantity)
        {
            var serviceRespone = new  ServiceResponse<GetCartItemDto>();
            //Find Cart with user id
            var cart = await _context.Cart.FirstOrDefaultAsync(c => c.User_Id == GetUserId());    
            if(cart == null){
                cart = CreateCart();
            }
            //Find product with id
            var product = await _context.Product.FirstAsync(c => c.Id == productId);
            if(product == null){
                serviceRespone.Data = null;
                return serviceRespone;
            }

            CartItem existingCartItem = _context.CartItem.FirstOrDefault(x => x.Product_Id == product.Id && x.Cart_Id == cart.Id);
            if(existingCartItem != null){
                existingCartItem.Quantity -= quantity;
                _context.Entry(existingCartItem).State = EntityState.Modified;
                await _context.SaveChangesAsync() ;
            }
            if(existingCartItem?.Quantity == 0){
                 _context.CartItem.Remove(existingCartItem);
                 await _context.SaveChangesAsync();
            }
            return serviceRespone ;
        }

        
        private int GetUserId(){
            int user_id = Int32.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)); 
            if(user_id == null){
                return 0;
            }
            return user_id;           
        } 

        private Cart CreateCart(){
            var user_id = GetUserId();
            if(user_id == null){
                user_id = int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            }
            var cart = new Cart{User_Id = user_id};
            _context.Cart.Add(cart);
            return cart;
        }
        

        

        
    }
}