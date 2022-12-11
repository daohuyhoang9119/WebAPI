using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.CartService;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService){
            _cartService = cartService;
        }
        //Get List category
        [HttpGet("list")]     
        public async Task<ActionResult<ServiceResponse<List<CartItem>>>> GetCartList(){
            return Ok(await _cartService.GetCartList());
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<CartItem>>>> AddCartItem(CartItem newCartItem){
            return Ok(await _cartService.AddCartItem(newCartItem));
        }


        [HttpDelete("id")]
        public async Task<ActionResult<ServiceResponse<List<CartItem>>>> DeleteCartItem(int id){
            // return Ok(await _productService.UpdateProduct(updatedProduct));
            var response = await _cartService.DeleteCartItem(id);
            if(response.Data == null){
                return NotFound(response);
            }
            return Ok(response); 
        }
    }
}