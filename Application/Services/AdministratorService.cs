using Core.Entities;
using Core.Interfaces;
using Core.UseCases;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;

namespace Application.Services
{
    public class AdministratorService : IAdministratorService
    {
        private readonly IAdministratorRepository _administratorRepository;
        private readonly IRegisterAdministratorUseCase _registerAdministratorUseCase;
        private readonly IManageAdministratorUseCase _manageAdministratorUseCase;

        public AdministratorService(
            IAdministratorRepository administratorRepository,
            IRegisterAdministratorUseCase registerAdministratorUseCase,
            IManageAdministratorUseCase manageAdministratorUseCase)
        {
            _administratorRepository = administratorRepository;
            _registerAdministratorUseCase = registerAdministratorUseCase;
            _manageAdministratorUseCase = manageAdministratorUseCase;
        }

        public async Task<AdministratorDTO> RegisterAdministratorAsync(AdministratorDTO administratorDTO)
        {
            Administrator administrator = new Administrator
            {
                // Map DTO to Domain entity
                Name = administratorDTO.Name,
                Email = administratorDTO.Email,
                Password = administratorDTO.Password
            };
            await _registerAdministratorUseCase.RegisterAdministratorAsync(administrator);
            return administratorDTO; // Ideally, map the resulting entity back to a DTO before returning
        }

        public async Task<AdministratorDTO> GetAdministratorByIdAsync(int id)
        {
            Administrator administrator = await _administratorRepository.GetByIdAsync(id);
            return new AdministratorDTO
            {
                // Map Domain entity to DTO
                Id = administrator.Id,
                Name = administrator.Name,
                Email = administrator.Email
                // Do not expose sensitive data like passwords!
            };
        }

        public async Task UpdateAdministratorAsync(AdministratorDTO administratorDTO)
        {
            // Update logic to manage administrator
            await _manageAdministratorUseCase.UpdateAdministratorInfoAsync(
                administratorDTO.Id,
                administratorDTO.Name,
                administratorDTO.Email);
        }

        public async Task DeleteAdministratorAsync(int id)
        {
            await _manageAdministratorUseCase.DeleteAdministratorAsync(id);
        }
    }
}