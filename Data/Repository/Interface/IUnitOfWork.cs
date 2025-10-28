using System;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ILocationRepository Locations { get; }
        ISchoolYearRepository SchoolYears { get; }
        IParentStudentRepository ParentStudents { get; }
        ISubjectRepository Subjects { get; }
        IClasseRepository Classes { get; }
        IJobRepository Jobs { get; }
        IStaffRepository Staffs { get; }
        IPayrollRepository Payrolls { get; }
        IStaffJobRepository StaffJobs { get; }
        IClasseSubjectRepository ClasseSubjects { get; }
        IStudentRepository Students { get; }
        ISchoolingRepository Schoolings { get; }
        IExpenseRepository Expenses { get; }
        IExpenseCategoryRepository ExpenseCategories { get; }

        // transaction handling
        System.Data.Entity.DbContextTransaction BeginTransaction();
        void Commit();
        void Rollback();

        int Save();

        void DetachEntity(object entity);
    }
}
