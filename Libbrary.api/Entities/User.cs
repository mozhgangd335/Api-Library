using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }  
        public string LastName { get; set; }    
        public string Email { get; set; }   
        public DateTime CreationDate { get; set; }
        public HashSet< RentBook> RentBooks { get; set; }
    }
}
