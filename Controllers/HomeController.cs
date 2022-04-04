using KaPKa.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KaPKa.Controllers
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

        public IActionResult MeMyselfI()
        {
            return View();
        }

        public IActionResult ReSCat()
        {
            return View();
        }

        public IActionResult KapKa()
        {
            return View();
        }
        public IActionResult uCProgram()
        {
            return View();
        }


        public IActionResult ContactMe()
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
    }
}