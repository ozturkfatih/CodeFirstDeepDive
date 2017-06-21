using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class BookWordMapping:IEntityMappingConfiguration<BookWord>
    {
        public void Map(EntityTypeBuilder<BookWord> builder)
        {
            builder
                .ToTable("BookWord");
        }
    }
}