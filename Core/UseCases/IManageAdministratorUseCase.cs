using System;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.UseCases
{
    public interface IManageAdministratorUseCase
    {
        Task<Administrator> GetAdministratorAsync(Guid administratorId);
        Task UpdateAdministratorAsync(Administrator administrator);
        Task DeleteAdministratorAsync(Guid administratorId);
    }
}