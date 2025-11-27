using System.Data.Entity;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class PayrollRepository : IPayrollRepository
    {
        private readonly DeltaSchoolContext _context;

        public PayrollRepository(DeltaSchoolContext context)
            => _context = context;

        public IQueryable<Payroll> Query()
            => _context.Payrolls
            .Include(pr => pr.Staff)
            .OrderByDescending(pr => pr.Id)
            .AsNoTracking();

        public Payroll GetById(int id) => _context.Payrolls.Find(id);

        public void Add(Payroll payroll) => _context.Payrolls.Add(payroll);

        public void Update(Payroll payroll)
            => _context.Entry(payroll).State = EntityState.Modified;
    }
}
