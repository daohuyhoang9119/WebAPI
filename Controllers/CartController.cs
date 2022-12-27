using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dtos.CartItem;
using WebAPI.Services.CartService;

namespace WebAPI.Controllers
{
    [Authorize]
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
        public async Task<ActionResult<ServiceResponse<List<GetCartItemDto>>>> GetCart(){
            return Ok(await _cartService.GetCart());
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<AddCartItemDto>>> AddCartItem(int productId, int quantity){
            var response = await _cartService.AddCartItem(productId,quantity);
            if(response.Data == null){
                return NotFound(response);
            }
            return Ok(response); 
        }


        [HttpDelete("id")]
        public async Task<ActionResult<ServiceResponse<List<GetCartItemDto>>>> RemoveCartItem(int productId, int quantity){
            // return Ok(await _productService.UpdateProduct(updatedProduct));
            var response = await _cartService.RemoveCartItem(productId,quantity);
            if(response.Data == null){
                return NotFound(response);
            }
            return Ok(response); 
        }
    }
}