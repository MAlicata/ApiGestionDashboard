using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiGestionDashboard.Entities
{
    public class Usuario
    {
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
