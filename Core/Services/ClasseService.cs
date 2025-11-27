using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Data.Entity.Infrastructure;


namespace DeltaSchool.Core.Services
{
    public class ClasseService
    {
        private readonly IUnitOfWork _uow;

        public ClasseService(IUnitOfWork uow) => _uow = uow;

        public bool Create(Classe c)
        {
            if (!FormValidator.Validate(c))
                return false;

            try
            {
                _uow.Classes.Add(c);
                _uow.Classes.Save();
                ShowAlert.SuccessMsg("Classe ajouté avec succès.");
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

        public bool Update(Classe c)
        {
            if (!FormValidator.Validate(c))
                return false;

            try
            {
                _uow.Classes.Update(c);
                _uow.Classes.Save();
                ShowAlert.SuccessMsg("Information de la classe a été modifié avec succes.");
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
                _uow.Classes.Delete(id);
                _uow.Classes.Save();
                ShowAlert.SuccessMsg("Classe a été supprimé.");
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
