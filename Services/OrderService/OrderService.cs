using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.Data;
using WebAPI.Dtos.OrderItem;

namespace WebAPI.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public OrderService(IMapper mapper, DataContext context,IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public Task<ServiceResponse<List<Order>>> AddOrder(Order newOrder)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<Order>>> DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetOrderItemDto>>> GetAllOrders()
        {
            //get id with user id
            // var orders = await _context.Order.
            // var response = new ServiceResponse<List<GetOrderItemDto>>();
            // var orders = await _context.Order.Where(c => c. == cart.Id)
            //                 .Select(c => _mapper.Map<GetCartItemDto>(c))
            //                 .ToListAsync();

            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<Order>> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Order>> UpdateOrder(Order updatedOrder)
        {
            throw new NotImplementedException();
        }
        private int GetUserId(){
            int user_id = Int32.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)); 
            if(user_id == null){
                return 0;
            }
            return user_id;           
        } 
    }
}