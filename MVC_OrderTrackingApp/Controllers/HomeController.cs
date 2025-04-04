using Microsoft.AspNetCore.Mvc;

namespace MVC_OrderTrackingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
