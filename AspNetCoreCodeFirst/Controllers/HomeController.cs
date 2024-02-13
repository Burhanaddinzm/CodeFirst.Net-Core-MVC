using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
