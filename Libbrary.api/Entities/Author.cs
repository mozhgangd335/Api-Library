namespace Libbrary.api.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<Book> Books { get; set; }
    }
}
