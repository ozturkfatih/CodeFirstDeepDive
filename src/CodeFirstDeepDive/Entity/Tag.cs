using System.Collections.Generic;

namespace CodeFirstDeepDive.Entity
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relations
        public IList<CourseTag> CourseTags { get; set; }
    }
}