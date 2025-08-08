using Microsoft.EntityFrameworkCore;
using RoleBasedAuthenticationSystem.Models;


namespace RoleBasedAuthenticationSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
