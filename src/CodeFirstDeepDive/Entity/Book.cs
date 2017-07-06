using System;
using System.Collections.Generic;
using CodeFirstDeepDive.Enums;

namespace CodeFirstDeepDive.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Version { get; set; }
        public string Number { get; set; }
        public DateTime PublishDate { get; set; }
        public BookLength BookLength { get; set; }
        public BookLevel BookLevel { get; set; }
        public BookWord BookWord { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<BookCategory> BookCategories { get; set; }
        public virtual ICollection<BookTag> BookTags { get; set; }
        public virtual ICollection<BookFile> BookFiles { get; set; }
    }
}