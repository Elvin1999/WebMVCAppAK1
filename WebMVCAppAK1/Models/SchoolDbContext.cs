using Microsoft.EntityFrameworkCore;
using WebMVCAppAK1.Entities;

namespace WebMVCAppAK1.Models
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> contextOptions)
            :base(contextOptions)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
