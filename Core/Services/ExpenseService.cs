using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Core.Services
{
    public class ExpenseService
    {
        private readonly IUnitOfWork _uow;

        public ExpenseService(IUnitOfWork uow) => _uow = uow;

        public bool Create(Expense e)
        {
            if (!FormValidator.Validate(e))
                return false;
            try
            {
                _uow.Expenses.Add(e);
                _uow.Save();
                ShowAlert.SuccessMsg("Dépense interne ajoutée avec succès.");
                return true;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg($"Erreur: {ex.Message}");
                return false;
            }
        }

        public bool Update(Expense e)
        {
            if (!FormValidator.Validate(e))
                return false;
            try
            {
                _uow.Expenses.Update(e);
                _uow.Save();
                ShowAlert.SuccessMsg("Dépense interne mise à jour avec succès.");
                return true;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg($"Erreur: {ex.Message}");
                return false;
            }
        }

        public IEnumerable<Expense> GetAll()
            => _uow.Expenses.Query()
                .Include(e => e.ExpenseCategory)
                .AsNoTracking()
                .ToList();
    }
}
