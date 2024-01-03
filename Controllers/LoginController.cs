using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiGestionDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// Login de usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns>Usuario logueado</returns>
        [HttpPost]
        public IActionResult Login(string usuario, string password)
        {
            if(usuario == "Matias" && password == "1234")
            {
                return Ok("token: asfdasfasf");
            }
            return Unauthorized("Usuario o clave erronea");
        } 
        // retomar trabajando con Apis - Parte 3 31:32
    }
}
