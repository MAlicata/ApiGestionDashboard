using Microsoft.EntityFrameworkCore;

namespace ApiGestionDashboard.DataAccess.DatabaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDatabase(ModelBuilder modelBuilder);
    }
}
