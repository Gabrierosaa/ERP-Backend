using Microsoft.AspNetCore.Mvc;

namespace ERP_Backend.Controllers
{
    public class UserController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
