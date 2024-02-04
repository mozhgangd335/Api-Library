using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Dto.AuthorDtos
{
    public class UpdateAuthorDto
    {
        [Required]
        public string Name { get; set; }
    }
}
