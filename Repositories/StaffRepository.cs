using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.DataContext;
using Project.Models;

namespace Project.Repositories
{
    public interface IStaffRepository
    {
        Task<List<Staff>> GetStaffMembers();
    }

    public class StaffRepository : IStaffRepository
    {
        private IWoodshopContext _context;
        public StaffRepository(IWoodshopContext context)
        {
            _context = context;
        }

        public async Task<List<Staff>> GetStaffMembers()
        {
            return await _context.Staff.Include(s => s.Person).ToListAsync();
        }
    }
}
