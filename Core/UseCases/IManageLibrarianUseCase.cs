using Core.Entities;

namespace Core.UseCases
{
    public interface IManageLibrarianUseCase
    {
        void CreateLibrarian(Librarian librarian);
        void UpdateLibrarian(Librarian librarian);
        void DeleteLibrarian(int librarianId);
        Librarian GetLibrarian(int librarianId);
        IEnumerable<Librarian> GetAllLibrarians();
    }
}