using Libbrary.api.Dto.BookDtos;
using Libbrary.api.Dto.RentBook;
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
            var numberofrentedbooks = _context.RentBooks.Where(r => r.UserId == dto.UserId).Count();
            if (numberofrentedbooks < 4)
            {

                var rentbook = new RentBook()
                {

                    DateRent = dto.DateRent,
                    Days = dto.Days,
                    BookId = dto.BookId,
                    UserId = dto.UserId,


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
            _context.Set<RentBook>().Remove(rentbook);
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
