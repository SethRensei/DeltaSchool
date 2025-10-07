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

        public SchoolYear GetById(int id) => _context.SchoolYears.Find(id);

        public void Add(SchoolYear schoolYear) =>_context.SchoolYears.Add(schoolYear);

        public void Update(SchoolYear schoolYear)
            => _context.Entry(schoolYear).State = System.Data.Entity.EntityState.Modified;

        public void Save() => _context.SaveChanges();
    }
}
