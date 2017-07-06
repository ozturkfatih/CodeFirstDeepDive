using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class BookTagMapping:IEntityMappingConfiguration<BookTag>
    {
        public void Map(EntityTypeBuilder<BookTag> builder)
        {
            builder.ToTable("BookTag");
            /*Relations*/
            builder
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookTags)
                .HasForeignKey(ba => ba.BookId);
            builder
                .HasOne(ba => ba.Tag)
                .WithMany(b => b.BookTags)
                .HasForeignKey(ba => ba.TagId);
        }
    }
}