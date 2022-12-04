using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.Dtos.Category;

namespace WebAPI.Services.CategoryService
{
    public class CategoryService : ICategoryService
    
    {   
        private static List<Category> category = new List<Category>{
            new Category(),
            new Category{Id = 1, Category_Name = "flag ship"},
            new Category{Id = 2, Category_Name = "High End"},
            new Category{Id = 3, Category_Name = "China"},
            new Category{Id = 4, Category_Name = "USA"},
        };

        private readonly IMapper _mapper;

      
        public CategoryService(IMapper mapper)
        {
            _mapper = mapper;
        }

        

        public async Task<ServiceResponse<List<GetCategoryDto>>> AddCategory(AddCategoryDto newCategory)
        {
            var serviceRespone = new ServiceResponse<List<GetCategoryDto>>();
            category.Add(_mapper.Map<Category>(newCategory));
            serviceRespone.Data = category.Select(c => _mapper.Map<GetCategoryDto>(c)).ToList();
            return serviceRespone;
        }

        public Task<ServiceResponse<List<GetCategoryDto>>> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<ServiceResponse<List<GetCategoryDto>>> GetCategory()
        {
             return new ServiceResponse<List<GetCategoryDto>> {Data = category.Select(c => _mapper.Map<GetCategoryDto>(c)).ToList()};
        }

        public async Task<ServiceResponse<GetCategoryDto>> UpdateCategory(UpdateCategoryDto updatedCategory)
        {
            ServiceResponse<GetCategoryDto> response = new ServiceResponse<GetCategoryDto>();
            var Category = category.FirstOrDefault(c=> c.Product_Id == updatedCategory.Product_Id);
           try{
                _mapper.Map(updatedCategory, category); // product.Title = updatedProduct.Title;
                // product.Price = updatedProduct.Price;
                // product.Discount = updatedProduct.Discount;
                // product.Rating_Average = updatedProduct.Rating_Average;
                // product.Brand_Name = updatedProduct.Brand_Name;
                // product.Created_at = updatedProduct.Created_at;
                // product.Updated_at = updatedProduct.Updated_at;

                response.Data = _mapper.Map<GetCategoryDto>(category);
            } catch (Exception ex){
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}