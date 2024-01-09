Sure, here is the BookProfile.cs for AutoMapper configuration for the Application module:

```csharp
using AutoMapper;
using VirtualLibrary.Core.Entities;
using VirtualLibrary.Application.DTOs;

namespace VirtualLibrary.Application.Mappings
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookDTO>();
            CreateMap<BookDTO, Book>();
        }
    }
}