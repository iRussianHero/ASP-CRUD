using ASP_CRUD.Models;

namespace ASP_CRUD.Servises
{
    public class NoteService
    {
        public List<Note> Notes { get; set; }

        public NoteService()
        {
            Notes = new List<Note>();
        }
        public void CreateNote(string theme, string content)
        {
            Note note = new Note() { Id = DateTime.Now, Theme = theme, Content = content };
            Notes.Add(note);
        }

        public void DeleteById(string id)
        {
            Notes.Remove(FindById(id));
        }

        public Note FindById(string id)
        {
            return Notes.Find(note => note.Id.ToString() == id);
        }
    }
}