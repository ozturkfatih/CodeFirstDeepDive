namespace CodeFirstDeepDive.Entity
{
    public class BookCategory
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        /*Relations*/
        public virtual Book Book { get; set; }
        public virtual Category Category { get; set; }
       
    }

}