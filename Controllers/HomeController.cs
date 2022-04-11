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

        [Route("")]
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("MeMyselfI")]
        public IActionResult MeMyselfI()
        {
            return View();
        }

        [Route("ReSCat")]
        public IActionResult ReSCat()
        {
            return View();
        }

        [Route("KapKa")]
        public IActionResult KapKa()
        {
            return View();
        }

        [Route("uCProgram")]
        public IActionResult uCProgram()
        {
            return View();
        }

        [Route("SqlDB")]
        public IActionResult SqlDB()
        {
            return View();
        }

        [Route("ConsoleApps")]
        public IActionResult ConsoleApps()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View(); //It is currently not used, but maybe in the future ?
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}