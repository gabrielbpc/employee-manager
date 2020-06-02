using EmployeeManagerEngine.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EmployeeManagerEngine.Data.Command.Mappings
{
    internal class EmployeeMapping : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .ToTable("EMPLOYEE")
                .HasKey(key => key.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
            builder.Property(p => p.LastModified).HasColumnName("last_modified").HasColumnType("datetime").HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(p => p.Active).HasColumnName("is_active").HasColumnType("bit").HasDefaultValue(1).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(50).HasColumnType("varchar").IsRequired();
            builder.Property(p => p.LastName).HasColumnName("last_name").HasMaxLength(100).HasColumnType("varchar").IsRequired();
            builder.Property(p => p.Born).HasColumnName("born_date").HasColumnType("datetime").IsRequired();
            builder.Property(p => p.Email).HasColumnName("email").HasMaxLength(100).HasColumnType("varchar");
            builder.Property(p => p.GenderId).HasColumnName("gender_id").HasMaxLength(100).HasColumnType("varchar").IsRequired();

            builder.HasOne(p => p.Gender).WithMany(p => p.Employees).HasForeignKey(fk => fk.GenderId).IsRequired();
        }
    }
}
