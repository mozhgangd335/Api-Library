using Libbrary.api.Dto.AuthorDtos;
using Libbrary.api.Dto.CategoryDtos;
using Libbrary.api.Services.Authors;
using Libbrary.api.Services.Categories;
using Microsoft.AspNetCore.Mvc;

namespace Libbrary.api.Controllers
{
     [ApiController]
        [Route("api/Categories")]
        public class CategoryCController : ControllerBase
        {
            private readonly CategoryService _service;
            public CategoryCController(CategoryService service)
            {
                _service = service;
            }

            [HttpPost("Set")]
            public void Add([FromBody] AddCategoryDto dto)
            {
                _service.Add(dto);
            }
            [HttpGet("Get")]
            public List<GetCategoryDto> Get([FromQuery] GetCategoryDto dto)
            {
                return _service.Get();
            }
            [HttpPatch("update/{id}")]
            public void Update([FromBody] UpdateCategoryDto dto, [FromRoute] int id)
            {
                _service.Update(id, dto);
            }
            [HttpDelete("removed/{id}")]
            public void Delete([FromRoute] int id)
            {
                _service.DeleteCategory(id);
            }
        }
    }

