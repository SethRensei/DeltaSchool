using MySql.Data.MySqlClient;
using System;
using System.Data.Entity.Infrastructure;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Core.Services
{
    public class StaffService
    {
        private readonly IUnitOfWork _uow;

        public StaffService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public bool Create(Staff staff)
        {
            if (!FormValidator.Validate(staff))
                return false;

            try
            {
                _uow.Staffs.Add(staff);
                _uow.Save();
                ShowAlert.SuccessMsg("Personnel ajouté avec succès.");
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
                _uow.DetachEntity(staff);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg($"Erreur: {ex.Message}");
                return false;
            }
        }

        public bool Update(Staff staff)
        {
            if (!FormValidator.Validate(staff))
                return false;

            try
            {
                _uow.Staffs.Update(staff);
                _uow.Save();
                ShowAlert.SuccessMsg("Information du personnel a été mis à jour.");
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
                _uow.DetachEntity(staff);  // ou _uow.ClearChangeTracker();

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
                _uow.Staffs.Delete(id);
                _uow.Save();
                ShowAlert.SuccessMsg("Personnel supprimé avec succès.");
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
