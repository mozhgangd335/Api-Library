using Libbrary.api.Dto.BookDtos;
using Libbrary.api.Dto.UserDtos;
using Libbrary.api.Services.Books;
using Libbrary.api.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace Libbrary.api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController: ControllerBase
    {
       
            private readonly UserService _service;
            public UserController(UserService service)
            {
                _service = service;
            }

            [HttpPost("Set")]
            public void Add([FromBody] AddUserDto dto)
            {
                _service.Add(dto);
            }
            [HttpGet("Get")]
            public List<GetUserDto> Get()
            {
                return _service.Get();
            }
            [HttpPatch("update/{id}")]
            public void Update([FromBody] UpdateUserDto dto, [FromRoute] int id)
            {
                _service.Update(dto, id);
            }
            [HttpDelete("removed/{id}")]
            public void Delete([FromRoute] int id)
            {
                _service.DeleteUser(id);
            }


        }

    }


