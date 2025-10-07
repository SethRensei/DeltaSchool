using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class StaffRepository : IStaffRepository
    {
        private readonly DeltaSchoolContext _context;

        public StaffRepository(DeltaSchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Staff> GetAll()
        {
            return _context.Staffs.ToList();
        }

        public Staff GetById(int id) => _context.Staffs.Find(id);
        
        public void Add(Staff staff) => _context.Staffs.Add(staff);

        public Staff FindByMatricule(string matricule)
            => _context.Staffs
            .Include(s => s.StaffJobs)
            .Include(s => s.Payrolls)
            .FirstOrDefault(s => s.Matricule == matricule.ToUpper());

        public void Update(Staff staff)
            => _context.Entry(staff).State = EntityState.Modified;

        public void Delete(int id)
        {
            var staff = _context.Staffs.Find(id);
            if (staff != null)
                _context.Staffs.Remove(staff);
        }

        public void Save() => _context.SaveChanges();
    }
}
