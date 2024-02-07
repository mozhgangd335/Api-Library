namespace Libbrary.api.Entities
{
    public class RentBook
    {
        public int Id { get; set; }
        public DateTime DateRent { get; set; }
        public int Days { get; set; }
        public bool IsRentedBack { get; set; }=false;
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int UserId { get; set; }
        public User User{ get; set; }
    }
}
