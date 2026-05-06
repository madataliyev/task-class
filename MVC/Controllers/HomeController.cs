using Microsoft.AspNetCore.Mvc;
using MVC.Data;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
             this .context = context;
        }

        public IActionResult Index()
        {
            var products=context.Products.ToList();
            return View(products);
        }
    }
}
