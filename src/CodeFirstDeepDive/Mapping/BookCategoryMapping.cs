using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class BookCategoryMapping : IEntityMappingConfiguration<BookCategory>
    {
        public void Map(EntityTypeBuilder<BookCategory> builder)
        {
            builder.ToTable("BookCategory");
            /*Relations*/
            builder
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(ba => ba.BookId);
            builder
                .HasOne(ba => ba.Category)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(ba => ba.CategoryId);
        }
    }
}