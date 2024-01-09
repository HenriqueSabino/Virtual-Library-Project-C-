using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualLibrary.Core.Interfaces;
using VirtualLibrary.Application.DTOs;
using VirtualLibrary.Application.Interfaces;
using AutoMapper;

namespace VirtualLibrary.Application.Services
{
    public class LibrarianService : ILibrarianService
    {
        private readonly ILibrarianRepository _librarianRepository;
        private readonly IMapper _mapper;

        public LibrarianService(ILibrarianRepository librarianRepository, IMapper mapper)
        {
            _librarianRepository = librarianRepository ?? throw new ArgumentNullException(nameof(librarianRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<LibrarianDTO>> GetAllLibrariansAsync()
        {
            var librarians = await _librarianRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<LibrarianDTO>>(librarians);
        }

        public async Task<LibrarianDTO> GetLibrarianByIdAsync(Guid id)
        {
            var librarian = await _librarianRepository.GetByIdAsync(id);
            return _mapper.Map<LibrarianDTO>(librarian);
        }

        public async Task<LibrarianDTO> CreateLibrarianAsync(LibrarianDTO librarianDTO)
        {
            var librarian = _mapper.Map<Core.Entities.Librarian>(librarianDTO);
            librarian = await _librarianRepository.AddAsync(librarian);
            return _mapper.Map<LibrarianDTO>(librarian);
        }

        public async Task UpdateLibrarianAsync(LibrarianDTO librarianDTO)
        {
            var librarian = _mapper.Map<Core.Entities.Librarian>(librarianDTO);
            await _librarianRepository.UpdateAsync(librarian);
        }

        public async Task DeleteLibrarianAsync(Guid id)
        {
            var librarian = await _librarianRepository.GetByIdAsync(id);
            if (librarian != null)
            {
                await _librarianRepository.DeleteAsync(librarian);
            }
        }
    }
}