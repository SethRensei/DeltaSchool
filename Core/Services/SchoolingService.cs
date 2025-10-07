using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace DeltaSchool.Core.Services
{
    public class SchoolingService
    {
        private readonly IUnitOfWork _uow;

        public SchoolingService(IUnitOfWork uow)
            => _uow = uow;

        public bool Create(Schooling schooling)
        {
            if (schooling.Status == "PAID")
            {
                var exists = _uow.Schoolings.Query()
                    .Any(x => x.StudentId == schooling.StudentId && x.Type == schooling.Type
                    && x.Period == schooling.Period && x.SchoolYearId == schooling.SchoolYearId
                    && x.Status == "PAID");

                if (exists)
                {
                    ShowAlert.ErrorMsg("Un paiement ≪ Payé ≫ de ce type existe déjà pour cet élève et cette période.");
                    return false;
                }
            }

            if (!FormValidator.Validate(schooling))
                return false;


            try
            {
                _uow.Schoolings.Add(schooling);
                _uow.Save();
                ShowAlert.SuccessMsg("Inscription/paiment ajouté..");
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                var baseEx = dbEx.GetBaseException();
                if (baseEx is MySqlException mex)
                {
                    if (mex.Number == 1062)
                        ShowAlert.ErrorMsg("Duplication d'un paiement qui a déjà été marqué comme ≪ Payé ≫");
                    var msg = MySqlExceptionHelper.TryParseDuplicateEntry(mex) ?? mex.Message;
                    ShowAlert.ErrorMsg(msg);
                }
                else
                {
                    ShowAlert.ErrorMsg(baseEx.Message);
                }

                _uow.DetachEntity(schooling);

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg($"Erreur: {ex.Message}");
                return false;
            }
        }

        public bool Update(Schooling schooling)
        {
            if (!FormValidator.Validate(schooling))
                return false;

            try
            {
                _uow.Schoolings.Update(schooling);
                _uow.Save();
                ShowAlert.SuccessMsg("Les informations sur la transtaction a été mis à jour.");
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                var baseEx = dbEx.GetBaseException();
                if (baseEx is MySqlException mex)
                {
                    if (mex.Number == 1062)
                        ShowAlert.ErrorMsg("Duplication d'un paiement qui a déjà été marqué comme ≪ Payé ≫");
                    var msg = MySqlExceptionHelper.TryParseDuplicateEntry(mex) ?? mex.Message;
                    ShowAlert.ErrorMsg(msg);
                }
                else
                {
                    ShowAlert.ErrorMsg(baseEx.Message);
                }

                // IMPORTANT : détacher l'entité qui a échoué
                _uow.DetachEntity(schooling);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg(ex.Message);
                return false;
            }
        }
    }
}
