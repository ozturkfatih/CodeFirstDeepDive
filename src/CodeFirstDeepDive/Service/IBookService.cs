using System.Collections.Generic;
using System.Linq;
using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Enums;

namespace CodeFirstDeepDive.Service
{
    public interface IBookService
    {
        IQueryable<IGrouping<BookLevel, Book>> GetBooksLevelGroup();
        int Create(Book book);
        int Update(int id);
        int Delete(int id);
    }
}