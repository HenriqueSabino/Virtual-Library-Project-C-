using AutoMapper;
using VirtualLibrary.Application.DTOs;
using VirtualLibrary.Core.Entities;

namespace VirtualLibrary.Application.Mappings
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDTO>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.FirstName, opt => opt.MapFrom(entity => entity.FirstName))
                .ForMember(dto => dto.LastName, opt => opt.MapFrom(entity => entity.LastName))
                .ForMember(dto => dto.Email, opt => opt.MapFrom(entity => entity.Email))
                .ForMember(dto => dto.RentalHistory, opt => opt.MapFrom(entity => entity.RentalHistory));

            // Add additional mappings here if needed
        }
    }
}