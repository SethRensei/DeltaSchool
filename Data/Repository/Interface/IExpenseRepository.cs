using DeltaSchool.Data.Entity;
using System.Linq;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IExpenseRepository
    {
        IQueryable<Expense> Query();
        Expense GetById(int id);
        void Add(Expense expense);
        void Update(Expense expense);
    }
}
