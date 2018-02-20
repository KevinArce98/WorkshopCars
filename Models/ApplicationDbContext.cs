using Microsoft.EntityFrameworkCore;

namespace Cars.Models
{
    public class ApplicationDbContext : DbContext
    {
         public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Car> Car { get; set; }
        public DbSet<Models.Make> Make { get; set; }
    }
}
