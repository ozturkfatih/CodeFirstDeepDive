using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class FileMapping:IEntityMappingConfiguration<File>
    {
        public void Map(EntityTypeBuilder<File> builder)
        {
            builder.ToTable("File");
        }
    }
}