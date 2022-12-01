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
        public async Task<ServiceResponse<List<Product>>> AddProduct(Product newProduct)
        {
            var serviceRespone = new ServiceResponse<List<Product>>();
            products.Add(newProduct);
            serviceRespone.Data = products;
            return serviceRespone;
        }

        public async Task<ServiceResponse<List<Product>>> GetAllProducts()
        {
            return new ServiceResponse<List<Product>> {Data = products};
        }

        public async Task<ServiceResponse<Product>> GetSingleProductById(int id) {
            var serviceRespone = new ServiceResponse<Product>();
            var product = products.FirstOrDefault(c => c.Id == id);
            serviceRespone.Data = product;
            return serviceRespone;
        }
    }
}