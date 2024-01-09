using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface ILibrarianService
    {
        Task<IEnumerable<LibrarianDTO>> GetAllLibrariansAsync();
        Task<LibrarianDTO> GetLibrarianByIdAsync(int id);
        Task<LibrarianDTO> CreateLibrarianAsync(LibrarianDTO librarianDto);
        Task UpdateLibrarianAsync(LibrarianDTO librarianDto);
        Task DeleteLibrarianAsync(int id);
    }
}