using Libbrary.api.Dto.AuthorDtos;
using Libbrary.api.Dto.CategoryDtos;

namespace Libbrary.api.Services.Categories
{
    public interface CategoryService
    {
        public void Add(AddCategoryDto dto);
        public List<GetCategoryDto> Get();
        public void Update(int id, UpdateCategoryDto dto);
        public void DeleteCategory(int id);

    }
}
