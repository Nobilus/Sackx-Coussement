using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.DataContext;
using Project.Models;

namespace Project.Repositories
{
    public interface IProductRepository
    {
        Task<Product> AddProduct(Product product);
        Task<Product> GetProduct(Guid productId);
        Task<List<Product>> GetProducts();
    }

    public class ProductRepository : IProductRepository
    {
        private IWoodshopContext _context;

        public ProductRepository(IWoodshopContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products
                                    .Include(p => p.Unit)
                                    .Include(p => p.ProductGroup)
                                    .OrderBy(p => p.Name)
                                    .ToListAsync();
        }

        public async Task<Product> AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetProduct(Guid productId)
        {
            return await _context.Products
                                    .Include(p => p.Unit)
                                    .Include(p => p.ProductGroup)
                                    .Where(p => p.ProductId == productId)
                                    .SingleOrDefaultAsync();
        }
    }
}
