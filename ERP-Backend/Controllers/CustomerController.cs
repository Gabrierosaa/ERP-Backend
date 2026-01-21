using Microsoft.AspNetCore.Mvc;

namespace ERP_Backend.Controller
{
    public class CustomerController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
