using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Models;
using Project.Repositories;

namespace Project.Services
{
    public class WoodshopService
    {
        private ICustomerRepository _customerRepository;
        private IProductRepository _productRepository;
        // private IMapper _mapper;

        public WoodshopService(ICustomerRepository customerRepository, IProductRepository productRepository)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
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
