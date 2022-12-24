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

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            var user = modelBuilder.Entity<User>();
            user.HasKey(x => x.Id);//pk
            user.HasOne(x => x.Cart)//fk
                .WithOne(x => x.User)
                .HasForeignKey<User>(fk => fk.Cart_Id);
            
            // var cart = modelBuilder.Entity<Cart>();
            // cart.HasKey(x => x.Id);//pk
            // cart.HasOne(x => x.User)//fk
            //     .WithOne(x => x.User_Cart)
            //     .HasForeignKey<Cart>(fk => fk.User_Id);

            var cartItem = modelBuilder.Entity<CartItem>();
            cartItem.HasKey(x => x.Id);//pk
            cartItem.HasOne(x => x.cart) //fk
                    .WithMany(x => x.CartItems)
                    .HasForeignKey(x => x.Cart_Id);

        }
    }
}