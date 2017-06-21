using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class BookMapping:IEntityMappingConfiguration<Book>
    {
        public void Map(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
        }
    }
}