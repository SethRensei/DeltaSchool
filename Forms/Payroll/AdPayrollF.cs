using System;
using System.Linq;
using System.Windows.Forms;

using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using DeltaSchool.Utilities.Extensions;

namespace DeltaSchool.Forms.Payroll
{
    public partial class AdPayrollF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly PayrollService _service;

        private Data.Entity.Staff _staff;

        public AdPayrollF()
        {
            InitializeComponent();
            this.KeyPreview = true;

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new PayrollService(_uow);
        }

        private void AdPayrollF_Load(object sender, EventArgs e)
        {
            txtAmount.KeyPress += GlobalEvent.NumberOnly;

            // Payment Status
            cbStatus.DataSource = Enum.GetValues(typeof(TransacStatus))
                .Cast<TransacStatus>()
                .Select(c => new TransacStatusItem { Value = c, Label = c.GetLabel() })
                .ToList();
            cbStatus.DisplayMember = "Label";
            cbStatus.ValueMember = "Value";

            cbPeriod.SelectedIndex = 0;
        }

        private void AdPayrollF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Search();
                e.Handled = true;
            }
        }

        private void Search()
        {
            if(string.IsNullOrWhiteSpace(txtMatricule.Texts))
            {
                ShowAlert.ErrorMsg("Veuillez entrer le matricule du personnel/employé");
                return;
            }

            this._staff = _uow.Staffs.FindByMatricule(txtMatricule.Texts);
            if (_staff != null)
            {
                txtLastname.Texts = _staff.Lastname;
                txtFirstname.Texts = _staff.Firstname;
                txtAddress.Texts = _staff.Address;
                txtPhone.Texts = _staff.PhoneNumber1;
                txtNetPay.Texts = Convert.ToString(_staff.StaffJobs.Sum(sj => sj.Salary)) + " XAF";

                if(_staff.StaffJobs.Sum(sj => sj.Salary) != 0)
                    gbAdPay.Visible = true;
                else
                {
                    ShowAlert.InfoMsg($"Impossible de faire un paiement\n" +
                        $"Veuillez ajouter une fonction/poste à ce personnel {_staff.Lastname} {_staff.Firstname}");
                    MainForm.Instance.OpenChildForm(new Staff.StaffJobF(_staff.Id,
                        $"{_staff.Lastname} {_staff.Firstname}"));
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_staff != null)
            {
                decimal netPay = _staff.StaffJobs.Sum(sj => sj.Salary);
                decimal amount;
                decimal residual = 0;

                if (!decimal.TryParse(txtAmount.Texts, out amount))
                {
                    ShowAlert.ErrorMsg("Le montant n'est pas valide ou est vide.");
                    return;
                }

                if (amount > netPay)
                {
                    ShowAlert.ErrorMsg("Le montant à payer ne doit pas être supérieur au net à payer");
                    return;
                }

                if (netPay > amount)
                    residual = netPay - amount;

                var payroll = new Data.Entity.Payroll
                {
                    StaffId = _staff.Id,
                    Amount = amount,
                    NetPay = netPay,
                    ResidualAmount = residual,
                    Status = cbStatus.SelectedValue.ToString(),
                    PaidAt = dpPeriod.Value,
                    Period = cbPeriod.SelectedItem.ToString(),
                    Notes = UHelpers.GetValueOrtNull(txtNotes.Texts)
                };

                if (!_service.Create(payroll))
                    ShowAlert.WarningMsg("Impossible d'enregistrer ce paiement\nCar il existe une (des) erreur(s)");
            }
        }

        private void AdPayrollF_FormClosed(object sender, FormClosedEventArgs e)
            => _uow.Dispose();
    }
}
