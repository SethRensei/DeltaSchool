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

        public ClasseService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public bool Create(Classe c)
        {
            if (!FormValidator.Validate(c))
                return false;

            try
            {
                _uow.Classes.Add(c);
                _uow.Save();
                ShowAlert.DisplayMessage("Classe ajouté avec succès.", ShowAlert.A_type.Success);
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
                _uow.DetachEntity(c);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.DisplayMessage($"Erreur: {ex.Message}", ShowAlert.A_type.Error);
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
                _uow.Save();
                ShowAlert.DisplayMessage("Information de la classe a été modifié avec succes.", ShowAlert.A_type.Success);
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
                _uow.DetachEntity(c);  // ou _uow.ClearChangeTracker();

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
                _uow.Classes.Delete(id);
                _uow.Save();
                ShowAlert.DisplayMessage("Classe a été supprimé.", ShowAlert.A_type.Success);
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
