using ApiGestionDashboard.Entities;
using ApiGestionDashboard.Helper;
using Microsoft.EntityFrameworkCore;

namespace ApiGestionDashboard.DataAccess.DatabaseSeeding
{
    public class UsuarioSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Nombre = "Matias",
                    Dni = 12345678,
                    Rol = Rol.Ceo,
                    Clave = PasswordEncryptHelper.EncryptPassword("1234", "matias@hotmail.com.ar"),
                    Email = "matias@hotmail.com.ar"
                });
        }
    }
}
