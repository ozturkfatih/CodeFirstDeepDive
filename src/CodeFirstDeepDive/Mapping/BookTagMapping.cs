using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class BookTagMapping:IEntityMappingConfiguration<BookTag>
    {
        public void Map(EntityTypeBuilder<BookTag> builder)
        {
            builder.ToTable("BookTag");
        }
    }
}