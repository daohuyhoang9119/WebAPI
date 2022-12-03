using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.Category;

namespace WebAPI.Services.Category
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<GetCategoryDto>>> GetCategory();
        Task<ServiceResponse<List<GetCategoryDto>>> AddCategory(AddCategoryDto newCategory);

        Task<ServiceResponse<GetCategoryDto>> UpdateCategory(GetCategoryDto updatedCategory);
        Task<ServiceResponse<List<GetCategoryDto>>> DeleteCategory(int id);
        
    }
}