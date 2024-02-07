using Libbrary.api.Dto.BookDtos;
using Libbrary.api.Entities;

namespace Libbrary.api.Services.Books
{
    public class BookAppService : BookService
    {
        private readonly EFDbContext _context;
        public BookAppService(EFDbContext context)
        {
            _context = context;
        }

        public void Add(AddBookDto dto)
        {
            var book = new Book()
            {
                //Author = dto.Author,
                Title = dto.Title,
                Count = dto.Count,
                CategoryId=dto.CategoryID,
                AuthorID=dto.AuthorID,

                //Category = dto.Category,
                CreationDate = DateTime.Now


            };
            _context.Set<Book>().Add(book);
            _context.SaveChanges();

        }

        public void DeleteBook(int id)
        {
            var book = _context.Set<Book>().Find(id);
            if (book == null)
            {
                throw new Exception("BookNotFoundException");
            }
            _context.Set<Book>().Remove(book);
            _context.SaveChanges();

        }

        public List<GetBookDto> Get()
        {
            return _context.Set<Book>().Select(_ => new GetBookDto
            {
                //Author = _.Author,
                //Category = _.Category,
                Id = _.Id,
                Title = _.Title,
                Count = _.Count,
                CategoryId=_.CategoryId,
                AuthorId=_.AuthorID,
                RentedBookCount = _context.RentBooks.Where(b => b.Id == _.Id && b.IsRentedBack == false).Count(),
                CreationDate = _.CreationDate

            }).ToList();
        }

        public void Update(int id,UpdateBookDto dto)
        {
            var book = _context.Set<Book>().Find(id);
            if (book == null)
            {
                throw new Exception("BookNotFoundException");
            }
           // book.Author = dto.Author;
            book.Title = dto.Title;
            book.Count = dto.Count;
           // book.Category = dto.Category;
            _context.SaveChanges();


        }
    }
}
