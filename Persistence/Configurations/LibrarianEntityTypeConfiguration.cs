using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualLibrary.Core.Entities;

namespace VirtualLibrary.Persistence.Configurations
{
    public class LibrarianEntityTypeConfiguration : IEntityTypeConfiguration<Librarian>
    {
        public void Configure(EntityTypeBuilder<Librarian> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(l => l.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(l => l.Email)
                .IsRequired()
                .HasMaxLength(100);

            // Additional configuration as needed (indexes, relationships, etc.)
        }
    }
}