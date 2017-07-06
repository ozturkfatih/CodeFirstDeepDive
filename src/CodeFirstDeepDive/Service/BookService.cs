using System.Collections.Generic;
using System.Linq;
using CodeFirstDeepDive.Data;
using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Enums;

namespace CodeFirstDeepDive.Service
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _dbContext;

        public BookService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<IGrouping<BookLevel, Book>> GetBooksLevelGroup()
        {
            var query =
                from c in _dbContext.Books
                group c by c.BookLevel
                into g
                select g;
            return query;
        }

        public int Create(Book book)
        {
            throw new System.NotImplementedException();
        }

        public int Update(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}