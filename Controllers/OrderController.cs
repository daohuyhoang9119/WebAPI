using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.OrderService;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            this._orderService = orderService;
        }
        //get list order
        [HttpGet("list")]     
        public async Task<ActionResult<ServiceResponse<List<Order>>>> GetAllOrders(){
            return Ok(await _orderService.GetAllOrders());
        }

        //Get Single order by id
        [HttpGet("{id}")]
        public async  Task<ActionResult<ServiceResponse<Order>>> GetOrderById(int id){
            return Ok(await _orderService.GetOrderById(id));
        }

    }
}