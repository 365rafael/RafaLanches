using Microsoft.AspNetCore.Mvc;

namespace RafaLanches.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
