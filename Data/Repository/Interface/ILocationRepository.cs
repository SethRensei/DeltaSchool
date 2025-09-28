using System.Collections.Generic;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface ILocationRepository
    {
        IEnumerable<Sites> GetAll();
        Sites GetById(int id);
        void Add(Sites location);
        void Update(Sites location);
        void Delete(int id);
        void Save();
    }
}
