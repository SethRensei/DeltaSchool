using System.Data.Entity;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class NoteRepository : INoteRepository
    {
        private readonly DeltaSchoolContext _context;

        public NoteRepository(DeltaSchoolContext context)
            => _context = context;

        public IQueryable<Note> Query()
            => _context.Notes
            .Include(n => n.Student)
            .OrderByDescending(pr => pr.Id)
            .AsNoTracking();

        public Note GetById(int id) => _context.Notes.Find(id);

        public void Add(Note note) => _context.Notes.Add(note);

        public void Update(Note note)
            => _context.Entry(note).State = EntityState.Modified;

        public void Delete(int id)
        {
            var n = _context.Notes.Find(id);
            if (n != null)
                _context.Notes.Remove(n);
        }

        public void Save() => _context.SaveChanges();
    }
}
