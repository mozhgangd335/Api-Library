namespace Libbrary.api.Dto.RentBook
{
    public class GetRentBookDto
    {
        public int Id { get; set; }
        public DateTime DateRent { get; set; }
        public int Days { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
