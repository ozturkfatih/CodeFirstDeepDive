using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class CategoryMapping : IEntityMappingConfiguration<Category>
    {
        public void Map(EntityTypeBuilder<Category> builder)
        {
            builder
                .ToTable("Category");
            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}