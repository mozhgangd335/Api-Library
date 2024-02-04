using Libbrary.api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Libbrary.api.EntityMaps
{
    public class RentBookEntityMaps : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {

            builder.ToTable("RentBooks");
            builder.HasKey("Id");
            builder.Property("Id").ValueGeneratedOnAdd();
            builder.Property("DateRent").IsRequired();
            builder.Property("Days").IsRequired();


        }
    }
}
