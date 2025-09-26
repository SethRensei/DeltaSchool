using System;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IParentStudentRepository ParentStudents { get; }
        ISubjectRepository Subjects { get; }
        IClasseRepository Classes { get; }

        // transaction handling
        System.Data.Entity.DbContextTransaction BeginTransaction();
        void Commit();
        void Rollback();

        int Save();

        void DetachEntity(object entity);
    }
}
