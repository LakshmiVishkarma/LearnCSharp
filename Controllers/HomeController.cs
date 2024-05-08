using learncSharp_Website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace learncSharp_Website.Controllers
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
        public IActionResult Topics()
        {
            CodeVM codeVM = new CodeVM();
            return View(codeVM);
        }

        [HttpPost]
        public IActionResult Topics(CodeVM codeVM)
        {
            return View(codeVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}