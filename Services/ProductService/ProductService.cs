using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Dtos.Product;
using WebAPI.Extensions;
using WebAPI.RequestHelpers;

namespace WebAPI.Services.ProductService
{
    public class ProductService : IProductService
    {   
        
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProductService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User
            .FindFirstValue(ClaimTypes.NameIdentifier));


        public async Task<ServiceResponse<List<GetProductDto>>> AddProduct(AddProductDto newProduct)
        {
            var serviceRespone = new ServiceResponse<List<GetProductDto>>();
            Product product = _mapper.Map<Product>(newProduct);
            _context.Product.Add(product);
            await _context.SaveChangesAsync();
            serviceRespone.Data = await _context.Product
                .Select(c => _mapper.Map<GetProductDto>(c))
                .ToListAsync();
            return serviceRespone;
        }

        public async Task<ServiceResponse<List<GetProductDto>>> DeleteProduct(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetProductDto>>();
            var productDeleted = await _context.Product.FirstAsync(c => c.Id == id);
            _context.Product.Remove(productDeleted);
            await _context.SaveChangesAsync();
            serviceResponse.Data = await _context.Product
                .Select(c => _mapper.Map<GetProductDto>(c))
                .ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetProductDto>>> GetAllProducts(){
            var response = new ServiceResponse<List<GetProductDto>>();
            var dbProduct = await _context.Product.ToListAsync();
            response.Data = dbProduct.Select(c => _mapper.Map<GetProductDto>(c)).ToList();
            return response;
        }

        public async Task<ServiceResponse<GetProductDto>> GetSingleProductById(int id) {
            var serviceRespone = new ServiceResponse<GetProductDto>();
            var productFromDB = await _context.Product.FirstOrDefaultAsync(c => c.Id == id);
            serviceRespone.Data = _mapper.Map<GetProductDto>(productFromDB);
            return serviceRespone;
        }

        public async Task<ServiceResponse<GetProductDto>> UpdateProduct(UpdateProductDto updatedProduct)
        {
            ServiceResponse<GetProductDto> response = new ServiceResponse<GetProductDto>();
            try{
                var productDB = await _context.Product
                    .FirstOrDefaultAsync(c=> c.Id == updatedProduct.Id);
                // _mapper.Map(updatedProduct, productFromDB);
                productDB.Title = updatedProduct.Title;
                productDB.Price = updatedProduct.Price;
                productDB.Discount = updatedProduct.Discount;
                productDB.Rating_Average = updatedProduct.Rating_Average;
                productDB.Category_Id = updatedProduct.Category_Id;
                productDB.Description = updatedProduct.Description;
                productDB.Brand_Name = updatedProduct.Brand_Name;
                productDB.Created_at = updatedProduct.Created_at;
                productDB.Updated_at = updatedProduct.Updated_at;
                await _context.SaveChangesAsync();
                response.Data = _mapper.Map<GetProductDto>(productDB);
            } catch (Exception ex){
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    
        public async Task<PagedList<Product>> GetProductByParams([FromQuery]ProductParams productParams){
            var query =  _context.Product
                .Sort(productParams.OrderBy)
                .Search(productParams.SearchTerm)
                .Filter(productParams.Brands)
                .AsQueryable();
            
          var products = await PagedList<Product>.ToPagedList(query, 
            productParams.PageNumber, productParams.PageSize);
        //   Response.AddPaginationHeader(products.MetaData);
        //   ServiceResponse<GetProductDto> response = new ServiceResponse<GetProductDto>();

            return products;
        }
    
    
    }
}