using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiGestionDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(string usuario, string password)
        {
            if(usuario == "Matias" && password == "1234")
            {
                return Ok("token: asfdasfasf");
            }
            return Unauthorized("Usuario o clave erronea");
        } 
    }
}
