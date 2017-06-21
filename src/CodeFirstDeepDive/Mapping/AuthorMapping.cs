using CodeFirstDeepDive.Entity;
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
            /**
             * Relationships
             */
            builder
                .HasMany(p => p.Books)
                .WithOne(p => p.Author)
                .HasForeignKey(c => c.AuthorId)
                .ForSqlServerHasConstraintName("ForeignKey_Book_Author_AuthorId");
        }
    }
}