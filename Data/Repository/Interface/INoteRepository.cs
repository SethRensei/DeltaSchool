using System.Linq;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface INoteRepository
    {
        IQueryable<Note> Query();
        Note GetById(int id);
        void Add(Note note);
        void Update(Note note);
        void Delete(int id);
        void Save();
    }
}
