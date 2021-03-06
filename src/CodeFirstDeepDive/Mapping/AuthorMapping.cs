﻿using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class AuthorMapping : IEntityMappingConfiguration<Author>
    {
        public void Map(EntityTypeBuilder<Author> builder)
        {
            builder
                .ToTable("Author");
            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}