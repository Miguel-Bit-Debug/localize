using Localize.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Localize.InfraData.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Revenue> Pedidos { get; set; }
        public DbSet<Account> Contas { get; set; }
    }
}
