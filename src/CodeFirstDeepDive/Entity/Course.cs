using System.Collections.Generic;
using CodeFirstDeepDive.Enums;

namespace CodeFirstDeepDive.Entity
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }

        //Relations
        public Author Author { get; set; }
        public IList<CourseTag> CourseTags { get; set; }
        public Category Category { get; set; }
    }
}