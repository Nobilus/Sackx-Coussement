using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.DataContext;
using Project.Models;

namespace Project.Repositories
{
    public interface IStaffRepository
    {
        Task<List<Staff>> GetStaffMembers();
        Task<Staff> GetStaffMember(int id);
        Task<Staff> AddStaffMember(Staff staff);
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

        public async Task<Staff> GetStaffMember(int id)
        {
            return await _context.Staff.Include(s => s.Person).Where(s => s.PersonId == id).SingleOrDefaultAsync();
        }

        public async Task<Staff> AddStaffMember(Staff staff)
        {
            await _context.Staff.AddAsync(staff);
            await _context.SaveChangesAsync();

            return staff;
        }
    }
}
