namespace CodeFirstDeepDive.Entity
{
    public class CourseTag
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string TagId { get; set; }
        public Tag Tag { get; set; }
    }
}