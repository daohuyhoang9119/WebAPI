using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.Category;

namespace WebAPI.Services.Category
{
    public class CategoryService : ICategoryService
    {
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
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetCategoryDto>> UpdateCategory(GetCategoryDto updatedCategory)
        {
            throw new NotImplementedException();
        }
    }
}