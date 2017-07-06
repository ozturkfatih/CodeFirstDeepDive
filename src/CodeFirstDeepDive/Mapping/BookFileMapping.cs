using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class BookFileMapping:IEntityMappingConfiguration<BookFile>
    {
        public void Map(EntityTypeBuilder<BookFile> builder)
        {
            builder.ToTable("BookFile");
            /*Relations*/
            builder
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookFiles)
                .HasForeignKey(ba => ba.BookId);
            builder
                .HasOne(ba => ba.File)
                .WithMany(b => b.BookFiles)
                .HasForeignKey(ba => ba.FileId);
        }
    }
}