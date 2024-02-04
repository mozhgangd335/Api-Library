using Libbrary.api.Dto;
using Libbrary.api.Dto.BookDtos;
using Libbrary.api.Entities;
using Libbrary.api.Services.Books;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libbrary.api.Controllers
{

    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly BookService _service;
        public BookController(BookService service)
        {
            _service = service;
        }

        [HttpPost("Set")]
        public void Add([FromBody] AddBookDto dto)
        {
            _service.Add(dto);
        }
        [HttpGet("Get")]
        public List<GetBookDto> Get([FromQuery]GetBookDto dto)
        {
            return _service.Get();
        }
        [HttpPatch("update/{id}")]
        public void Update(UpdateBookDto dto, [FromRoute]int id)
        {
             _service.Update(id,dto);
        } 
        [HttpDelete("removed/{id}")]
        public void Delete( [FromRoute]int id)
        {
             _service.DeleteBook(id);
        }


    }

}