using Libbrary.api.Dto.AuthorDtos;
using Libbrary.api.Dto.BookDtos;
using Libbrary.api.Services.Authors;
using Libbrary.api.Services.Books;
using Microsoft.AspNetCore.Mvc;

namespace Libbrary.api.Controllers
{
   
        [ApiController]
        [Route("api/Authors")]
        public class AuthorController : ControllerBase
        {
            private readonly AuthorService _service;
            public AuthorController(AuthorService service)
            {
                _service = service;
            }

            [HttpPost("Set")]
            public void Add([FromBody] AddAuthorDto dto)
            {
                _service.Add(dto);
            }
            [HttpGet("Get")]
            public List<GetAuthorDto> Get([FromQuery] GetAuthorDto dto)
            {
                return _service.Get();
            }
            [HttpPatch("update/{id}")]
            public void Update([FromBody]  UpdateAuthorDto dto, [FromRoute] int id)
            {
                _service.Update(id, dto);
            }
            [HttpDelete("removed/{id}")]
            public void Delete([FromRoute] int id)
            {
                _service.DeleteAuthor(id);
            }
        }
}
