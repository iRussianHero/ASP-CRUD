using ASP_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_CRUD.Controllers
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
            List<RecordModel> records = new List<RecordModel>();
            records.Add(new RecordModel("1", "First", "This is a first record"));
            records.Add(new RecordModel("2", "Second", "This is a second record"));
            records.Add(new RecordModel("3", "Third", "This is a third record"));
            return View("Index", records);
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}