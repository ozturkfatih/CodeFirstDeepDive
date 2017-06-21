using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class BookMapping:IEntityMappingConfiguration<Book>
    {
        public void Map(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            /**
             * Relationships
             */
            builder
                .HasOne(p => p.BookWord)
                .WithOne(p => p.Book)
                .HasForeignKey<BookWord>(c=>c.IdRef)
                .ForSqlServerHasConstraintName("ForeingKey_BookWord_Book_IdRef");
        }
    }
}