using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dtos.Product;
using WebAPI.Services.ProductService;

namespace WebAPI.Controllers
{
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
    }
}