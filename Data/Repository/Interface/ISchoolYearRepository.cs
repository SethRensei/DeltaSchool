using System.Collections.Generic;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface ISchoolYearRepository
    {
        IEnumerable<SchoolYear> GetAll();
        SchoolYear GetById(int id);
        void Add(SchoolYear schoolYear);
        void Update(SchoolYear schoolYear);
        void Save();
    }
}
