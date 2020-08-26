using Microsoft.EntityFrameworkCore;

namespace epifania.Models
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<UserModel> UserModels { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
