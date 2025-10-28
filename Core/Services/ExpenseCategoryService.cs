using MySql.Data.MySqlClient;
using System;
using System.Data.Entity.Infrastructure;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Core.Services
{
    public class ExpenseCategorieservice
    {
        private readonly IUnitOfWork _uow;
        public ExpenseCategorieservice(IUnitOfWork uow)
            => _uow = uow;


        public bool Create(ExpenseCategory c)
        {
            if (!FormValidator.Validate(c))
                return false;

            try
            {
                _uow.ExpenseCategories.Add(c);
                _uow.Save();
                ShowAlert.SuccessMsg("Catégorie de dépense ajouté avec succès.");
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                var baseEx = dbEx.GetBaseException();
                if (baseEx is MySqlException mex)
                {
                    var msg = MySqlExceptionHelper.TryParseDuplicateEntry(mex) ?? mex.Message;
                    ShowAlert.ErrorMsg(msg);
                }
                else
                {
                    ShowAlert.ErrorMsg(baseEx.Message);
                }

                // IMPORTANT : détacher l'entité qui a échoué
                _uow.DetachEntity(c);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg($"Erreur: {ex.Message}");
                return false;
            }
        }

        public bool Update(ExpenseCategory c)
        {
            if (!FormValidator.Validate(c))
                return false;

            try
            {
                _uow.ExpenseCategories.Update(c);
                _uow.Save();
                ShowAlert.SuccessMsg("Information de la catégorie de dépense a été modifié avec succes.");
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                var baseEx = dbEx.GetBaseException();
                if (baseEx is MySqlException mex)
                {
                    var msg = MySqlExceptionHelper.TryParseDuplicateEntry(mex) ?? mex.Message;
                    ShowAlert.ErrorMsg(msg);
                }
                else
                {
                    ShowAlert.ErrorMsg(baseEx.Message);
                }

                // IMPORTANT : détacher l'entité qui a échoué
                _uow.DetachEntity(c);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg(ex.Message);
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _uow.ExpenseCategories.Delete(id);
                _uow.Save();
                ShowAlert.SuccessMsg("Catégorie de dépense a été supprimé.");
                return true;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg(ex.Message);
                return false;
            }
        }
    }
}
