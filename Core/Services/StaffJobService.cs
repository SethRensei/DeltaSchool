using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaSchool.Core.Services
{
    public class StaffJobService
    {
        private readonly IUnitOfWork _uow;

        public StaffJobService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public bool Create(StaffJob sj)
        {
            if (!FormValidator.Validate(sj))
                return false;

            try
            {
                _uow.StaffJobs.Add(sj);
                _uow.Save();
                ShowAlert.SuccessMsg("Fontion/Poste ajouté avec succès.");
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
                _uow.DetachEntity(sj);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg($"Erreur: {ex.Message}");
                return false;
            }
        }

        public bool Update(StaffJob sj)
        {
            if (!FormValidator.Validate(sj))
                return false;

            try
            {
                _uow.StaffJobs.Update(sj);
                _uow.Save();
                ShowAlert.SuccessMsg("Information de la fontion/poste a été modifié avec succes.");
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
                _uow.DetachEntity(sj);  // ou _uow.ClearChangeTracker();

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
                _uow.StaffJobs.Delete(id);
                _uow.Save();
                ShowAlert.SuccessMsg("Fontion/Poste a été supprimé.");
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
