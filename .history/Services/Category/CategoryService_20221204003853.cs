using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.Dtos.Category;

namespace WebAPI.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private static List<Category> categoryList = new List<Category>{
      
        };
        
        public CategoryService(IMapper mapper)
        {
            _mapper = mapper;
        }


        public Task<ServiceResponse<List<GetCategoryDto>>> AddCategory(AddCategoryDto newCategory)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetCategoryDto>>> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetCategoryDto>>> GetAllCategorys()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetCategoryDto>>> GetCategory()
        {
            
        }

        public Task<ServiceResponse<GetCategoryDto>> UpdateCategory(GetCategoryDto updatedCategory)
        {
            throw new NotImplementedException();
        }
    }
}