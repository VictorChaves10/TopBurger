using Microsoft.AspNetCore.Mvc;

namespace TopBurgers.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
