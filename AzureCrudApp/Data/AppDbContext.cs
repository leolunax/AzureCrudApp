using Microsoft.EntityFrameworkCore;
using AzureCrudApp.Models;

namespace AzureCrudApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Item { get; set; }
    }
}