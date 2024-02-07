namespace Libbrary.api.Dto.RentBookDtos
{
    public class GetRentBookDto
    {
        public int Id { get; set; }
        public DateTime DateRent { get; set; }
        public int Days { get; set; }
        public bool IsRentedBack { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
