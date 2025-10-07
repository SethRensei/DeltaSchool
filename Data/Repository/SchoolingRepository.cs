using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class SchoolingRepository : ISchoolingRepository
    {
        private readonly DeltaSchoolContext _context;

        public SchoolingRepository(DeltaSchoolContext context)
            => _context = context;

        public IQueryable<Schooling> Query()
            => _context.Schoolings
                .Include(sc => sc.Student)
                .Include(sc => sc.Classe)
                .Include(sc => sc.SchoolYear)
                .AsNoTracking();

        public IEnumerable<Schooling> GetBySchoolYearAndStudent(int schoolYear, int student)
        {
            return _context.Schoolings
                .Where(sc => sc.SchoolYearId == schoolYear &&
                sc.StudentId == student)
                .Include(sc => sc.Student)
                .Include(sc => sc.Classe)
                .Include(sc => sc.SchoolYear)
                .AsNoTracking()
                .ToList();
        }

        public Schooling GetById(int id) => _context.Schoolings.Find(id);

        public void Add(Schooling schooling) => _context.Schoolings.Add(schooling);

        public void Update(Schooling schooling)
            => _context.Entry(schooling).State = EntityState.Modified;

        public void Save() => _context.SaveChanges();
    }
}
