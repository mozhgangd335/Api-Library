using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Dto.CategoryDtos
{
    public class UpdateCategoryDto
    {
        [Required]
        public string Name { get; set; }
       
    }
}
