using System.Threading.Tasks;
using Core.Entities;

namespace Core.UseCases
{
    public interface IRegisterBookUseCase
    {
        Task<Book> RegisterBookAsync(Book book);
    }
}