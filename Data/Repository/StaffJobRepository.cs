using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class StaffJobRepository : IStaffJobRepository
    {
        private readonly DeltaSchoolContext _context;

        public StaffJobRepository(DeltaSchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<StaffJob> GetAll()
        {
            return _context.StaffJobs
                .Include(sj => sj.Staff)
                .Include(sj => sj.Job)
                .AsNoTracking()
                .ToList();
        }

        public StaffJob GetById(int id)
        {
            return _context.StaffJobs
                .Include(sj => sj.Staff)
                .Include(sj => sj.Job)
                .AsNoTracking()
                .FirstOrDefault(sj => sj.Id == id);
        }

        public void Add(StaffJob sj) =>_context.StaffJobs.Add(sj);
        
        public void Update(StaffJob sj) =>_context.Entry(sj).State = EntityState.Modified;
        
        public void Delete(int id)
        {
            var sj = _context.StaffJobs.Find(id);
            if (sj != null)
                _context.StaffJobs.Remove(sj);
        }

        public void Save() => _context.SaveChanges();
    }
}
