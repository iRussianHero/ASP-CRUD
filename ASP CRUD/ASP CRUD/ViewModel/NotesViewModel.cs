using ASP_CRUD.Models;

namespace ASP_CRUD.ViewModel
{
    public class NotesViewModel
    {
        public IEnumerable<Note> Notes { get; set; } = new List<Note>();
    }
}
