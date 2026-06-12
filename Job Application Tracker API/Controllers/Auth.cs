using Microsoft.AspNetCore.Mvc;

namespace Job_Application_Tracker_API.Controllers
{
    public class Auth : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
