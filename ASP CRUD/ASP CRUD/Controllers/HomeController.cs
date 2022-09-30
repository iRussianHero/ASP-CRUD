using ASP_CRUD.Models;
using ASP_CRUD.Servises;
using ASP_CRUD.ViewModel;
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

        public IActionResult Index(string theme, string content)
        {
            NotesViewModel viewModel = new NotesViewModel()
            {
                Notes = noteService.Notes
            };
            if(theme == null || content == null) { return View(viewModel); }
            else {
            noteService.CreateNote(theme, content);
            }
            return View(viewModel);
        }

        public IActionResult Delete(string id)
        {
            noteService.DeleteById(id);
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Edit(string id)
        {
            var result = 0;//noteService.
            return View("Edit", result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}