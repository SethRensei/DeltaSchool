using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace DeltaSchool.Core.Services
{
    public class PayrollService
    {
        private readonly IUnitOfWork _uow;

        public PayrollService(IUnitOfWork uow)
            => _uow = uow;

        public bool Create(Payroll p)
        {
            if (p.Status == "PAID")
            {
                var exists = _uow.Payrolls.Query()
                    .Any(x => x.Id != p.Id && x.StaffId == p.StaffId && x.Period == p.Period && x.Status == "PAID");

                if (exists)
                {
                    ShowAlert.ErrorMsg("Impossible : un autre paiement marqué comme ≪ Payé ≫ existe déjà pour ce personnel pour cette période.");
                    return false;
                }
            }
            if (!FormValidator.Validate(p))
                return false;

            try
            {
                _uow.Payrolls.Add(p);
                _uow.Save();
                ShowAlert.SuccessMsg("La transaction a été enregistré.");
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                var baseEx = dbEx.GetBaseException();
                if (baseEx is MySqlException mex)
                {
                    if (mex.Number == 1062)
                        ShowAlert.ErrorMsg("Existance d'un paiement identique qui a déjà été marqué comme ≪ Payé ≫");
                    var msg = MySqlExceptionHelper.TryParseDuplicateEntry(mex) ?? mex.Message;
                    ShowAlert.ErrorMsg(msg);
                }
                else
                {
                    ShowAlert.ErrorMsg(baseEx.Message);
                }

                // IMPORTANT : détacher l'entité qui a échoué
                _uow.DetachEntity(p);  // ou _uow.ClearChangeTracker();

                return false;
            }
            catch (Exception ex)
            {
                ShowAlert.ErrorMsg($"Erreur: {ex.Message}");
                return false;
            }
        }

        public bool Update(Payroll p)
        {
            if (!FormValidator.Validate(p))
                return false;

            try
            {
                _uow.Payrolls.Update(p);
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
                        ShowAlert.ErrorMsg("Existance d'un paiement identique qui a déjà été marqué comme ≪ Payé ≫");
                    var msg = MySqlExceptionHelper.TryParseDuplicateEntry(mex) ?? mex.Message;
                    ShowAlert.ErrorMsg(msg);
                }
                else
                {
                    ShowAlert.ErrorMsg(baseEx.Message);
                }

                _uow.DetachEntity(p);

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
