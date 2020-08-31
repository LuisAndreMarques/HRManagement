using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

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
