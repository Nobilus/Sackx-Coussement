using System;
using System.Collections.Generic;
using AutoMapper;
using Project.DTO;
using Project.Models;

namespace Sneakers.API.DTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {

            CreateMap<Product, ProductDTO>();
        }
    }
}
