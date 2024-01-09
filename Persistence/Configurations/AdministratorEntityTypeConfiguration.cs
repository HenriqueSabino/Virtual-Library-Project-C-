using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entities;

namespace Persistence.Configurations
{
    public class AdministratorEntityTypeConfiguration : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> builder)
        {
            builder.ToTable("Administrators");

            builder.HasKey(administrator => administrator.Id);

            builder.Property(administrator => administrator.Id)
                .ValueGeneratedOnAdd();

            builder.Property(administrator => administrator.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(administrator => administrator.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(administrator => administrator.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasIndex(administrator => administrator.Email)
                .IsUnique();

            // Additional configuration can be added here as needed. For example:
            // builder.Property(administrator => administrator.DateOfBirth)
            //     .HasColumnType("Date");
        }
    }
}