using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Dto.RentBook
{
    public class AddRentBookDto
    {
        [Required]
        public DateTime DateRent { get; set; }
        [Required]
        public int Days { get; set; }
        public  int UserId { get; set; }
        public int BookId { get; set; }
       

    } 
}
