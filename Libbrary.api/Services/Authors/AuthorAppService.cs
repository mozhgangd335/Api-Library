using Libbrary.api.Dto.AuthorDtos;
using Libbrary.api.Dto.BookDtos;
using Libbrary.api.Entities;
using Libbrary.api.Services.Books;

namespace Libbrary.api.Services.Authors
{
    public class AuthorAppService : AuthorService
    {

        private readonly EFDbContext _context;
        public AuthorAppService(EFDbContext context)
        {
            _context = context;
        }

        public void Add(AddAuthorDto dto)
        {
            var author = new Entities.Author()
            {

                Name = dto.Name,



            };
            _context.Set<Entities.Author>().Add(author);
            _context.SaveChanges();

        }

        public void DeleteAuthor(int id)
        {
            var author = _context.Set<Entities.Author>().Find(id);
            if (author == null)
            {
                throw new Exception("authorNotFoundException");
            }
            _context.Set<Entities.Author>().Remove(author);
            _context.SaveChanges();

        }

        public List<GetAuthorDto> Get()
        {
            return _context.Set<Author>().Select(_ => new GetAuthorDto
            {

                Id = _.Id,
                Name = _.Name


            }).ToList();
        }

        public void Update(int id, UpdateAuthorDto dto)
        {
            var author = _context.Set<Author>().Find(id);
            if (author == null)
            {
                throw new Exception("BookNotFoundException");
            }

            author.Name = dto.Name;

            _context.SaveChanges();


        }
    }
}
