using System.Collections.Generic;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IStaffRepository
    {
        IEnumerable<Staff> GetAll();
        Staff GetById(int id);
        Staff FindByMatricule(string matricule);
        void Add(Staff staff);
        void Update(Staff staff);
        void Delete(int id);
        void Save();
    }
}
