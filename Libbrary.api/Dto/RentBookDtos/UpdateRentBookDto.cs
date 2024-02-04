using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Dto.RentBook
{
    public class UpdateRentBookDto
    {
        [Required]
        public DateTime DateRent { get; set; }
        public int Days { get; set; }


    }
}
