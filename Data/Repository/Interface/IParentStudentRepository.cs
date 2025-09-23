using System.Collections.Generic;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IParentStudentRepository
    {
        IEnumerable<ParentStudent> GetAll();
        ParentStudent GetById(int id);
        void Add(ParentStudent parent);
        void Update(ParentStudent parent);
        void Delete(int id);
        void Save();
    }
}
