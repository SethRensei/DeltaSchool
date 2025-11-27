using System.Linq;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IExamTypeRepository
    {
        IQueryable<ExamType> Query();
        ExamType GetById(int id);
        void Add(ExamType exam);
        void Update(ExamType exam);
        void Delete(int id);
        void Save();
    }
}
