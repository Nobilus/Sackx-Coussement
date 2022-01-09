using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.DTO;
using Project.Models;
using Project.Repositories;
using RestSharp;
using Woodshop.API.DTO;
using Woodshop.API.Models;
using Woodshop.API.Repositories;

namespace Project.Services
{
    public interface IWoodshopService
    {
        Task<CustomerDTO> GetCustomer(Guid customerId);
        Task<List<CustomerDTO>> GetCustomers(string query);
        Task<List<ProductDTO>> GetProducts(string orderby, string query);
        Task<ProductDTO> GetProduct(Guid id);
        Task<List<StaffDTO>> GetStaffs();
        Task<StaffDTO> GetStaff(int id);
        Task<StaffAddDTO> AddStaff(StaffAddDTO staffmember);
        Task<Order> AddOrder(OrderDTO order);
        Task<List<OrdersDTO>> GetOrders();
        Task<List<List<OrdersDTO>>> GetBestelbons();
        Task<OrdersDTO> GetOrder(Guid id);
        Task<Order> SwitchOrderType(Guid id);
        Task<CustomerAddDTO> AddCustomer(CustomerAddDTO customer);
        Task<ProductAddDTO> AddProduct(ProductAddDTO product);
        Task<List<Unit>> GetUnits();
        Task<List<ProductgroupDTO>> ListProductgroupsWithProducts(string query);
        Task<List<ProductGroup>> ListProductgroups();
        Task<Customer> ValidateVatnumber(string vatNumber);

    }


    public class WoodshopService : IWoodshopService
    {
        private ICustomerRepository _customerRepository;
        private IProductRepository _productRepository;
        private IStaffRepository _staffRepository;
        private IOrderRepository _orderRepository;
        private IPersonRepository _personRepository;
        private IUnitRepository _unitRepository;
        private IProductGroupRepository _productgroupRepository;
        private IMapper _mapper;

        private double VAT = 1.21;

        public WoodshopService(IMapper mapper, ICustomerRepository customerRepository, IProductRepository productRepository, IStaffRepository staffRepository, IOrderRepository orderRepository, IPersonRepository personRepository, IUnitRepository unitRepository, IProductGroupRepository productGroupRepository)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _staffRepository = staffRepository;
            _orderRepository = orderRepository;
            _personRepository = personRepository;
            _unitRepository = unitRepository;
            _productgroupRepository = productGroupRepository;
            _mapper = mapper;

        }

        private string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public async Task<List<ProductDTO>> GetProducts(string orderby, string query)
        {
            List<ProductDTO> products = _mapper.Map<List<ProductDTO>>(await _productRepository.GetProducts());
            products.ForEach(p => p.PriceWithVat = Math.Round(p.Price * 1.21, 2));

            string[] allowdQueries = { "price", "name", "thickness", "unit" };
            if (!String.IsNullOrEmpty(query))
            {
                if (allowdQueries.Contains(orderby))
                {
                    var param = typeof(ProductDTO).GetProperty(orderby, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    return products.Where(p => RemoveSpecialCharacters(p.Name.ToLower()).Contains(query.ToLower())).OrderBy(p => param.GetValue(p, null)).ToList<ProductDTO>();
                }
                else
                {
                    return products.Where(p => RemoveSpecialCharacters(p.Name.ToLower()).Contains(query.ToLower())).OrderBy(p => p.Name).ToList<ProductDTO>();
                }
            }
            else if (allowdQueries.Contains(orderby))
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
                throw ex;
            }
        }

        public async Task<CustomerDTO> GetCustomer(Guid customerId)
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

        public async Task<List<CustomerDTO>> GetCustomers(string query)
        {
            try
            {
                List<CustomerDTO> customers = _mapper.Map<List<CustomerDTO>>(await _customerRepository.GetCustomers(query));
                return customers;
            }
            catch (System.Exception ex)
            {
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

                await _customerRepository.AddCustomer(newCustomer);
                return customer;
            }
            catch (Exception ex)
            {
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
                await _orderRepository.AddOrder(newOrder);
                return newOrder;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<List<OrdersDTO>>> GetBestelbons()
        {
            try
            {
                List<OrdersDTO> orders = _mapper.Map<List<OrdersDTO>>(await _orderRepository.GetBestelbons());
                foreach (var order in orders)
                {
                    double total = 0.00;
                    foreach (var product in order.OrderDetails)
                    {
                        product.PriceWithVat = Math.Round(product.Price * VAT, 2);
                        total += product.Quantity * product.Price;
                    }
                    order.Indebted = total;
                    order.VAT = Math.Round(total * 0.21, 2);
                }
                var groupedOrders = orders.GroupBy(o => o.CustomerName).Select(grp => grp.ToList()).ToList();
                return groupedOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<OrdersDTO>> GetOrders()
        {
            try
            {
                List<OrdersDTO> orders = _mapper.Map<List<OrdersDTO>>(await _orderRepository.GetOrders());
                foreach (var order in orders)
                {
                    double total = 0.00;
                    foreach (var product in order.OrderDetails)
                    {
                        product.PriceWithVat = Math.Round(product.Price * VAT, 2);
                        total += product.Quantity * product.Price;
                    }
                    order.Indebted = total;
                    order.VAT = Math.Round(total * 0.21, 2);
                }
                return orders;
            }
            catch (Exception ex)
            {
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
                    total += Math.Round(p.Quantity * p.Price, 2);

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

        public async Task<Order> SwitchOrderType(Guid id)
        {
            try
            {
                return await _orderRepository.SwitchOrderType(id); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<ProductgroupDTO>> ListProductgroupsWithProducts(string query)
        {
            try
            {
                List<ProductgroupDTO> productGroups = _mapper.Map<List<ProductgroupDTO>>(await _productgroupRepository.GetProductsWithGroups(query));
                foreach (ProductgroupDTO pg in productGroups)
                {
                    pg.Products.ToList<ProductDTO>().ForEach(p => p.PriceWithVat = Math.Round(p.Price * 1.21, 2));
                }
                return productGroups;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<ProductGroup>> ListProductgroups()
        {
            try
            {
                return await _productgroupRepository.GetProductgroups();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Customer> ValidateVatnumber(string vatNumber)
        {
            try
            {
                var client = new RestClient($"https://controleerbtwnummer.eu/api/validate/{vatNumber}.json");
                var request = new RestRequest(Method.GET);
                request.AddHeader("content-type", "application/json");

                IRestResponse response = await client.ExecuteAsync(request);

                Customer customer = _mapper.Map<Customer>(JsonConvert.DeserializeObject<APICustomer>(response.Content));
                return customer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
