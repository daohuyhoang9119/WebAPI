using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>{
            new Product(),
            new Product { Id = 1, Title = "Samsung"}
        };
        //List
        [HttpGet("list")]
     
        public ActionResult<List<Product>> Get(){
            return Ok(products);
        }
        //Single
        [HttpGet]
        public ActionResult<Product> GetSingleProduct(int id){
            return Ok(products.FirstOrDefault(c => c.Id == id));
        }
        
    }
}