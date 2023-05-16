using Microsoft.AspNetCore.Mvc;
using Sistema_Eval_Comp_Egreso.Models;
using System.Diagnostics;

namespace Sistema_Eval_Comp_Egreso.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult EvalCompetencias()
        {
            return View();
        }

        [HttpGet]

        public JsonResult GetTime()
        {
            DateTime time = DateTime.Now;
            string response = "{\"time\": \"" + time + "\"}";
            return Json(response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}