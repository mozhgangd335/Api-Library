using System.ComponentModel.DataAnnotations;

namespace Libbrary.api.Dto.BookDtos
{
    public class AddBookDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
        //[Required]
        // public string Category { get; set; }
    }
}
