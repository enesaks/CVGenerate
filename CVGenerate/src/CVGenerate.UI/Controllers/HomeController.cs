using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CVGenerate.UI.Models;

namespace CVGenerate.UI.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


}
