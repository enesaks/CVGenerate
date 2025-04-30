using Microsoft.AspNetCore.Mvc;

namespace CVGenerateUI.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
