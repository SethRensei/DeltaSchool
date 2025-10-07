using System.Collections.Generic;
using System.Linq;
using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IPayrollRepository
    {
        IQueryable<Payroll> Query();
        Payroll GetById(int id);
        void Add(Payroll payroll);
        void Update(Payroll payroll);
    }
}
