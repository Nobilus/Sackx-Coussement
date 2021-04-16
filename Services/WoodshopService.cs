using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Project.DTO;
using Project.Models;
using Project.Repositories;

namespace Project.Services
{
    public interface IWoodshopService
    {
        Task<Customer> GetCustomer(int customerId);
        Task<List<Customer>> GetCustomers();
        Task<List<ProductDTO>> GetProducts();

    }


    public class WoodshopService : IWoodshopService
    {
        private ICustomerRepository _customerRepository;
        private IProductRepository _productRepository;
        private IMapper _mapper;

        public WoodshopService(IMapper mapper, ICustomerRepository customerRepository, IProductRepository productRepository)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDTO>> GetProducts()
        {
            return _mapper.Map<List<ProductDTO>>(await _productRepository.GetProducts());
        }

        public async Task<Customer> GetCustomer(int customerId)
        {
            try
            {
                return await _customerRepository.GetCustomer(customerId);
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _customerRepository.GetCustomers();
        }


    }
}
