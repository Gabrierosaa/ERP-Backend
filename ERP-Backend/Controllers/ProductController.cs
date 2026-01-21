using Microsoft.AspNetCore.Mvc;

namespace ERP_Backend.Controllers
{
    public class ProductController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
