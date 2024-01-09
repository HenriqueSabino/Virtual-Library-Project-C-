using System.Threading.Tasks;
using Core.Entities;

namespace Core.UseCases
{
    public interface IRegisterLibrarianUseCase
    {
        Task RegisterLibrarianAsync(Librarian librarian);
    }
}