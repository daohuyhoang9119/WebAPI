using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.Dtos.Product;

namespace WebAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, GetProductDto>();
            CreateMap<AddProductDto, Product>();
            CreateMap<UpdateProductDto, GetProductDto>();
        }
    }
}