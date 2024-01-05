using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ApiGestionDashboard.Helper;
using ApiGestionDashboard.DTOs;

namespace ApiGestionDashboard.Entities
{
    public class Usuario
    {
        public Usuario(UsuarioDTO dto)
        {
            Nombre = dto.Nombre;
            Dni = dto.Dni;
            Rol = dto.Rol;
            Clave = PasswordEncryptHelper.EncryptPassword(dto.Clave, dto.Usuario_Email);
            Email = dto.Usuario_Email;
        }
        
        public Usuario(UsuarioDTO dto, int id)
        {
            Id = id;
            Nombre = dto.Nombre;
            Dni = dto.Dni;
            Rol = dto.Rol;
            Clave = PasswordEncryptHelper.EncryptPassword(dto.Clave, dto.Usuario_Email);
            Email = dto.Usuario_Email;
        }
        public Usuario()
        {

        }

        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("nombre", TypeName = "VARCHAR(100)")]
        public string Nombre { get; set; }

        [Column("dni")]
        public int Dni { get; set; }

        [Column("rol_empleado")]
        public Rol Rol { get; set; }

        [Column("clave", TypeName = "VARCHAR(250)")]
        public string Clave { get; set; }

        [Column("usuario_email", TypeName = "VARCHAR(100)")]
        public string Email { get; set; }
    }
}
