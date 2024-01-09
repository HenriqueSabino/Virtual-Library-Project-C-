using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IAdministratorRepository
    {
        Task<Administrator> GetByIdAsync(int id);
        Task<IEnumerable<Administrator>> GetAllAsync();
        Task AddAsync(Administrator administrator);
        Task UpdateAsync(Administrator administrator);
        Task DeleteAsync(Administrator administrator);
    }
}