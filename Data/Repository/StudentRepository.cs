using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DeltaSchoolContext _context;

        public StudentRepository(DeltaSchoolContext context)
            => _context = context;

        public IEnumerable<Student> GetAll()
        {
            return _context.Students
                .Include(s => s.Classe)
                .Include(s => s.Parent)
                .Include(s => s.SchoolYear)
                .Include(s => s.Location)
                .OrderByDescending(s => s.Id)
                .AsNoTracking()   // if readonly -> better performance
                .ToList();
        }

        public IEnumerable<Student> GetByLocaton(int location)
        {
            return _context.Students
                .Where(s => s.LocationId == location)
                .Include(s => s.Classe)
                .Include(s => s.Parent)
                .Include(s => s.SchoolYear)
                .Include(s => s.Location)
                .OrderByDescending(s => s.Id)
                .AsNoTracking()   // if readonly -> better performance
                .ToList();
        }

        public Student GetById(int id) =>_context.Students.Find(id);

        public Student GetByLocationCodeLastnameFirstname(string code, string lastname, string firstname)
        {
            if (string.IsNullOrWhiteSpace(code) ||
            string.IsNullOrWhiteSpace(lastname) ||
            string.IsNullOrWhiteSpace(firstname))
                return null;

            var lc = code.Trim().ToLower();
            var lastn = lastname.Trim().ToLower();
            var firstn = firstname.Trim().ToLower();

            var student = _context.Students
                .Where(s => s.Location.Code == lc &&
                    s.Lastname.ToLower().StartsWith(lastn) &&
                    s.Firstname.ToLower().StartsWith(firstn))
                .Include(s => s.Classe)
                .Include(s => s.SchoolYear)
                .Include(s => s.Schoolings.Select(sc => sc.Classe))
                .Include(s => s.Schoolings.Select(sc => sc.SchoolYear))
                .Include (s => s.Location)
                .AsNoTracking()
                .Take(5)
                .ToList();
            
            if(student.Count == 0) return null;
            if(student.Count == 1) return student[0];

            return student.Count >= 1 ? student[0] : null;
        }

        public void Add(Student student) =>_context.Students.Add(student);
        
        public void Update(Student student) =>_context.Entry(student).State = EntityState.Modified;
        
        public void Save() =>_context.SaveChanges();
    }
}
