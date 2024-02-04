using Libbrary.api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Libbrary.api.EntityMaps
{
    public class AuthorEntityMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey("Id");
            builder.Property("Id").ValueGeneratedOnAdd();
            builder.Property("Name").IsRequired();
        }
    }
}
