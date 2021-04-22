using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;
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
        Task<Order> AddOrder(OrderDTO order);
        Task<CustomerAddDTO> AddCustomer(CustomerAddDTO customer);

    }


    public class WoodshopService : IWoodshopService
    {
        private ICustomerRepository _customerRepository;
        private IProductRepository _productRepository;
        private IStaffRepository _staffRepository;
        private IOrderRepository _orderRepository;
        private IPersonRepository _personRepository;
        private IMapper _mapper;

        public WoodshopService(IMapper mapper, ICustomerRepository customerRepository, IProductRepository productRepository, IStaffRepository staffRepository, IOrderRepository orderRepository, IPersonRepository personRepository)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _staffRepository = staffRepository;
            _orderRepository = orderRepository;
            _personRepository = personRepository;
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

        public async Task<Order> AddOrder(OrderDTO order)
        {
            try
            {
                Order newOrder = _mapper.Map<Order>(order);
                newOrder.isPayed = false;
                newOrder.OrderId = Guid.NewGuid();
                newOrder.Date = DateTime.Now;
                newOrder.OrderProducts = new List<OrderProduct>();

                foreach (var id in order.Products)
                {
                    newOrder.OrderProducts.Add(new OrderProduct() { ProductId = id, OrderId = newOrder.OrderId });
                }
                string json = JsonConvert.SerializeObject(newOrder, Formatting.Indented);
                System.Console.WriteLine(json);

                await _orderRepository.AddOrder(newOrder);
                return newOrder;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        public async Task<CustomerAddDTO> AddCustomer(CustomerAddDTO customer)
        {
            try
            {
                Person newPerson = _mapper.Map<Person>(customer);
                newPerson = await _personRepository.AddPerson(newPerson);

                Customer newCustomer = _mapper.Map<Customer>(customer);
                newCustomer.PersonId = newPerson.PersonId;

                await _customerRepository.AddCustomer(newCustomer);
                return customer;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

    }
}
