using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.Dtos.CartItem;
using WebAPI.Dtos.Category;
using WebAPI.Dtos.Product;
using WebAPI.Dtos.User;

namespace WebAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, GetProductDto>();
            CreateMap<AddProductDto, Product>();
            CreateMap<UpdateProductDto, GetProductDto>();
            
            CreateMap<Category, GetCategoryDto>();
            CreateMap<AddCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, GetCategoryDto>();

            CreateMap<AddCartItemDto, CartItem>();
            CreateMap<CartItem, GetCartItemDto>();
            

            CreateMap<UserRegisterDto, User>();
            CreateMap<User,UserRegisterDto>();

        }
    }
}