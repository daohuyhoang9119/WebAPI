using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dtos.Category;
using WebAPI.Services.CategoryService;

namespace WebAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService){
            _categoryService = categoryService;
        }
        //Get List category
        [HttpGet("list")]     
        public async Task<ActionResult<ServiceResponse<List<GetCategoryDto>>>> GetCategory(){
            return Ok(await _categoryService.GetCategory());
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCategoryDto>>>> AddCategory(AddCategoryDto newCategory){
            return Ok(await _categoryService.AddCategory(newCategory));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCategoryDto>>> UpdateCategory(UpdateCategoryDto updatedCategory){
            // return Ok(await _CategoryService.UpdateCategory(updatedCategory));
            var response = await _categoryService.UpdateCategory(updatedCategory);
            if(response.Data == null){
                return NotFound(response);
            }
            return Ok(response); 
        }

    }
}