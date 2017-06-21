using CodeFirstDeepDive.Enums;

namespace CodeFirstDeepDive.Entity
{
    public class File
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public BookFileType FileType { get; set; }
        public string FileExtension { get; set; }
        public string MimeType { get; set; }
        public long Size { get; set; }
        public string Guid { get; set; }
    }
}