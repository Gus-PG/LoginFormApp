using Microsoft.AspNetCore.Mvc;

namespace LoginFormApp.Controllers
{
    public class LoginFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
