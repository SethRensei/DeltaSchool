using System.Collections.Generic;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IClasseSubjectRepository
    {
        IEnumerable<ClasseSubject> GetAll();
        ClasseSubject GetById(int id);
        void Add(ClasseSubject cs);
        void Update(ClasseSubject cs);
        void Delete(int id);
        void Save();
    }
}
