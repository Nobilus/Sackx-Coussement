using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        Task<CustomerDTO> GetCustomer(int customerId);
        Task<List<CustomerDTO>> GetCustomers();
        Task<List<ProductDTO>> GetProducts(string orderby);
        Task<ProductDTO> GetProduct(Guid id);
        Task<List<StaffDTO>> GetStaffs();
        Task<StaffDTO> GetStaff(int id);
        Task<StaffAddDTO> AddStaff(StaffAddDTO staffmember);
        Task<Order> AddOrder(OrderDTO order);
        Task<List<OrdersDTO>> GetOrders();
        Task<OrdersDTO> GetOrder(Guid id);
        Task<CustomerAddDTO> AddCustomer(CustomerAddDTO customer);
        Task<ProductAddDTO> AddProduct(ProductAddDTO product);
        Task<List<Unit>> GetUnits();
    }


    public class WoodshopService : IWoodshopService
    {
        private ICustomerRepository _customerRepository;
        private IProductRepository _productRepository;
        private IStaffRepository _staffRepository;
        private IOrderRepository _orderRepository;
        private IPersonRepository _personRepository;
        private IUnitRepository _unitRepository;
        private IMapper _mapper;

        private double VAT = 1.21;

        public WoodshopService(IMapper mapper, ICustomerRepository customerRepository, IProductRepository productRepository, IStaffRepository staffRepository, IOrderRepository orderRepository, IPersonRepository personRepository, IUnitRepository unitRepository)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _staffRepository = staffRepository;
            _orderRepository = orderRepository;
            _personRepository = personRepository;
            _unitRepository = unitRepository;
            _mapper = mapper;

        }

        public async Task<List<ProductDTO>> GetProducts(string orderby)
        {
            List<ProductDTO> products = _mapper.Map<List<ProductDTO>>(await _productRepository.GetProducts());
            products.ForEach(p => p.PriceWithVat = Math.Round(p.Price * 1.21, 2));

            string[] allowdQueries = { "price", "name", "thickness", "unit" };
            if (allowdQueries.Contains(orderby))
            {
                var param = typeof(ProductDTO).GetProperty(orderby, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                return products.OrderBy(p => param.GetValue(p, null)).ToList<ProductDTO>();
            }
            else
            {
                return products;
            }
        }

        public async Task<ProductDTO> GetProduct(Guid id)
        {
            try
            {
                ProductDTO product = _mapper.Map<ProductDTO>(await _productRepository.GetProduct(id));
                product.PriceWithVat = Math.Round(product.Price * 1.21, 2);
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ProductAddDTO> AddProduct(ProductAddDTO product)
        {
            try
            {
                Product newProduct = _mapper.Map<Product>(product);
                newProduct.ProductId = Guid.NewGuid();
                await _productRepository.AddProduct(newProduct);
                return product;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        public async Task<CustomerDTO> GetCustomer(int customerId)
        {
            try
            {
                return _mapper.Map<CustomerDTO>(await _customerRepository.GetCustomer(customerId));
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

        public async Task<List<StaffDTO>> GetStaffs()
        {
            return _mapper.Map<List<StaffDTO>>(await _staffRepository.GetStaffMembers());
        }

        public async Task<StaffDTO> GetStaff(int id)
        {
            return _mapper.Map<StaffDTO>(await _staffRepository.GetStaffMember(id));
        }

        public async Task<StaffAddDTO> AddStaff(StaffAddDTO staff)
        {
            try
            {
                Person newPerson = _mapper.Map<Person>(staff);
                newPerson = await _personRepository.AddPerson(newPerson);

                Staff newStaff = _mapper.Map<Staff>(staff);
                newStaff.PersonId = newPerson.PersonId;

                await _staffRepository.AddStaffMember(newStaff);
                return staff;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        public async Task<List<Unit>> GetUnits()
        {
            try
            {
                return await _unitRepository.GetUnits();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        public async Task<Order> AddOrder(OrderDTO order)
        {
            try
            {
                Order newOrder = _mapper.Map<Order>(order);
                newOrder.OrderId = Guid.NewGuid();
                newOrder.Date = DateTime.Now.Date;
                newOrder.OrderProducts = new List<OrderProduct>();

                foreach (var p in order.Products)
                {
                    newOrder.OrderProducts.Add(new OrderProduct() { ProductId = p.Id, OrderId = newOrder.OrderId, Quantity = p.Amount, IsPayed = false });
                }
                string json = JsonConvert.SerializeObject(newOrder, Formatting.Indented);
                System.Console.WriteLine(json);

                await _orderRepository.AddOrder(newOrder);
                return newOrder;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.InnerException.Message);
                throw ex;
            }
        }

        public async Task<List<OrdersDTO>> GetOrders()
        {
            try
            {
                List<OrdersDTO> orders = _mapper.Map<List<OrdersDTO>>(await _orderRepository.GetOrders());
                // TODO: calculate owed amount
                foreach (var order in orders)
                {
                    double total = 0.00;
                    foreach (var product in order.OrderDetails)
                    {
                        product.PriceWithVat = Math.Round(product.Price * VAT, 2);
                        total += product.Quantity * product.PriceWithVat;
                    }
                    order.Indebted = total;
                }
                return orders;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.InnerException);
                throw ex;
            }
        }

        public async Task<OrdersDTO> GetOrder(Guid id)
        {
            try
            {
                OrdersDTO order = _mapper.Map<OrdersDTO>(await _orderRepository.GetOrder(id));
                double total = 0.00;

                foreach (var p in order.OrderDetails)
                {
                    p.PriceWithVat = Math.Round(p.Price * 1.21, 2);
                    total += Math.Round(p.Quantity * p.PriceWithVat, 2);

                }
                order.Indebted = total;
                order.VAT = Math.Round(total * 0.21, 2);
                return order;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
