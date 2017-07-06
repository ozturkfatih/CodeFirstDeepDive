using System.Collections.Generic;
using System.Linq;
using System.Threading;
using CodeFirstDeepDive.Data;
using CodeFirstDeepDive.Entity;

namespace CodeFirstDeepDive.Service
{
    public class TagService : ITagService
    {
        private readonly AppDbContext _dbContext;

        public TagService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Tag> GetList()
        {

            using (var context = _dbContext)
            {
                return context.Tags.ToList();
            }
        }
    }
}