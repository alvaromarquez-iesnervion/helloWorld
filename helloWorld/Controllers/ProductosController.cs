using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListadoProductos()
        {
            return View();
        }
    }
}
