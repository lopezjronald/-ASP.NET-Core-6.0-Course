using Microsoft.AspNetCore.Mvc;

namespace FirstMVCAppV2.Controllers
{
    public class Exercise : Controller
    {
        public IActionResult Hello()
        {
            return View();
        }
    }
}
