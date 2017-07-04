using CodeFirstDeepDive.Entity;
using CodeFirstDeepDive.Extensions;
using CodeFirstDeepDive.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDeepDive.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookFile> BookFiles { get; set; }
        public DbSet<BookTag> BookTags { get; set; }
        public DbSet<BookWord> BookWords { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder
                .RegisterEntityMapping<Author, AuthorMapping>()
                .RegisterEntityMapping<Book, BookMapping>()
                .RegisterEntityMapping<BookFile, BookFileMapping>()
                .RegisterEntityMapping<BookTag, BookTagMapping>()
                .RegisterEntityMapping<BookWord,BookWordMapping>()
                .RegisterEntityMapping<BookAuthor,BookAuthorMapping>()
                .RegisterEntityMapping<BookCategory,BookCategoryMapping>()
                .RegisterEntityMapping<Category, CategoryMapping>()
                .RegisterEntityMapping<File, FileMapping>()
                .RegisterEntityMapping<Tag, TagMapping>();
        }
    }
}