using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualLibrary.Application.DTOs;

namespace VirtualLibrary.Application.Interfaces
{
    public interface IAdministratorService
    {
        Task<IEnumerable<AdministratorDTO>> GetAllAdministratorsAsync();
        Task<AdministratorDTO> GetAdministratorByIdAsync(int id);
        Task<AdministratorDTO> CreateAdministratorAsync(AdministratorDTO administratorDto);
        Task UpdateAdministratorAsync(int id, AdministratorDTO administratorDto);
        Task DeleteAdministratorAsync(int id);
    }
}