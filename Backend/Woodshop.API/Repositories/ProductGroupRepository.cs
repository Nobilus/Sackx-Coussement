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
        Task<List<ProductGroup>> GetProductsWithGroups();
    }

    public class ProductGroupRepository : IProductGroupRepository

    {
        private IWoodshopContext _context;
        public ProductGroupRepository(IWoodshopContext context)
        {
            _context = context;
        }

        public async Task<List<ProductGroup>> GetProductsWithGroups()
        {
            return await _context.ProductGroups.Include(pg => pg.Products).ToListAsync<ProductGroup>();
        }

        public async Task<List<ProductGroup>> GetProductgroups()
        {
            return await _context.ProductGroups.ToListAsync<ProductGroup>();
        }

    }
}
