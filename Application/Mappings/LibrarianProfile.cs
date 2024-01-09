using AutoMapper;
using VirtualLibrary.Application.DTOs;
using VirtualLibrary.Core.Entities;

namespace VirtualLibrary.Application.Mappings
{
    public class LibrarianProfile : Profile
    {
        public LibrarianProfile()
        {
            CreateMap<Librarian, LibrarianDTO>();
            CreateMap<LibrarianDTO, Librarian>();
        }
    }
}