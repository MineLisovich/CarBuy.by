using Microsoft.AspNetCore.Mvc;

namespace CarBuy.WEB.Areas.Moder.Controllers
{
    [Area("moder")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
