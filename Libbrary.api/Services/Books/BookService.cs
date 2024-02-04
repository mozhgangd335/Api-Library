using Libbrary.api.Dto;
using Libbrary.api.Dto.BookDtos;

namespace Libbrary.api.Services.Books
{
    public interface BookService
    {
        public void Add(AddBookDto dto);
        public List<GetBookDto> Get();
        public void Update(int id,UpdateBookDto dto);
        public void DeleteBook(int id);
    }
}
