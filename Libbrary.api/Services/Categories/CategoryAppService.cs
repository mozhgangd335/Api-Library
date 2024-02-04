﻿using Libbrary.api.Dto.AuthorDtos;
using Libbrary.api.Dto.CategoryDtos;
using Libbrary.api.Entities;
using Libbrary.api.Services.Authors;

namespace Libbrary.api.Services.Categories
{
    public class CategoryAppService:CategoryService
    {
     
            private readonly EFDbContext _context;
            public CategoryAppService(EFDbContext context)
            {
                _context = context;
            }

            public void Add(AddCategoryDto dto)
            {
                var category = new Category()
                {

                    Name = dto.Name,



                };
                _context.Set<Category>().Add(category);
                _context.SaveChanges();

            }

            public void DeleteCategory(int id)
            {
                var category= _context.Set<Category>().Find(id);
                if (category == null)
                {
                    throw new Exception("categoryNotFoundException");
                }
                _context.Set<Category>().Remove(category);
                _context.SaveChanges();

            }

            public List<GetCategoryDto> Get()
            {
                return _context.Set<Category>().Select(_ => new GetCategoryDto
                {

                    Id = _.Id,
                    Name = _.Name


                }).ToList();
            }

            public void Update(int id, UpdateCategoryDto dto)
            {
                var category = _context.Set<Category>().Find(id);
                if (category == null)
                {
                    throw new Exception("BookNotFoundException");
                }

                category.Name = dto.Name;

                _context.SaveChanges();


            }
        }
}
