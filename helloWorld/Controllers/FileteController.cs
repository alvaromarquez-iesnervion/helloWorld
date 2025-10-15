using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers
{
    public class FileteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Empanado()
        {
            return View();
        }
    }


}
