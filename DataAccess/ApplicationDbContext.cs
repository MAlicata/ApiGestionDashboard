using ApiGestionDashboard.Entities;
using Microsoft.EntityFrameworkCore;
using TechOil.DataAccess.DatabaseSeeding;

namespace TechOil.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seeders = new List<IEntitySeeder>
            {
                new UsuarioSeeder()
            };
            foreach(var seeder in seeders)
            {
                seeder.SeedDatabase(modelBuilder);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
