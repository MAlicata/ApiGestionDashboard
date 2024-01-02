using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiGestionDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CeoController : ControllerBase
    {
        [HttpGet]
        [Route("Consultar")]
        public IActionResult Consultar()
        {
            return Ok(190);
        }
    }
}
