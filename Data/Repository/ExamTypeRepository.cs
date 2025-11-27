using System.Data.Entity;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class ExamTypeRepository : IExamTypeRepository
    {
        private readonly DeltaSchoolContext _context;
        public ExamTypeRepository(DeltaSchoolContext context)
            => _context = context;

        public IQueryable<ExamType> Query()
            => _context.ExamTypes
            .AsNoTracking();

        public ExamType GetById(int id) => _context.ExamTypes.Find(id);
        public void Add(ExamType exam) => _context.ExamTypes.Add(exam);
        public void Update(ExamType exam)
            => _context.Entry(exam).State = EntityState.Modified;
        public void Delete(int id)
        {
            var e = _context.ExamTypes.Find(id);
            if (e != null)
                _context.ExamTypes.Remove(e);
        }
        public void Save() => _context.SaveChanges();
    }
}
