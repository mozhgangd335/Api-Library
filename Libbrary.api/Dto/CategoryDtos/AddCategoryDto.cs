using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Dto.CategoryDtos
{
    public class AddCategoryDto
    {
        [Required]
        public string Name { get; set; }

    }
}
