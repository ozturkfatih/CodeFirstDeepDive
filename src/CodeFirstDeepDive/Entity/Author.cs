using System.Collections.Generic;

namespace CodeFirstDeepDive.Entity
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual string FullName => $"{FirstName} {LastName}";

        //Relations
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}