using D.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace D.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<AppUser> Users { get; set; }
    }
}
