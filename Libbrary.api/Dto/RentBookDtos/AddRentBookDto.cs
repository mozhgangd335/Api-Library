using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Dto.RentBookDtos
{
    public class AddRentBookDto
    {
        [Required]
        public DateTime DateRent { get; set; }
        [Required]
        public int Days { get; set; }
        public bool IsRentedBack { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }


    }
}
