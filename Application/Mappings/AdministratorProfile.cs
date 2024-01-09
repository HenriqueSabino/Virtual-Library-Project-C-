using AutoMapper;
using VirtualLibrary.Application.DTOs;
using VirtualLibrary.Core.Entities;

namespace VirtualLibrary.Application.Mappings
{
    public class AdministratorProfile : Profile
    {
        public AdministratorProfile()
        {
            CreateMap<Administrator, AdministratorDTO>().ReverseMap();
        }
    }
}