using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dtos.Product;
using WebAPI.RequestHelpers;
using WebAPI.Services.ProductService;

namespace WebAPI.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService){
            _productService = productService;
        }
        //Get List products
        [HttpGet("list")]
     
        public async Task<ActionResult<ServiceResponse<List<GetProductDto>>>> GetAllProduct(){
            return Ok(await _productService.GetAllProducts());
        }
        //Get Single product
        [HttpGet("{id}")]
        public async  Task<ActionResult<ServiceResponse<GetProductDto>>> GetSingleProductById(int id){
            return Ok(await _productService.GetSingleProductById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetProductDto>>>> AddProduct(AddProductDto newProduct){
            return Ok(await _productService.AddProduct(newProduct));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetProductDto>>> UpdateProduct(UpdateProductDto updatedProduct){
            // return Ok(await _productService.UpdateProduct(updatedProduct));
            var response = await _productService.UpdateProduct(updatedProduct);
            if(response.Data == null){
                return NotFound(response);
            }
            return Ok(response); 
        }
        [HttpDelete("id")]
        public async Task<ActionResult<ServiceResponse<List<GetProductDto>>>> DeleteProduct(int id){
            // return Ok(await _productService.UpdateProduct(updatedProduct));
            var response = await _productService.DeleteProduct(id);
            if(response.Data == null){
                return NotFound(response);
            }
            return Ok(response); 
        }
        [HttpGet]
        public async Task<ActionResult<PagedList<Product>>> GetProductByParams([FromQuery]ProductParams productParams){
            var response = await _productService.GetProductByParams(productParams);
            if(response== null){
                return NotFound(response);
            }
            return Ok(response); 
        }
    }
}