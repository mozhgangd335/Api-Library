using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Dto.BookDtos
{
    public class UpdateBookDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public int Count { get; set; }


        //[Required]
        //public string Category { get; set; }
    }
}
