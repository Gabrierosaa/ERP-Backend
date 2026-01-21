using Microsoft.AspNetCore.Mvc;

namespace ERP_Backend.Controllers
{
    public class AuthController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
