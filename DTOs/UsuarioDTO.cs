using ApiGestionDashboard.Entities;

namespace ApiGestionDashboard.DTOs
{
    public class UsuarioDTO
    {
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public Rol Rol { get; set; }
        public string Clave { get; set; }
        public string Usuario_Email { get; set; }

    }
}
