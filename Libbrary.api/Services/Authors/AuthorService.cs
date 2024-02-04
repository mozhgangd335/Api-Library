using Libbrary.api.Dto.AuthorDtos;
using Libbrary.api.Dto.BookDtos;

namespace Libbrary.api.Services.Authors
{
    public interface AuthorService
    {
       
       
            public void Add(AddAuthorDto dto);
            public List<GetAuthorDto> Get();
            public void Update(int id, UpdateAuthorDto dto);
            public void DeleteAuthor(int id);
        
    }
}
