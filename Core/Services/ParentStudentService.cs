using System;
using MySql.Data.MySqlClient;

using DeltaSchool.Core;
using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Services
{
    public class ParentStudentService
    {
        private readonly IUnitOfWork _uow;

        public ParentStudentService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public bool Create(ParentStudent parent)
        {
            if (!FormValidator.Validate(parent))
                return false;

            try
            {
                _uow.ParentStudents.Add(parent);
                _uow.Save();
                ShowAlert.DisplayMessage("Parent ajouté avec succès.", ShowAlert.A_type.Success);
                return true;
            }
            catch (MySqlException mex)
            {
                var friendly = MySqlExceptionHelper.TryParseDuplicateEntry(mex);
                ShowAlert.DisplayMessage(friendly ?? mex.Message, ShowAlert.A_type.Error);
                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.DisplayMessage($"Erreur: {ex.Message}", ShowAlert.A_type.Error);
                return false;
            }
        }

        // Update/Delete idem...
    }
}
