using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class BookFileMapping:IEntityMappingConfiguration<BookFile>
    {
        public void Map(EntityTypeBuilder<BookFile> builder)
        {
            builder.ToTable("BookFile");
        }
    }
}