using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test12345.Models;

namespace test12345.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}