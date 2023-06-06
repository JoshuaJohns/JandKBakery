using Microsoft.AspNetCore.Mvc;

namespace JandKBakery.Controllers
{
    public class CakeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
