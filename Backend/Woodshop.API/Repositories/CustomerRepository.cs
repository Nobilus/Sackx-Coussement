using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.DataContext;
using Project.DTO;
using Project.Models;

namespace Project.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> GetCustomer(Guid customerId);
        Task<List<Customer>> GetCustomers(string query = null);
        Task<Customer> CreateCustomerIfNotExists(Customer customer);
    }

    public class CustomerRepository : ICustomerRepository
    {
        private IWoodshopContext _context;

        public CustomerRepository(IWoodshopContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomers(string query = null)
        {
            if (String.IsNullOrEmpty(query))
            {
                return await _context.Customers.Include(c => c.Orders).OrderBy(c => c.CustomerName).ToListAsync();
            }
            else
            {
                return await _context.Customers.Where(c => c.CustomerName.Contains(query)).Include(c => c.Orders).OrderBy(c => c.CustomerName).ToListAsync();
            }

        }

        public async Task<Customer> GetCustomer(Guid customerId)
        {
            return await _context.Customers.Where(c => c.CustomerId == customerId)
            .Include(c => c.Orders)
            .SingleOrDefaultAsync();
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> CreateCustomerIfNotExists(Customer customer)
        {
            Customer c = await _context.Customers.Where(c => c.CustomerName == customer.CustomerName).FirstOrDefaultAsync();
            if (c == null)
            {
                return await AddCustomer(customer);
            }
            return c;
        }
    }
}
