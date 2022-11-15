using Microsoft.AspNetCore.Mvc;

namespace FirstMVCAppV2.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Hello()
        {
            return "Who is there";
        }
    }
}
