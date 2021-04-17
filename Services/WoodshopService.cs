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
        Task<List<CustomerDTO>> GetCustomers();
        Task<List<ProductDTO>> GetProducts();
        Task<List<StaffDTO>> GetStaffs();

    }


    public class WoodshopService : IWoodshopService
    {
        private ICustomerRepository _customerRepository;
        private IProductRepository _productRepository;
        private IStaffRepository _staffRepository;
        private IMapper _mapper;

        public WoodshopService(IMapper mapper, ICustomerRepository customerRepository, IProductRepository productRepository, IStaffRepository staffRepository)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _staffRepository = staffRepository;
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

        public async Task<List<CustomerDTO>> GetCustomers()
        {
            return _mapper.Map<List<CustomerDTO>>(await _customerRepository.GetCustomers());
        }

        public async Task<List<StaffDTO>> GetStaffs()
        {
            return _mapper.Map<List<StaffDTO>>(await _staffRepository.GetStaffMembers());
        }

    }
}
