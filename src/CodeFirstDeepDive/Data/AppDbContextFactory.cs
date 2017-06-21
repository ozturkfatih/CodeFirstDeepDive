using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CodeFirstDeepDive.Data
{
    public class AppDbContextFactory : IDbContextFactory<AppDbContext>
    {
        public AppDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookStoreDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new AppDbContext(builder.Options);
        }
    }
}