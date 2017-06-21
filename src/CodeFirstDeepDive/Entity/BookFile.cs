namespace CodeFirstDeepDive.Entity
{
    public class BookFile
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int FileId { get; set; }
        public Book Book { get; set; }
        public File File { get; set; }
    }
}