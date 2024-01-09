using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entities;

namespace Persistence.Configurations
{
    public class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");

            builder.HasKey(b => b.Id);
            
            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(200);
            
            builder.Property(b => b.Author)
                .IsRequired()
                .HasMaxLength(100);
                
            builder.Property(b => b.ISBN)
                .IsRequired()
                .HasMaxLength(13);
                
            builder.Property(b => b.Status)
                .IsRequired()
                .HasConversion<string>();
                
            // Additional fields and configurations can be added as per the requirements
            // This could include relationships, indexes, or any entity-specific configurations
        }
    }
}