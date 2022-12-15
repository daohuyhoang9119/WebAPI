using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.OrderService
{
    public class OrderService : IOrderService
    {
          private static List<Order> category = new List<Order>{
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

        public Task<ServiceResponse<List<Order>>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Order>> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Order>> UpdateOrder(Order updatedOrder)
        {
            throw new NotImplementedException();
        }
    }
}