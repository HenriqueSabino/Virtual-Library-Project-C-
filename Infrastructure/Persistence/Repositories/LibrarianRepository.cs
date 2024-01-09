using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class LibrarianRepository : ILibrarianRepository
    {
        private readonly VirtualLibraryDbContext _dbContext;

        public LibrarianRepository(VirtualLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Librarian>> GetAllLibrariansAsync()
        {
            return await _dbContext.Librarians.ToListAsync();
        }

        public async Task<Librarian> GetLibrarianByIdAsync(int id)
        {
            return await _dbContext.Librarians.FindAsync(id);
        }

        public async Task AddLibrarianAsync(Librarian librarian)
        {
            await _dbContext.Librarians.AddAsync(librarian);
        }

        public void UpdateLibrarian(Librarian librarian)
        {
            _dbContext.Entry(librarian).State = EntityState.Modified;
        }

        public void DeleteLibrarian(Librarian librarian)
        {
            _dbContext.Librarians.Remove(librarian);
        }
    }
}