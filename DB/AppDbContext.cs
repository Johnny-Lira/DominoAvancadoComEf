using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DominoAvancadoComEf.DB
{
    public sealed class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseNpgsql("Host=localhost:5435;Password=0310;Persist Security Info=True;Username=postgres;Database=appDominoRico"
//);
//        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
