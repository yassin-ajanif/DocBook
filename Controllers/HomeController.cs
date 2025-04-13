using MedicalAppointement.Models;
using MedicalAppointementDataLayer.Interfaces;
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
        private readonly ItestService _testService;

       
        public HomeController(ILogger<HomeController> logger,ItestService testService)
        {
            _logger = logger;
            _testService = testService;
        }

        public IActionResult Index()
        {

           // ViewBag.DatabaseValue  = _testService.getvalueFromDbTest();
            string testValue  = _testService.getvalueFromDbTest();
            return View("index",testValue);
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
