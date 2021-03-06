﻿using EmployeeManagerEngine.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EmployeeManagerEngine.Data.Command.Mappings
{
    internal class GenderMapping : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder
                .ToTable("GENDER")
                .HasKey(key => key.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).HasColumnType("varchar").IsRequired();
            builder.Property(p => p.Active).HasColumnName("is_active").HasColumnType("bit").HasDefaultValue(1).IsRequired();
            builder.Property(p => p.LastModified).HasColumnName("last_modified").HasColumnType("datetime").HasDefaultValue(DateTime.Now).IsRequired();
        }
    }
}
