using AutoMapper;
using Core.Entities;
using Application.DTOs;

namespace Application.Mappings
{
    public class LoanProfile : Profile
    {
        public LoanProfile()
        {
            // Mapping from Book entity to BookDTO and vice versa
            CreateMap<Book, BookDTO>().ReverseMap();
            
            // Mapping from Student entity to StudentDTO and vice versa
            CreateMap<Student, StudentDTO>().ReverseMap();
        }
    }
}