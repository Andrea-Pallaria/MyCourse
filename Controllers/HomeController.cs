using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()         //definiamo un Action di default che deve chiamarsi Index
        {
            return Content("Sono la index della home");
        }
    }
}