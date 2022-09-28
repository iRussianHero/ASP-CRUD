﻿using ASP_CRUD.Models;

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
    }
}