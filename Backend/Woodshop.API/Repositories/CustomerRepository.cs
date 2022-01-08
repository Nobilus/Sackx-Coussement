using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.DataContext;
using Project.Models;

namespace Project.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> GetCustomer(Guid customerId);
        Task<List<Customer>> GetCustomers();
    }

    public class CustomerRepository : ICustomerRepository
    {
        private IWoodshopContext _context;

        public CustomerRepository(IWoodshopContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _context.Customers.Include(c => c.Orders).ToListAsync();
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
    }
}
