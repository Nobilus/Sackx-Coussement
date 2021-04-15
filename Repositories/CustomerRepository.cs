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
        Task<Customer> GetCustomer(int customerId);
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
            return await _context.Customers.Include(c => c.Person).ToListAsync();
        }

        public async Task<Customer> GetCustomer(int customerId)
        {
            return await _context.Customers.Where(c => c.PersonId == customerId)
            .Include(c => c.Person)
            .ThenInclude(p => p.FirstName)
            .Include(c => c.Person)
            .ThenInclude(p => p.LastName)
            .Include(p => p.Orders).SingleOrDefaultAsync();
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
        // TODO: remove customer function
    }
}
