using System.Linq;
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
            CreateMap<ProductAddDTO, Product>();

            CreateMap<Customer, CustomerDTO>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.PersonId)
                )
                .ForMember(
                    dest => dest.Firstname,
                    opt => opt.MapFrom(src => src.Person.FirstName)
                )
                .ForMember(
                    dest => dest.Lastname,
                    opt => opt.MapFrom(src => src.Person.LastName)
                );
            CreateMap<CustomerDTO, Customer>();
            CreateMap<CustomerAddDTO, Person>();
            CreateMap<CustomerAddDTO, Customer>();


            CreateMap<Staff, StaffDTO>().ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.PersonId)
                )
                .ForMember(
                    dest => dest.Firstname,
                    opt => opt.MapFrom(src => src.Person.FirstName)
                )
                .ForMember(
                    dest => dest.Lastname,
                    opt => opt.MapFrom(src => src.Person.LastName)
                ); ;
            CreateMap<StaffAddDTO, Staff>();
            CreateMap<StaffAddDTO, Person>();

            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
            CreateMap<Order, OrdersDTO>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.OrderId)
                )
                .ForMember(
                    dest => dest.CustomerId,
                    opt => opt.MapFrom(src => src.CustomerId)
                )
                .ForMember(
                    dest => dest.Firstname,
                    opt => opt.MapFrom(src => src.Customer.Person.FirstName)
                )
                .ForMember(
                    dest => dest.Lastname,
                    opt => opt.MapFrom(src => src.Customer.Person.LastName)
                )
                .ForMember(
                    dest => dest.CompanyNumber,
                    opt => opt.MapFrom(src => src.Customer.CompanyNumber)
                )
                .ForMember(
                    dest => dest.Products,
                    opt => opt.MapFrom(src => src.OrderProducts.Select(op => op.Product).ToList())
                );
        }
    }
}
