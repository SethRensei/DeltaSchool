using DeltaSchool.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface ISchoolingRepository
    {
        IQueryable<Schooling> Query();
        Schooling GetById(int id);
        IEnumerable<Schooling> GetBySchoolYearAndStudent(int schoolYear, int student);
        void Add(Schooling schooling);
        void Update(Schooling schooling);
    }
}
