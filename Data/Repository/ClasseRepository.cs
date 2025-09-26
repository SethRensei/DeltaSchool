using System.Collections.Generic;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class ClasseRepository : IClasseRepository
    {
        private readonly DeltaSchoolContext _context;

        public ClasseRepository(DeltaSchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Classe> GetAll()
        {
            return _context.Classes.ToList();
        }

        public Classe GetById(int id)
        {
            return _context.Classes.Find(id);
        }

        public void Add(Classe c)
        {
            _context.Classes.Add(c);
        }

        public void Update(Classe c)
        {
            _context.Entry(c).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var c = _context.Classes.Find(id);
            if (c != null)
                _context.Classes.Remove(c);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
