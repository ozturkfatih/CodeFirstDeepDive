using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class BookAuthorMapping : IEntityMappingConfiguration<BookAuthor>
    {
        public void Map(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.ToTable("BookAuthor");
            /*Relations*/
            builder
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.AuthorId);
            builder
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.AuthorId);
        }
    }

}