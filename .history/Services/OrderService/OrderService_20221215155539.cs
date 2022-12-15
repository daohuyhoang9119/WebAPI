using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.OrderService
{
    public class OrderService : IOrderService
    {
          private static List<Order> orders = new List<Order>{
            new Order(),
            new Order{Id = 1, Status = "Pending", Total_Amount=1000},
            new Order{Id = 2, Status = "Done", Total_Amount=2000},
            new Order{Id = 3, Status = "Pending", Total_Amount=3400},
            new Order{Id = 4, Status = "Pending", Total_Amount=1000},
            new Order{Id = 5, Status = "Rejected", Total_Amount=0},
            new Order{Id = 6, Status = "Pending", Total_Amount=1000},
        };

        public Task<ServiceResponse<List<Order>>> AddOrder(Order newOrder)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<Order>>> DeleteOrder(int idOrder)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Order>>> GetAllOrders()
        {
            var response = new ServiceResponse<List<Order>>();
            // var dbProduct = await _context.Product.ToListAsync();
            // response.Data = dbProduct.Select(c => _mapper.Map<GetProductDto>(c)).ToList();
            response.Data = orders.ToList();
            return response;
        }

        public async Task<ServiceResponse<Order>> GetOrderById(int id)
        {
            var response = new ServiceResponse<List<Order>>();
            // var dbProduct = await _context.Product.ToListAsync();
            // response.Data = dbProduct.Select(c => _mapper.Map<GetProductDto>(c)).ToList();
            var order_target = orders.FirstOrDefault(c => c.Id == id);
            response.Data = order_target;
            return response;
        }

        public Task<ServiceResponse<Order>> UpdateOrder(Order updatedOrder)
        {
            throw new NotImplementedException();
        }
    }
}