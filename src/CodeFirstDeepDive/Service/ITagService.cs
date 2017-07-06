using System.Collections.Generic;
using CodeFirstDeepDive.Entity;

namespace CodeFirstDeepDive.Service
{
    public interface ITagService
    {
        List<Tag> GetList();
    }
}