using System.Collections.Generic;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface ISubjectRepository
    {
        IEnumerable<Entity.Subject> GetAll();
        Entity.Subject GetById(int id);
        void Add(Entity.Subject subject);
        void Update(Entity.Subject subject);
        void Delete(int id);
        void Save();
    }
}
