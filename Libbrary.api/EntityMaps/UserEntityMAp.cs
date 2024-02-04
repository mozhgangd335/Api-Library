using Libbrary.api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Libbrary.api.EntityMaps
{
    public class UserEntityMAp : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey("Id");
            builder.Property("Id").ValueGeneratedOnAdd();
            builder.Property("FirstName").IsRequired();
            builder.Property("LastName").IsRequired();
            builder.Property("CreationDate").IsRequired();
            builder.Property("Email").IsRequired();
        }
    }
    
}
