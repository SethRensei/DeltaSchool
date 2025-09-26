using System;
using System.Data.Entity;

using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DeltaSchoolContext _context;
        private ParentStudentRepository _parentRepo;
        private SubjectRepository _subjectRepo;
        private ClasseRepository _classeRepo;
        private DbContextTransaction _transaction;
        private bool _disposed = false;

        public UnitOfWork(DeltaSchoolContext context)
        {
            _context = context;
        }

        public IParentStudentRepository ParentStudents 
            => _parentRepo ?? (_parentRepo = new ParentStudentRepository(_context));

        public ISubjectRepository Subjects 
            => _subjectRepo ?? (_subjectRepo = new SubjectRepository(_context));

        public IClasseRepository Classes
            => _classeRepo ?? (_classeRepo = new ClasseRepository(_context));


        public DbContextTransaction BeginTransaction()
        {
            if (_transaction == null)
                _transaction = _context.Database.BeginTransaction();
            return _transaction;
        }

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
                _transaction?.Commit();
            }
            finally
            {
                _transaction?.Dispose();
                _transaction = null;
            }
        }

        public void Rollback()
        {
            try
            {
                _transaction?.Rollback();
            }
            finally
            {
                _transaction?.Dispose();
                _transaction = null;
            }
        }

        public int Save() => _context.SaveChanges();

        public void Dispose()
        {
            if (!_disposed)
            {
                _transaction?.Dispose();
                _context.Dispose();
                _disposed = true;
            }
        }

        public void DetachEntity(object entity)
        {
            var entry = _context.Entry(entity);
            if (entry != null)
                entry.State = System.Data.Entity.EntityState.Detached;
        }
    }
}
