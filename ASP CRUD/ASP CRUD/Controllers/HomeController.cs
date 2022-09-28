using ASP_CRUD.Models;
using ASP_CRUD.Servises;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NoteService noteService;

        public HomeController(ILogger<HomeController> logger, NoteService noteService)
        {
            _logger = logger;
            this.noteService = noteService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(string theme, string content)
        {
            noteService.CreateNote(theme, content);
            return View("Index");
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