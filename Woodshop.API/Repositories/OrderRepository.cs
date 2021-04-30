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
    public interface IOrderRepository
    {
        Task<Order> AddOrder(Order order);
        Task<List<Order>> GetOrders();
        Task<Order> GetOrder(Guid id);
    }

    public class OrderRepository : IOrderRepository
    {
        private IWoodshopContext _context;

        public OrderRepository(IWoodshopContext context)
        {
            _context = context;
        }

        public async Task<Order> AddOrder(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .ThenInclude(c => c.Person)
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .ThenInclude(op => op.Unit)
                .ToListAsync();
        }
        public async Task<Order> GetOrder(Guid id)
        {
            return await _context.Orders
                .Where(p => p.OrderId == id)
                .Include(o => o.Customer)
                .ThenInclude(c => c.Person)
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .ThenInclude(op => op.Unit)
                .SingleOrDefaultAsync();
        }
    }
}
