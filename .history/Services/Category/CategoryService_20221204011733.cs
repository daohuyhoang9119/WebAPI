using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.Dtos.Category;
using WebAPI.Services.Category;

namespace WebAPI.Services.CategoryService
{
    public class CategoryService : ICategoryService
    
    {
       
        private readonly IMapper _mapper;

      
        public CategoryService(IMapper mapper)
        {
            _mapper = mapper;
        }

        private static List<Category> products

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

        public async Task<ServiceResponse<List<GetCategoryDto>>> GetCategory()
        {
             return new ServiceResponse<List<GetCategoryDto>> {Data = category.Select(c => _mapper.Map<GetCategoryDto>(c)).ToList()};
        }

        public Task<ServiceResponse<GetCategoryDto>> UpdateCategory(GetCategoryDto updatedCategory)
        {
            throw new NotImplementedException();
        }
    }
}