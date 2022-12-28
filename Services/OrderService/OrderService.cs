using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Dtos.Cart;
using WebAPI.Dtos.Order;
using WebAPI.Dtos.OrderItem;
using WebAPI.Enums;

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

        public async Task<ServiceResponse<List<GetOrderDto>>> AddOrder(AddOrderDto newOrder)
        {
            var response = new ServiceResponse<List<GetOrderDto>>();
            var cart = await _context.Cart.Where(c => c.User_Id == GetUserId()).Select(c => _mapper.Map<GetCartDto>(c))
                            .FirstOrDefaultAsync();
            if(cart == null){
                response.Data = null;
                return response;
            }
            var items = new List<OrderItem>();
            foreach (var item in cart.CartItems)
            {
                var productItem = await _context.Product.FindAsync(item.Product_Id); 
                var orderItem = new OrderItem{
                    Name = item.Name,
                    Quantity = item.Quantity,
                    Price = item.Price,
                    Image_Url = item.Image_Url,
                    Product_Id = item.Product_Id
                };
                _mapper.Map<GetOrderItemDto>(orderItem);
                items.Add(orderItem);
            };
            var total_amount = items.Sum(item => item.Price * item.Quantity);
            var order_created = new Order{
                OrderItems = items,
                User_Id = GetUserId(),
                Total_Amount = total_amount,
                Status = OrderStatus.Pending,
                Country = newOrder.Country,
                Address = newOrder.Address,
                Town = newOrder.Town,
                Zip_Code = newOrder.Zip_Code,
                Phone = newOrder.Phone,
                Email = newOrder.Email,
            };
            _context.Order.Add(order_created);
            await _context.SaveChangesAsync(); 
            return response;
        }

        public Task<ServiceResponse<List<Order>>> DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetOrderDto>>> GetAllOrders()
        {
            //get id with user id
            var response = new ServiceResponse<List<GetOrderDto>>();
            var orders = await _context.Order.Where(c => c.User_Id == GetUserId())
                            .Select(c => _mapper.Map<GetOrderDto>(c))
                            .ToListAsync();
            if(orders == null){
                response.Data = null;
                return response;
            }else{
                response.Data = orders;
                return response;
            }
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
        private Order CreateOrder(){
            var user_id = GetUserId();
            if(user_id == null){
                user_id = Int32.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            }
            var order = new Order{User_Id = user_id};
            _context.Order.Add(order);
            return order;
        } 
    }
}