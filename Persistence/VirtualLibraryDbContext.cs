using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Persistence
{
    public class VirtualLibraryDbContext : DbContext
    {
        public VirtualLibraryDbContext(DbContextOptions<VirtualLibraryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply configurations for entity types
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(VirtualLibraryDbContext).Assembly);
        }
    }
}