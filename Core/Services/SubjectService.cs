using System;
using MySql.Data.MySqlClient;

using DeltaSchool.Core;
using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using System.Data.Entity.Infrastructure;


namespace DeltaSchool.Core.Services
{
    public class SubjectService
    {
        private readonly IUnitOfWork _uow;

        public SubjectService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public bool Create(Subject s)
        {
            if (!FormValidator.Validate(s))
                return false;

            try
            {
                _uow.Subjects.Add(s);
                _uow.Save();
                ShowAlert.DisplayMessage("Matière ajouté avec succès.", ShowAlert.A_type.Success);
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                var baseEx = dbEx.GetBaseException();
                if (baseEx is MySqlException mex)
                {
                    var msg = MySqlExceptionHelper.TryParseDuplicateEntry(mex) ?? mex.Message;
                    ShowAlert.DisplayMessage(msg, ShowAlert.A_type.Error);
                }
                else
                {
                    ShowAlert.DisplayMessage(baseEx.Message, ShowAlert.A_type.Error);
                }

                // IMPORTANT : détacher l'entité qui a échoué
                _uow.DetachEntity(s);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.DisplayMessage($"Erreur: {ex.Message}", ShowAlert.A_type.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Update(Subject s)
        {
            if (!FormValidator.Validate(s))
                return false;

            try
            {
                _uow.Subjects.Update(s);
                _uow.Save();
                ShowAlert.DisplayMessage("Information de la matière mis à jour.", ShowAlert.A_type.Success);
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                var baseEx = dbEx.GetBaseException();
                if (baseEx is MySqlException mex)
                {
                    var msg = MySqlExceptionHelper.TryParseDuplicateEntry(mex) ?? mex.Message;
                    ShowAlert.DisplayMessage(msg, ShowAlert.A_type.Error);
                }
                else
                {
                    ShowAlert.DisplayMessage(baseEx.Message, ShowAlert.A_type.Error);
                }

                // IMPORTANT : détacher l'entité qui a échoué
                _uow.DetachEntity(s);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.DisplayMessage(ex.Message, ShowAlert.A_type.Error);
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _uow.Subjects.Delete(id);
                _uow.Save();
                ShowAlert.DisplayMessage("La matière vient d'être supprimé.", ShowAlert.A_type.Success);
                return true;
            }
            catch (Exception ex)
            {
                ShowAlert.DisplayMessage(ex.Message, ShowAlert.A_type.Error);
                return false;
            }
        }
    }
}
