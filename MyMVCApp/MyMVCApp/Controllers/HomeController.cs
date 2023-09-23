using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMVCApp.Models;
using System.Diagnostics;
using System.Security.Policy;

namespace MyMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }
        public IActionResult Menu()
        {
            String conString = _configuration.GetConnectionString("DefaultConnection");
            _logger.Log(LogLevel.Information,conString);
            return View();
        }

        public IActionResult Index()
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
        public ActionResult Echo(String name,String city)
        {
            String s1 = "user= " + name + " from City=" + city;
            ViewData.Add("Data1", s1);
            return View();
        }
        public ActionResult SayHello(String name)
        {
            // Home / SayHello ? name = Sanghavai
             String s1 = ("Hello " + name);
             ViewData.Add("Data1", s1);
             return View("Echo");

           
        }
    }
}