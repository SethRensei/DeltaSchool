using System.Data.Entity;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class ExpenseCategoryRepository : IExpenseCategoryRepository
    {
        private readonly DeltaSchoolContext _context;

        public ExpenseCategoryRepository(DeltaSchoolContext context)
            => _context = context;

        public IQueryable<ExpenseCategory> Query()
            => _context.ExpenseCategories
            .AsNoTracking();

        public ExpenseCategory GetById(int id)
            => _context.ExpenseCategories.Find(id);

        public void Add(ExpenseCategory expenseCategory)
            => _context.ExpenseCategories.Add(expenseCategory);

        public void Update(ExpenseCategory expenseCategory)
            => _context.Entry(expenseCategory).State = EntityState.Modified;
        
        public void Delete(int id)
        {
            var expenseCategory = _context.ExpenseCategories.Find(id);
            if (expenseCategory != null)
            {
                _context.ExpenseCategories.Remove(expenseCategory);
            }
        }
    }
}
