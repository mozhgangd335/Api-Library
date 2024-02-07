using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Dto.RentBookDtos
{
    public class UpdateRentBookDto
    {
        [Required]
        public DateTime DateRent { get; set; }
        public int Days { get; set; }


    }
}
