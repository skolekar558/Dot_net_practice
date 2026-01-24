using JWTAuthorizationDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthorizationDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }

    }

    
}
