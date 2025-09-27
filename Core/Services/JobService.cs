using MySql.Data.MySqlClient;
using System;
using System.Data.Entity.Infrastructure;

using DeltaSchool.Core;
using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Core.Services
{
    public class JobService
    {
        private readonly IUnitOfWork _uow;

        public JobService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public bool Create(Job job)
        {
            if (!FormValidator.Validate(job))
                return false;

            try
            {
                _uow.Jobs.Add(job);
                _uow.Save();
                ShowAlert.SuccessMsg("La fonction pour personnel ajouté avec succès.");
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
                _uow.DetachEntity(job);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg($"Erreur: {ex.Message}");
                return false;
            }
        }

        public bool Update(Job job)
        {
            if (!FormValidator.Validate(job))
                return false;

            try
            {
                _uow.Jobs.Update(job);
                _uow.Save();
                ShowAlert.SuccessMsg("La fonction pour personnel a été mis à jour.");
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
                _uow.DetachEntity(job);  // ou _uow.ClearChangeTracker();

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
                _uow.Jobs.Delete(id);
                _uow.Save();
                ShowAlert.SuccessMsg("La fonction pour personnel a été supprimé.");
                return true;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg(ex.Message   );
                return false;
            }
        }
    }
}
