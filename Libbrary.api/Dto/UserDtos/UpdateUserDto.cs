using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Dto.UserDtos
{
    public class UpdateUserDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime Membered { get; set; }
    }
}
