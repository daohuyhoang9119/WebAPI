using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.Data;
using WebAPI.Dtos.Product;

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
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public ProductService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }


        public async Task<ServiceResponse<List<GetProductDto>>> AddProduct(AddProductDto newProduct)
        {
            var serviceRespone = new ServiceResponse<List<GetProductDto>>();
            products.Add(_mapper.Map<Product>(newProduct));
            serviceRespone.Data = products.Select(c => _mapper.Map<GetProductDto>(c)).ToList();
            return serviceRespone;
        }

        public async Task<ServiceResponse<List<GetProductDto>>> DeleteProduct(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetProductDto>>();
            var product = products.First(c => c.Id == id);
            products.Remove(product);
            serviceResponse.Data = products.Select(c => _mapper.Map<GetProductDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetProductDto>>> GetAllProducts()
        {
            return new ServiceResponse<List<GetProductDto>> {Data = products.Select(c => _mapper.Map<GetProductDto>(c)).ToList()};
        }

        public async Task<ServiceResponse<GetProductDto>> GetSingleProductById(int id) {
            var serviceRespone = new ServiceResponse<GetProductDto>();
            var product = products.FirstOrDefault(c => c.Id == id);
            serviceRespone.Data = _mapper.Map<GetProductDto>(product);
            return serviceRespone;
        }

        public async Task<ServiceResponse<GetProductDto>> UpdateProduct(UpdateProductDto updatedProduct)
        {
            ServiceResponse<GetProductDto> response = new ServiceResponse<GetProductDto>();
            var product = products.FirstOrDefault(c=> c.Id == updatedProduct.Id);
            try{
                _mapper.Map(updatedProduct, product);
                // product.Title = updatedProduct.Title;
                // product.Price = updatedProduct.Price;
                // product.Discount = updatedProduct.Discount;
                // product.Rating_Average = updatedProduct.Rating_Average;
                // product.Brand_Name = updatedProduct.Brand_Name;
                // product.Created_at = updatedProduct.Created_at;
                // product.Updated_at = updatedProduct.Updated_at;

                response.Data = _mapper.Map<GetProductDto>(product);
            } catch (Exception ex){
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}