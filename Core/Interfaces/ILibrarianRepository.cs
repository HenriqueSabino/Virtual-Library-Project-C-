using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ILibrarianRepository
    {
        Task<IEnumerable<Librarian>> GetAllLibrariansAsync();
        Task<Librarian> GetLibrarianByIdAsync(Guid id);
        Task<Librarian> AddLibrarianAsync(Librarian librarian);
        Task UpdateLibrarianAsync(Librarian librarian);
        Task DeleteLibrarianAsync(Guid id);
    }
}