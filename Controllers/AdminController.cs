using Microsoft.AspNetCore.Mvc;

namespace iBookStore.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
