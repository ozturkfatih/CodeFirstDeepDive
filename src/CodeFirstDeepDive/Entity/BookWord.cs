namespace CodeFirstDeepDive.Entity
{
    public class BookWord
    {
        public int Id { get; set; }
        public int TotalWord { get; set; }
        public int UniqueWord { get; set; }
        public string Words { get; set; }
        public int IdRef { get; set; }
        public virtual Book Book { get; set; }
    }
}