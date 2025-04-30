using Microsoft.AspNetCore.Mvc;

namespace CVGenerateUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
