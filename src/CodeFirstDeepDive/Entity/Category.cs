using System.Collections.Generic;

namespace CodeFirstDeepDive.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}