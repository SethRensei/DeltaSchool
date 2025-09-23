using System;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IParentStudentRepository ParentStudents { get; }

        // transaction handling
        System.Data.Entity.DbContextTransaction BeginTransaction();
        void Commit();
        void Rollback();

        int Save();
    }
}
