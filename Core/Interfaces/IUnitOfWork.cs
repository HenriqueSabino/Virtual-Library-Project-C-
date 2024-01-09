using System;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        IStudentRepository Students { get; }
        ILibrarianRepository Librarians { get; }
        IAdministratorRepository Administrators { get; }
        Task<int> CompleteAsync();
    }
}