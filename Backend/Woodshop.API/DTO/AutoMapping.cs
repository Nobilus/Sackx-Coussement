using System.Linq;
using System;
using System.Collections.Generic;
using AutoMapper;
using Project.DTO;
using Project.Models;
using Woodshop.API.DTO;
using Woodshop.API.Models;

namespace Sneakers.API.DTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {

            CreateMap<Product, ProductDTO>()
                .ForMember(
                    dest => dest.MeasurmentUnit,
                    opt => opt.MapFrom(src => src.Unit.Name)
                )
                .ForMember(
                    dest => dest.ProductGroupName,
                    opt => opt.MapFrom(src => src.ProductGroup.ProductGroupName)
                );
            CreateMap<ProductAddDTO, Product>();

            CreateMap<Customer, CustomerDTO>();
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
            // CreateMap<OrderAddProductDTO, Order>();
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
                    dest => dest.CustomerName,
                    opt => opt.MapFrom(src => src.Customer.CustomerName)
                )
                .ForMember(
                    dest => dest.Street,
                    opt => opt.MapFrom(src => src.Customer.Street)
                )
                .ForMember(
                    dest => dest.Postal,
                    opt => opt.MapFrom(src => src.Customer.Postal)
                )
                .ForMember(
                    dest => dest.City,
                    opt => opt.MapFrom(src => src.Customer.City)
                )
                .ForMember(
                    dest => dest.OrderDetails,
                    opt => opt.MapFrom(src => src.OrderProducts)

                ).ForMember(
                    dest => dest.IsPayed,
                    opt => opt.MapFrom(src => src.IsPayed)
                );
            CreateMap<Product, OrderProduct>();
            CreateMap<OrderProduct, OrderProductDTO>()
                .ForMember(
                    dest => dest.Thickness,
                    opt => opt.MapFrom(src => src.Product.Thickness)
                )
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Product.Name)
                )
                .ForMember(
                    dest => dest.Width,
                    opt => opt.MapFrom(src => src.Product.Width)
                )
                .ForMember(
                    dest => dest.MeasurmentUnit,
                    opt => opt.MapFrom(src => src.Product.Unit.Name)
                )
                .ForMember(
                    dest => dest.Price,
                    opt => opt.MapFrom(src => src.Product.Price)
                )
                .ForMember(
                    dest => dest.PurchasePrice,
                    opt => opt.MapFrom(src => src.Product.PurchasePrice)
                );

            CreateMap<ProductGroup, ProductgroupDTO>();
            CreateMap<APICustomer, Customer>()
            .ForMember(
                dest => dest.City,
                opt => opt.MapFrom(src => src.Address.City)
            )
            .ForMember(
                dest => dest.Street,
                opt => opt.MapFrom(src => $"{src.Address.Street} {src.Address.Number}")
            )
            .ForMember(
                dest => dest.CustomerName,
                opt => opt.MapFrom(src => src.Name)
            )
            .ForMember(
                dest => dest.Postal,
                opt => opt.MapFrom(src => src.Address.Postal)
            )
            .ForMember(
                dest => dest.VatNumber,
                opt => opt.MapFrom(src => $"{src.VatNumber}")
            );
            CreateMap<List<Order>, BestelbonDTO>()
            .ForMember(
                dest => dest.CustomerName,
                opt => opt.MapFrom(src => src[0].Customer.CustomerName)
            )
            .ForMember(
                dest => dest.Orders,
                opt => opt.MapFrom(src => src)
            )
           ;

        }
    }
}
