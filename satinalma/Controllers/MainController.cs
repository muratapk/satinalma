using Microsoft.AspNetCore.Mvc;

namespace satinalma.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
