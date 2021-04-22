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

            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();
            CreateMap<CustomerAddDTO, Person>();
            CreateMap<CustomerAddDTO, Customer>();

            CreateMap<Staff, StaffDTO>();

            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
        }
    }
}
