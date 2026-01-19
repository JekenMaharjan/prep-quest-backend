using Interview_Preparation_Platform.Models;
using Microsoft.EntityFrameworkCore;

namespace Interview_Preparation_Platform.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Question> Questions { get; set; }
    }
}
