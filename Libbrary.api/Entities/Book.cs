using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Entities
{
    public class Book
    {
     
     
        public int Id { get; set; }
        public int Count { get; set; }
        public string Title { get; set; }
        //public string Author { get; set; }
        public DateTime CreationDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        public HashSet<RentBook> RentBooks { get; set; }
       // public string Category { get; set; } 
        
           
    }
}
