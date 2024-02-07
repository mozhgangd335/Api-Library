using Libbrary.api.Dto.BookDtos;
using Libbrary.api.Dto.RentBookDtos;
using Libbrary.api.Services.Books;
using Libbrary.api.Services.RentBooks;
using Microsoft.AspNetCore.Mvc;

namespace Libbrary.api.Controllers
{
    [ApiController]
    [Route("api/Rentbooks")]
    public class RentBookController:ControllerBase
    {
            private readonly RentBookService _service;
            public RentBookController(RentBookService service)
            {
                _service = service;
            }

            [HttpPost("Set")]
            public void Add([FromQuery] AddRentBookDto dto)
            {
                _service.Add(dto);
            }
            [HttpGet("Get")]
            public List<GetRentBookDto> Get([FromQuery]GetRentBookDto dto)
            {
                return _service.Get();
            }
           
            
            [HttpDelete("GetBack/{id}")]
            public void GetBack([FromRoute] int id)
            {
                _service.GetBack(id);
            }


        }
    }

