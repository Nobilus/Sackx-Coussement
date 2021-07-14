using System;
using System.Threading.Tasks;
using Project.DataContext;
using Project.Models;

namespace Project.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> AddPerson(Person person);
    }

    public class PersonRepository : IPersonRepository
    {
        // pers --> db
        private IWoodshopContext _context;
        public PersonRepository(IWoodshopContext context)
        {
            _context = context;
        }

        public async Task<Person> AddPerson(Person person)
        {
            await _context.Persons.AddAsync(person);
            await _context.SaveChangesAsync();
            return person;
        }
    }
}
