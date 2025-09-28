using System.Collections.Generic;
using System.Linq;
using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class SchoolYearRepository : ISchoolYearRepository
    {
        private readonly DeltaSchoolContext _context;

        public SchoolYearRepository(DeltaSchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<SchoolYear> GetAll()
        {
            return _context.SchoolYears
                .OrderByDescending(sy => sy.Label)
                .ToList();
        }

        public SchoolYear GetById(int id)
        {
            return _context.SchoolYears.Find(id);
        }

        public void Add(SchoolYear schoolYear)
        {
            _context.SchoolYears.Add(schoolYear);
        }

        public void Update(SchoolYear schoolYear)
        {
            _context.Entry(schoolYear).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var schoolYear = _context.SchoolYears.Find(id);
            if (schoolYear != null)
                _context.SchoolYears.Remove(schoolYear);
        }

        public void Save() => _context.SaveChanges();
    }
}
