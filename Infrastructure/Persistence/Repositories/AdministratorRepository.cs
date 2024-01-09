using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class AdministratorRepository : IAdministratorRepository
    {
        private readonly VirtualLibraryDbContext _dbContext;

        public AdministratorRepository(VirtualLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Administrator> GetByIdAsync(Guid id)
        {
            return await _dbContext.Administrators.FindAsync(id);
        }

        public IQueryable<Administrator> GetAll()
        {
            return _dbContext.Administrators.AsNoTracking();
        }

        public async Task AddAsync(Administrator administrator)
        {
            await _dbContext.Administrators.AddAsync(administrator);
        }

        public void Update(Administrator administrator)
        {
            _dbContext.Entry(administrator).State = EntityState.Modified;
        }

        public void Delete(Administrator administrator)
        {
            _dbContext.Administrators.Remove(administrator);
        }

        public async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}