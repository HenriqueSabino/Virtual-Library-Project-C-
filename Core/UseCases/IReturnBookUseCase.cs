using System.Threading.Tasks;
using Core.Entities;

namespace Core.UseCases
{
    public interface IReturnBookUseCase
    {
        Task ReturnBookAsync(Book book);
        Task SetBookStatusAsync(Book book, string status);
    }
}