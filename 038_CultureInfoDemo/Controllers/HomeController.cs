using _038_CultureInfoDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _038_CultureInfoDemo.Controllers
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
            TestModel model = new TestModel()
            {
                TestDouble = 1.23,
                TestDateTime = DateTime.Now
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(TestModel model)
        {
            return Content("Double: " + model.TestDouble + "; DateTime: " + model.TestDateTime);
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