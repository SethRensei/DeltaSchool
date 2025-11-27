using MySql.Data.MySqlClient;
using System;
using System.Data.Entity.Infrastructure;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Core.Services
{
    public class NoteService
    {
        private readonly IUnitOfWork _uow;

        public NoteService(IUnitOfWork uow) => _uow = uow;

        public bool Create(Note note)
        {
            if (!FormValidator.Validate(note))
                return false;

            try
            {
                _uow.Notes.Add(note);
                _uow.Notes.Save();
                ShowAlert.SuccessMsg("La note de l'élève a été ajoutée");
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                var baseEx = dbEx.GetBaseException();
                if (baseEx is MySqlException mex)
                {
                    if (mex.Number == 1062)
                    {
                        ShowAlert.ErrorMsg("Une note existante a été trouvé pour le même élève sur le même trimestre");
                        return false;
                    }
                    var msg = MySqlExceptionHelper.TryParseDuplicateEntry(mex) ?? mex.Message;
                    ShowAlert.ErrorMsg(msg);
                }
                else
                {
                    ShowAlert.ErrorMsg(baseEx.Message);
                }

                // IMPORTANT : détacher l'entité qui a échoué
                _uow.DetachEntity(note);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception)
            {
                ShowAlert.ErrorMsg("Une erreur est survenue lors de l'ajout de la note");
                return false;
            }
            finally
            {
                _uow.DetachEntity(note);
            }
        }

        private bool Upadte(Note note)
        {
            if (!FormValidator.Validate(note))
                return false;

            try
            {
                _uow.Notes.Update(note);
                _uow.Notes.Save();
                ShowAlert.SuccessMsg("Modification des informations sur la note réussie");
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                var baseEx = dbEx.GetBaseException();
                if (baseEx is MySqlException mex)
                {
                    if (mex.Number == 1062)
                    {
                        ShowAlert.ErrorMsg("Une note existante a été trouvé pour le même élève sur le même trimestre");
                        return false;
                    }
                    var msg = MySqlExceptionHelper.TryParseDuplicateEntry(mex) ?? mex.Message;
                    ShowAlert.ErrorMsg(msg);
                }
                else
                {
                    ShowAlert.ErrorMsg(baseEx.Message);
                }

                // IMPORTANT : détacher l'entité qui a échoué
                _uow.DetachEntity(note);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception)
            {
                ShowAlert.ErrorMsg("Une erreur est survenue lors de la mise à jour d'une note");
                return false;
            }
        }
    }
}
