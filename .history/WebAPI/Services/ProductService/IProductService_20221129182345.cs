using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetAllProducts();
        Task<ServiceResponse<Product>> GetSingleProductById(int id);
        Task<ServiceResponse<List<Product>>> AddProduct(Product newProduct);
    }
}