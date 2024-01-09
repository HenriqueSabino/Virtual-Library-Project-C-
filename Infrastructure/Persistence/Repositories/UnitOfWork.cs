using Core.Interfaces;
using Infrastructure.Persistence.Contexts;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext _context;
        private bool _disposed;

        public UnitOfWork(LibraryContext context)
        {
            _context = context;
        }

        public IBookRepository Books => new BookRepository(_context);

        public IStudentRepository Students => new StudentRepository(_context);

        public ILibrarianRepository Librarians => new LibrarianRepository(_context);

        public IAdministratorRepository Administrators => new AdministratorRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}