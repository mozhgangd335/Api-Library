using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Dto.AuthorDtos
{
    public class AddAuthorDto
    {
        [Required]
        public string Name { get; set; }
    }
}
