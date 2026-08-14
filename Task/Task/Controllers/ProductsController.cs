using Microsoft.AspNetCore.Mvc;

namespace Task.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
