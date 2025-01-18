using Microsoft.EntityFrameworkCore; 
using TaskTracker.Model;

namespace TaskTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Tareas> Tareas { get; set; }


    }

}
