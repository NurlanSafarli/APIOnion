﻿using AutoMapper;
using ProniaOnion202.Application.DTOs.Products;
using ProniaOnion202.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.MappingProfiles
{
    internal class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductItemDto>().ReverseMap();
            CreateMap<Product, ProductGetDto>().ReverseMap();
            CreateMap<ProductCreateDto, Product>();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
        }
    }
}
