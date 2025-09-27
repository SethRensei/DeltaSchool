using System.Collections.Generic;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class ClasseSubjectRepository : IClasseSubjectRepository
    {
        private readonly DeltaSchoolContext _context;

        public ClasseSubjectRepository(DeltaSchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<ClasseSubject> GetAll()
        {
            return _context.ClasseSubjects.ToList();
        }

        public ClasseSubject GetById(int id)
        {
            return _context.ClasseSubjects.Find(id);
        }

        public void Add(ClasseSubject cs)
        {
            _context.ClasseSubjects.Add(cs);
        }

        public void Update(ClasseSubject cs)
        {
            _context.Entry(cs).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var cs = _context.ClasseSubjects.Find(id);
            if (cs != null)
                _context.ClasseSubjects.Remove(cs);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
