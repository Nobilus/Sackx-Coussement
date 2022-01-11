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
        Task<List<Order>> GetBestelbons();
        Task<List<Order>> GetOffertes();
        Task<Order> GetOrder(Guid id);
        Task<Order> SwitchOrderType(Guid id);

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
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .ThenInclude(op => op.Unit)
                .ToListAsync();
        }

        public async Task<List<Order>> GetBestelbons()
        {
            return await _context.Orders
                .Where(o => o.OrderType == "bestelbon")
                .Include(o => o.Customer)
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .ThenInclude(op => op.Unit)
                .ToListAsync();
        }
        public async Task<List<Order>> GetOffertes()
        {
            return await _context.Orders
                .Where(o => o.OrderType == "offerte")
                .Include(o => o.Customer)
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
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .ThenInclude(op => op.Unit)
                .SingleOrDefaultAsync();
        }

        public async Task<Order> SwitchOrderType(Guid id)
        {
            Order o = _context.Orders.FirstOrDefault(o => o.OrderId == id);
            switch (o.OrderType)
            {
                case "factuur":
                    o.OrderType = "bestelbon";
                    break;
                case "bestelbon":
                    o.OrderType = "factuur";
                    break;
                default:
                    o.OrderType = "bestelbon";
                    break;
            }
            await _context.SaveChangesAsync();
            return o;
        }
    }
}
