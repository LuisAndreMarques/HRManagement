using Microsoft.EntityFrameworkCore;

namespace Epifania.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        { }
        public DbSet<User> Users { get; set; }
       
    }

    public class User
    {
        public int  UserId { get; set; }
        public string UserName{ get; set; }
        public string Password { get; set; }
    }
}
