using System.Collections.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category {get; set;}
        public DbSet<Cart> Cart {get; set; }
        public DbSet<CartItem> CartItem {get; set;}
        public DbSet<Order> Order {get; set;}
        public DbSet<OrderItem> OrderItem {get; set;}
        

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            var user = modelBuilder.Entity<User>();
            
            
            var cart = modelBuilder.Entity<Cart>();
            cart.HasKey(x => x.Id);//pk
            cart.HasOne(x => x.User)//fk
                .WithOne(x => x.Cart)
                .HasForeignKey<Cart>(fk => fk.User_Id);

            var cartItem = modelBuilder.Entity<CartItem>();
            cartItem.HasKey(x => x.Id);//pk
            cartItem.HasOne(x => x.cart) //fk
                    .WithMany(x => x.CartItems)
                    .HasForeignKey(x => x.Cart_Id);
            cartItem.HasOne(x => x.product)
                    .WithOne(x => x.cartitem)
                    .HasForeignKey<CartItem>(fk => fk.Product_Id);

            var order = modelBuilder.Entity<Order>();
            order.HasKey(x => x.Id);
            order.HasOne(x => x.User)
                .WithMany(x => x.Orders)
                .HasForeignKey(fk => fk.User_Id);

            var orderItem = modelBuilder.Entity<OrderItem>();
            orderItem.HasKey(x => x.Id);//pk
            orderItem.HasOne(x => x.order) //fk
                    .WithMany(x => x.OrderItems)
                    .HasForeignKey(x => x.Order_Id);
            orderItem.HasOne(x => x.product)
                    .WithOne(x => x.orderitem)
                    .HasForeignKey<OrderItem>(fk => fk.Product_Id);

        }
    }
}