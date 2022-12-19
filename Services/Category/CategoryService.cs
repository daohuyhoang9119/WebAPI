using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
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
        private readonly DataContext _context;
      
        public CategoryService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetCategoryDto>>> AddCategory(AddCategoryDto newCategory)
        {
            var serviceRespone = new  ServiceResponse<List<GetCategoryDto>>();
            Category category = _mapper.Map<Category>(newCategory);
            _context.Category.Add(category);
            await _context.SaveChangesAsync();
            serviceRespone.Data = await _context.Category
                .Select(c => _mapper.Map<GetCategoryDto>(c))
                .ToListAsync();
            return serviceRespone;
        }

        public async Task<ServiceResponse<List<GetCategoryDto>>> DeleteCategory(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetCategoryDto>>();
            var category_remove= await _context.Category.FirstAsync(c => c.Id == id);
            _context.Category.Remove(category_remove);
            await _context.SaveChangesAsync();
            serviceResponse.Data = await _context.Category.Select(c => _mapper.Map<GetCategoryDto>(c)).ToListAsync();
            return serviceResponse;
            
        }


        public async Task<ServiceResponse<List<GetCategoryDto>>> GetCategory()
        {
            var response = new ServiceResponse<List<GetCategoryDto>>();
            var dbProduct = await _context.Category.ToListAsync();
            response.Data = dbProduct.Select(c => _mapper.Map<GetCategoryDto>(c)).ToList();
            return response;
        }

        public async Task<ServiceResponse<GetCategoryDto>> UpdateCategory(UpdateCategoryDto updatedCategory)
        {
            ServiceResponse<GetCategoryDto> response = new ServiceResponse<GetCategoryDto>();
            var Category = category.FirstOrDefault(c=> c.Id == updatedCategory.Id);
           try{
             var categoryDB = await _context.Category
                    .FirstOrDefaultAsync(c=> c.Id == updatedCategory.Id);
                _mapper.Map(updatedCategory, category); 
                await _context.SaveChangesAsync();
                response.Data = _mapper.Map<GetCategoryDto>(categoryDB);
            } catch (Exception ex){
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        
    }
}