using System;
using System.Collections.Generic;

namespace CodeFirstDeepDive.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Version { get; set; }
        public string Image { get; set; }
        public string Number { get; set; }
        public DateTime PublishDate { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public ICollection<BookTag> BookTags { get; set; }
        public ICollection<BookFile> BookFiles { get; set; }
    }
}