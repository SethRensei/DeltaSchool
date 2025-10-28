using DeltaSchool.Data.Entity;
using System.Linq;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IExpenseCategoryRepository
    {
        IQueryable<ExpenseCategory> Query();
        ExpenseCategory GetById(int id);
        void Add(ExpenseCategory expenseCategory);
        void Update(ExpenseCategory expenseCategory);
        void Delete(int id);
    }
}
