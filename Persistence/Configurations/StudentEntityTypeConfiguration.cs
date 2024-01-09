using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entities;

namespace Persistence.Configurations
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.DateOfBirth)
                .IsRequired();

            // Additional configurations
            // Define relationships if necessary here. For instance:
            // builder.HasMany(s => s.Rentals)
            //        .WithOne(r => r.Student)
            //        .HasForeignKey(r => r.StudentId);

            // Custom configurations can also be defined. For example:
            // builder.Property(s => s.Status)
            //        .HasConversion(
            //            v => v.ToString(),
            //            v => (StudentStatus)Enum.Parse(typeof(StudentStatus), v));
        }
    }
}