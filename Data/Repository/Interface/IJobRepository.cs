using System.Collections.Generic;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IJobRepository
    {
        IEnumerable<Job> GetAll();
        Job GetById(int id);
        void Add(Job job);
        void Update(Job job);
        void Delete(int id);
        void Save();
    }
}
