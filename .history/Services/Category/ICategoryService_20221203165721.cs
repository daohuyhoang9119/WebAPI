using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.Category;

namespace WebAPI.Services.Category
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<GetCategoryDto>>> GetAllCategory();
        // Task<ServiceResponse<GetProductDto>> GetSingleProductById(int id);
        Task<ServiceResponse<List<GetCategoryDto>>> AddCategory(AddCategoryDto newCategory);

        Task<ServiceResponse<GetCategoryDto>> UpdateCategory(AddCategoryDto updatedCategory);
        Task<ServiceResponse<List<GetCategoryDto>>> DeleteCategory(int category_id);
        
    }
}