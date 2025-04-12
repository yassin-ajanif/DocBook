using MedicalAppointement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MedicalAppointement.Controllers
{

    public class MyViewModel
    {
        public string MyName { get; set; }
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public string myName = "yassin";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var modelo = new MyViewModel
            {
                MyName = "Yassin"
            };

            return View(modelo);
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
