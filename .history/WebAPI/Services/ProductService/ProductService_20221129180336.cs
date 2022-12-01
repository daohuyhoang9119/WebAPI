using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.ProductService
{
    public class ProductService : IProductService
    {   
        private static List<Product> products = new List<Product>{
            new Product(),
            new Product { Id = 1, Title = "Samsung"},
            new Product { Id = 2, Title = "Oppo"},
            new Product { Id = 3, Title = "Nokia"},
            new Product { Id = 4, Title = "Gg Pixel"},
        };
        public async Task<List<Product>> AddProduct(Product newProduct)
        {
            products.Add(newProduct);
            return products;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return products;
        }

        public async Task<Product> GetSingleProductById(int id) => products.FirstOrDefault(c => c.Id == id);
    }
}