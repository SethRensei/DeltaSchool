using System.Collections.Generic;
using System.Linq;

using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly DeltaSchoolContext _context;

        public SubjectRepository(DeltaSchoolContext context)
            => _context = context;

        public IEnumerable<Entity.Subject> GetAll()
            => _context.Subjects.ToList();

        public Entity.Subject GetById(int id)
            => _context.Subjects.Find(id);

        public void Add(Entity.Subject subject)
            => _context.Subjects.Add(subject);

        public void Update(Entity.Subject subject)
            => _context.Entry(subject).State = System.Data.Entity.EntityState.Modified;

        public void Delete(int id)
        {
            var s = _context.Subjects.Find(id);
            if (s != null)
                _context.Subjects.Remove(s);
        }

        public void Save()
            => _context.SaveChanges();
    }
}
