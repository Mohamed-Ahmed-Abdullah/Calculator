using DiscountCalc.Models;
using DiscountCalc.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DiscountCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculateService _calculateService;
        public HomeController(ILogger<HomeController> logger,
            ICalculateService calculateService)
        {
            _logger = logger;
            _calculateService = calculateService;
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

        [HttpPost]
        public IActionResult MyPostAction([FromForm] string inputData)
        {
            var result = _calculateService.Add(1,2);
            // Process the posted data and return a response
            return Json($"Data received successfully inputData={inputData} calcResult={result}");
        }
    }
}