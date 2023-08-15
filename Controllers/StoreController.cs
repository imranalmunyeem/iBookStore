using Microsoft.AspNetCore.Mvc;

namespace iBookStore.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
