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
        private static Product ip = new Product();

        [HttpGet(Name = "product")]
        public IActionResult Get(){
            return Ok(ip);
        }
        
    }
}