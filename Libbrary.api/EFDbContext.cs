using Libbrary.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Libbrary.api
{
    public class EFDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Db_Library;Integrated Security=True");
        }
        internal DbSet<Book> Books { get; set; }
        internal DbSet<User> Users { get; set; }
        internal DbSet<Category> Categories { get; set; }
        internal DbSet<Author> Authors { get; set; }
        internal DbSet<RentBook> RentBooks { get; set; }
    }
}
