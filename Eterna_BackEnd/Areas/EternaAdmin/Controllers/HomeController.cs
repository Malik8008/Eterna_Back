using Microsoft.AspNetCore.Mvc;

namespace Eterna_BackEnd.Areas.EternaAdmin.Controllers
{
    public class HomeController : Controller
    {
        [Area("EternaAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
