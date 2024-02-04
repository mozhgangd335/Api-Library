using Libbrary.api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Libbrary.api.EntityMaps
{
    public class CategoryEntityMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
          
           
                builder.ToTable("Categories");
                builder.HasKey("Id");
                builder.Property("Id").ValueGeneratedOnAdd();
                builder.Property("Name").IsRequired();
               
          
        }
    }
}
