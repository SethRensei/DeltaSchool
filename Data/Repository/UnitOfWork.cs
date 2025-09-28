using System;
using System.Data.Entity;

using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DeltaSchoolContext _context;

        private LocationRepository _locatRepo;
        private SchoolYearRepository _schoolYearRepo;
        private ParentStudentRepository _parentRepo;
        private SubjectRepository _subjectRepo;
        private ClasseRepository _classeRepo;
        private JobRepository _jobRepo;
        private StaffRepository _staffRepo;
        private ClasseSubjectRepository _classeSubjectRepo;
        private StudentRepository _studentRepo;

        private DbContextTransaction _transaction;
        private bool _disposed = false;

        public UnitOfWork(DeltaSchoolContext context)
        {
            _context = context;
        }

        public ILocationRepository Locations 
            => _locatRepo ?? (_locatRepo = new LocationRepository(_context));

        public ISchoolYearRepository SchoolYears
            => _schoolYearRepo ?? (_schoolYearRepo = new SchoolYearRepository(_context));

        public IParentStudentRepository ParentStudents 
            => _parentRepo ?? (_parentRepo = new ParentStudentRepository(_context));

        public ISubjectRepository Subjects 
            => _subjectRepo ?? (_subjectRepo = new SubjectRepository(_context));

        public IClasseRepository Classes
            => _classeRepo ?? (_classeRepo = new ClasseRepository(_context));

        public IJobRepository Jobs
            => _jobRepo ?? (_jobRepo = new JobRepository(_context));

        public IStaffRepository Staffs
            => _staffRepo ?? (_staffRepo = new StaffRepository(_context));

        public IClasseSubjectRepository ClasseSubjects
            => _classeSubjectRepo ?? (_classeSubjectRepo = new ClasseSubjectRepository(_context));

        public IStudentRepository Students
            => _studentRepo ?? (_studentRepo = new StudentRepository(_context));
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
