using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Simple_OMR.Models;
using System.Diagnostics;

namespace Simple_OMR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles ="Moderator")]
        [Authorize(Policy = "DeleteRolePolicy")]
        public IActionResult calendar()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Error2()
        {
            return View();
        }public IActionResult NotFound2()
        {
            return View();
        }
    }
}