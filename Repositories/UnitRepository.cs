using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.DataContext;
using Project.Models;

namespace Project.Repositories
{
    public interface IUnitRepository
    {
        Task<List<Unit>> GetUnits();
    }

    public class UnitRepository : IUnitRepository
    {
        private IWoodshopContext _context;

        public UnitRepository(IWoodshopContext context)
        {
            _context = context;
        }

        public async Task<List<Unit>> GetUnits()
        {
            return await _context.Units.ToListAsync<Unit>();
        }
    }
}
