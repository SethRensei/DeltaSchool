using System.Collections.Generic;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IClasseRepository
    {
        IEnumerable<Classe> GetAll();
        Classe GetById(int id);
        void Add(Classe parent);
        void Update(Classe parent);
        void Delete(int id);
        void Save();
    }
}
