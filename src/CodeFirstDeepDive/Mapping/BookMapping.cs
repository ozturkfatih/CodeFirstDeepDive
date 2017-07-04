using System.ComponentModel.DataAnnotations.Schema;
using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class BookMapping : IEntityMappingConfiguration<Book>
    {
        public void Map(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(255);
            builder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(2000);
            builder
                .Property(p => p.Price)
                .IsRequired()
                .ForSqlServerHasColumnType("decimal(18,2)")
                .ForSqlServerHasDefaultValue(0);
            builder
                .Property(p => p.Version)
                .IsRequired(false)
                .HasMaxLength(255);
            builder
                .Property(p => p.Version)
                .IsRequired(false)
                .HasMaxLength(255);
            builder.Property(p => p.PublishDate)
                .ForSqlServerHasColumnType("datetime2(7)");
            /*Relationships*/
            /*1-1 Book-BookWord*/
            builder
                .HasOne(p => p.BookWord)
                .WithOne(p => p.Book)
                .HasForeignKey<BookWord>(c => c.IdRef)
                .OnDelete(DeleteBehavior.Cascade)
                .ForSqlServerHasConstraintName("ForeingKey_BookWord_Book_IdRef");
        }
    }
}