using MySql.Data.MySqlClient;
using System;
using System.Data.Entity.Infrastructure;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Core.Services
{
    public class ClasseSubjectService
    {
        private readonly IUnitOfWork _uow;

        public ClasseSubjectService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public bool Create(ClasseSubject cs)
        {
            if (!FormValidator.Validate(cs))
                return false;

            try
            {
                _uow.ClasseSubjects.Add(cs);
                _uow.Save();
                ShowAlert.SuccessMsg("Assignation classe - matière ajouté avec succès.");
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
                _uow.DetachEntity(cs);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg($"Erreur: {ex.Message}");
                return false;
            }
        }

        public bool Update(ClasseSubject cs)
        {
            if (!FormValidator.Validate(cs))
                return false;

            try
            {
                _uow.ClasseSubjects.Update(cs);
                _uow.Save();
                ShowAlert.SuccessMsg("Information d'insignation classe - matière a été modifié avec succes.");
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
                _uow.DetachEntity(cs);  // ou _uow.ClearChangeTracker();

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
                _uow.ClasseSubjects.Delete(id);
                _uow.Save();
                ShowAlert.SuccessMsg("Assignation classe - matière a été supprimé avec succès.");
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
