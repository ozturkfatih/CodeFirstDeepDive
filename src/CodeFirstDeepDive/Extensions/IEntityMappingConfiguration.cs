using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstDeepDive.Extensions
{
    public interface IEntityMappingConfiguration<T> where T : class
    {
        void Map(EntityTypeBuilder<T> builder);
    }

}