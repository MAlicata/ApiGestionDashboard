using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiGestionDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CeoController : ControllerBase
    {
        [HttpPost]
        [Route("Alta")]
        public IActionResult Alta(string rol)
        {
            return Ok(190);
        }
        [HttpGet]
        [Route("ListarGerenteMozo")]
        public IActionResult Listar(string rol)
        {
            return Ok("Lista de gerentes...");
        }
    }
}
