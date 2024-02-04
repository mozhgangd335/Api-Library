using Libbrary.api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Libbrary.api.EntityMaps
{
    public class BookEntityMap : IEntityTypeConfiguration<Book>

    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey("Id");
            builder.Property("Id").ValueGeneratedOnAdd();
            builder.Property("Title").IsRequired();
            builder.Property("CreationDate").IsRequired();
            builder.Property("Count").IsRequired();
        }
    }
}
