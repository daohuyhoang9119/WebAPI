using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
     
        public ActionResult<List<Product>> GetAllProduct(){
            return Ok(_productService.GetAllProducts());
        }
        //Get Single product
        [HttpGet("{id}")]
        public ActionResult<Product> GetSingleProductById(int id){
            return Ok(_productService.GetSingleProductById(id));
        }

        [HttpPost]
        public ActionResult<List<Product>> AddProduct(Product newProduct){
            return Ok(_productService.AddProduct(newProduct));
        }
    }
}