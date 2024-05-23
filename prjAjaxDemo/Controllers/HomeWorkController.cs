using Microsoft.AspNetCore.Mvc;

namespace prjAjaxDemo.Controllers
{
    public class HomeWorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HomeWork()
        {
            return View();
        }
    }
}
