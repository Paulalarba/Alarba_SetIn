using ALARBA_SETIN_SYSTEM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ALARBA_SETIN_SYSTEM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
