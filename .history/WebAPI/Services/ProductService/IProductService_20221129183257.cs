using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.Product;

namespace WebAPI.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<GetProductDto>>> GetAllProducts();
        Task<ServiceResponse<GetProductDto>> GetSingleProductById(int id);
        Task<ServiceResponse<List<GetProductDto>>> AddProduct(AddProductDto newProduct);
    }
}