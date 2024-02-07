namespace Libbrary.api.Dto.BookDtos
{
    public class GetBookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
       public int Count { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int RentedBookCount { get; set; }
        public DateTime CreationDate { get; set; }
        
    }
}
