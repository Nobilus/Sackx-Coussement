using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.DataContext;
using Woodshop.API.Models;

namespace Woodshop.API.Repositories
{
    public interface IProductGroupRepository
    {
        Task<List<ProductGroup>> GetProductgroups();
        Task<List<ProductGroup>> GetProductsWithGroups(string query = null);
    }

    public class ProductGroupRepository : IProductGroupRepository

    {
        private IWoodshopContext _context;
        public ProductGroupRepository(IWoodshopContext context)
        {
            _context = context;
        }

        public async Task<List<ProductGroup>> GetProductsWithGroups(string query = null)
        {
            if (String.IsNullOrEmpty(query))
            {
                return await _context.ProductGroups.Include(pg => pg.Products).ToListAsync<ProductGroup>();
            }
            else
            {
                return await _context.ProductGroups.Include(pg => pg.Products.Where(p => p.Name.Contains(query))).ToListAsync<ProductGroup>();
            }

        }

        public async Task<List<ProductGroup>> GetProductgroups()
        {
            return await _context.ProductGroups.ToListAsync<ProductGroup>();
        }

    }
}
