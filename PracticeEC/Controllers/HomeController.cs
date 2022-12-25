using Microsoft.AspNetCore.Mvc;

namespace PracticeEC.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
