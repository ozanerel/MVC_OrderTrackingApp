using Microsoft.AspNetCore.Mvc;
using MVC_OrderTrackingApp.Models;

namespace MVC_OrderTrackingApp.Controllers
{
    public class ProductController : Controller
    {
        OrdertrackingdbContext context = new OrdertrackingdbContext();
        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }
    }
}
