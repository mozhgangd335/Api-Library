using Libbrary.api.Dto.BookDtos;
using Libbrary.api.Dto.RentBookDtos;
using Libbrary.api.Entities;
using Libbrary.api.Services.Books;
using Microsoft.EntityFrameworkCore;

namespace Libbrary.api.Services.RentBooks
{
    public class RentBookAppService : RentBookService
    {
        private readonly EFDbContext _context;
        public RentBookAppService(EFDbContext context)
        {
            _context = context;
        }

        public void Add(AddRentBookDto dto)
        {
            var rentedbooksByUser = _context.RentBooks.Where(r => r.UserId == dto.UserId && r.IsRentedBack==false);
            var book = _context.Books.FirstOrDefault(b=>b.Id==dto.BookId);
            var rentedbooksNumber = _context.RentBooks.Where(b => b.IsRentedBack == false).Count();
            if (rentedbooksByUser.Count() < 4 && book.Count>rentedbooksNumber)
            {

                var rentbook = new RentBook()
                {

                    DateRent = dto.DateRent,
                    Days = dto.Days,
                    BookId = dto.BookId,
                    UserId = dto.UserId


                };
                _context.Set<RentBook>().Add(rentbook);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("this count is out of range");
            }
        }

        public void GetBack(int id)
        {
            var rentbook = _context.Set<RentBook>().Find(id);
            if (rentbook == null)
            {
                throw new Exception("RentBookNotFoundException");
            }
            rentbook.IsRentedBack = true;
            _context.Set<RentBook>().Update(rentbook);
            _context.SaveChanges();

        }

        public List<GetRentBookDto> Get()
        {
            return _context.Set<RentBook>().Select(_ => new GetRentBookDto
            {
                Id = _.Id,
                DateRent = _.DateRent,
                UserId = _.UserId,
                BookId = _.BookId,
                
                Days = _.Days

            }).ToList();
        }

       
    }
}
