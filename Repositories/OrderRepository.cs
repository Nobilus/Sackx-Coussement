using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.DataContext;
using Project.DTO;
using Project.Models;

namespace Project.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> AddOrder(Order order);
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

        // public async Task<List<Order>> GetOrders()
        // {
        //     return await _context.Orders.
        // }
    }
}
