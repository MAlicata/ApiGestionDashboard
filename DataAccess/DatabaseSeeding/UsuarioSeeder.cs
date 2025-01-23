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
                },
                 new Usuario
                 {
                     Id = 2,
                     Nombre = "Jose",
                     Dni = 21456789,
                     Rol = Rol.Ceo,
                     Clave = PasswordEncryptHelper.EncryptPassword("4321", "jose@gmail.com"),
                     Email = "jose@gmail.com.ar"
                 },
                  new Usuario
                  {
                      Id = 3,
                      Nombre = "Martin",
                      Dni = 30145741,
                      Rol = Rol.Ceo,
                      Clave = PasswordEncryptHelper.EncryptPassword("4321", "martin@gmail.com"),
                      Email = "martin@gmail.com.ar"
                  });
        }
    }
}
