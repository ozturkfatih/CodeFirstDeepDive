using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Mapping
{
    public class TagMapping:IEntityMappingConfiguration<Tag>
    {
        public void Map(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag");
        }
    }
}