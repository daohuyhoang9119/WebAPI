using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.OrderItem;

namespace WebAPI.Services.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<List<GetOrderItemDto>>> GetAllOrders();
        Task<ServiceResponse<Order>> GetOrderById(int id);
        Task<ServiceResponse<List<Order>>> AddOrder(Order newOrder);

        Task<ServiceResponse<Order>> UpdateOrder(Order updatedOrder);
        Task<ServiceResponse<List<Order>>> DeleteOrder(int idOrder);
        
    }
}