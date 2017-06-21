using System.Collections.Generic;

namespace CodeFirstDeepDive.Entity
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Relations
        public ICollection<BookTag> BookTags { get; set; }
    }
}