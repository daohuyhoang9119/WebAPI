using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.CartItem;
using WebAPI.Dtos.OrderItem;

namespace WebAPI.Dtos.Order
{
    public class GetOrderDto
    {
       public int Id { get; set; }
        public int? User_Id { get; set; }
        public String? Status { get; set; }
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public DateTime Updated_At { get; set; }
        public double Total_Amount { get; set; }
        public virtual ICollection<GetOrderItemDto>? Order_Products { get; set; }
    }
}