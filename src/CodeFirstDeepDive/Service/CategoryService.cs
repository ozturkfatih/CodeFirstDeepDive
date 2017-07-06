using System.Collections.Generic;
using System.Linq;
using System.Threading;
using CodeFirstDeepDive.Data;
using CodeFirstDeepDive.Entity;

namespace CodeFirstDeepDive.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _dbContext;

        public CategoryService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Category> GetList()
        {
            return _dbContext.Categories.OrderBy(c=>c.Name).ToList();
        }
        public List<Category> GetListLinq()
        {
            //LINQ syntax
            var query =
                from c in _dbContext.Categories
                orderby c.Name
                select c;
            return query.ToList();
        }
    }
}