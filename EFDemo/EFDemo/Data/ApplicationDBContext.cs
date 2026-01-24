using EFDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDemo.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employee{ get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
