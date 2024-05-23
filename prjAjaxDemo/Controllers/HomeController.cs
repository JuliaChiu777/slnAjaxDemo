using Microsoft.AspNetCore.Mvc;
using prjAjaxDemo.Models;
using System.Composition.Hosting.Core;
using System.Diagnostics;

namespace prjAjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDBContext _context;
        public HomeController(ILogger<HomeController> logger, MyDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View(_context.Categories.ToList());
        }

        public IActionResult CallAPI()
        {
            return View();
        }

        public IActionResult About()
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
        public IActionResult JSONTest()
        {
            return View();
        }

        public IActionResult first()
        {
            return View();
        }

        public IActionResult Address()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Spots()
        {
            return View();
        }

    }
}