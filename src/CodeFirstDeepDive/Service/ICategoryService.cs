using System.Collections.Generic;
using CodeFirstDeepDive.Entity;

namespace CodeFirstDeepDive.Service
{
    public interface ICategoryService
    {
        List<Category> GetList();
        List<Category> GetListLinq();
    }
}