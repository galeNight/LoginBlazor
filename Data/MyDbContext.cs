using LoginBlazor.models;
using Microsoft.EntityFrameworkCore;

namespace LoginBlazor.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    }
}
