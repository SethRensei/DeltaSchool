using System.Data.Entity;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly DeltaSchoolContext _context;

        public ExpenseRepository(DeltaSchoolContext context)
            => _context = context;

        public IQueryable<Expense> Query()
            => _context.Expenses
            .AsNoTracking();

        public Expense GetById(int id)
            => _context.Expenses.Find(id);

        public void Add(Expense expense)
            => _context.Expenses.Add(expense);

        public void Update(Expense expense)
            => _context.Entry(expense).State = EntityState.Modified;

    }
}
