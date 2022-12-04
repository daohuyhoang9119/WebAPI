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

        

        public Task<ServiceResponse<List<GetCategoryDto>>> AddCategory(AddCategoryDto newCategory)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetCategoryDto>>> DeleteCategory(int id)
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