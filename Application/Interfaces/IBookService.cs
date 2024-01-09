using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualLibrary.Application.DTOs;

namespace VirtualLibrary.Application.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookDTO>> GetAllBooksAsync();
        Task<BookDTO> GetBookByIdAsync(int id);
        Task<BookDTO> RegisterBookAsync(BookDTO bookDto);
        Task<BookDTO> UpdateBookAsync(int id, BookDTO bookDto);
        Task<bool> DeleteBookAsync(int id);
        Task<BookDTO> RentBookAsync(int bookId, int studentId);
        Task<BookDTO> ReturnBookAsync(int bookId);
    }
}