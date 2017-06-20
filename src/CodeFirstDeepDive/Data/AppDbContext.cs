using CodeFirstDeepDive.Entity;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDeepDive.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<CourseTag> CourseTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Course>().ToTable("Course");
            builder.Entity<Author>().ToTable("Author");
            builder.Entity<Tag>().ToTable("Tag");
            builder.Entity<CourseTag>().ToTable("CourseTag");
            builder.Entity<Category>().ToTable("Category");
            base.OnModelCreating(builder);
        }
    }
}