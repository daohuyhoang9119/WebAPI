using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.OrderService
{
    public class OrderService : IOrderService
    {
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