using System.Collections.Generic;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IStaffJobRepository
    {
        IEnumerable<StaffJob> GetAll();
        StaffJob GetById(int id);
        void Add(StaffJob sj);
        void Update(StaffJob sj);
        void Delete(int id);
        void Save();
    }
}
