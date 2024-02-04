using Libbrary.api.Dto.BookDtos;
using Libbrary.api.Dto.UserDtos;

namespace Libbrary.api.Services.Users
{
    public interface UserService
    {
        public void Add(AddUserDto dto);
        public List<GetUserDto> Get();
        public void Update(UpdateUserDto dto, int id);
        public void DeleteUser(int id);
    }
}
