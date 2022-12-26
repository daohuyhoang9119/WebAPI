using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Cart
    {
        public int Id { get; set; } //PK
        public double Total_Amount { get; set; }
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public DateTime Updated_At { get; set; } = DateTime.UtcNow;
        
        public User User { get; set; }
        public int? User_Id { get; set; }
        public List<CartItem> CartItems { get; set; } = new();

        public void AddItem(Product product, int quantity){
            if(CartItems.All(item => item.Product_Id != product.Id)){
                CartItems.Add(new CartItem{Product_Id = product.Id, Quantity = quantity});
            }
            var existingItem = CartItems.FirstOrDefault(item => item.Product_Id == product.Id);
            if (existingItem != null) existingItem.Quantity += quantity;
        }

        public void RemoveItem(int product_id, int quantity){
            var item = CartItems.FirstOrDefault(item => item.Product_Id == product_id);
            if (item == null) return;
            item.Quantity -= quantity;
            if (item.Quantity == 0) CartItems.Remove(item);
        }
    }
}