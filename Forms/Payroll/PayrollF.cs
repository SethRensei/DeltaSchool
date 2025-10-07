using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using DeltaSchool.Utilities.Extensions;

namespace DeltaSchool.Forms.Payroll
{
    public partial class PayrollF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly PayrollService _service;

        private Data.Entity.Staff _staff;

        public PayrollF()
        {
            InitializeComponent();
            this.KeyPreview = true;

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new PayrollService(_uow);
        }

        private void PayrollF_Load(object sender, EventArgs e)
        {
            cbPeriod.SelectedIndex = -1;
        }

        private void PayrollF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Search();
                e.Handled = true;
            }
        }

        private void PayrollF_FormClosed(object sender, FormClosedEventArgs e)
            => _uow.Dispose();

        #region -> Private methods

        private void Search()
        {
            if (string.IsNullOrWhiteSpace(txtMatricule.Texts))
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

                FillDGV(_staff.Payrolls);
            }
        }

        private void FillDGV(IEnumerable<Data.Entity.Payroll> payrolls)
        {
            dgvPayroll.Rows.Clear();

            foreach (var p in payrolls)
            {
                int row_index = dgvPayroll.Rows.Add();
                dgvPayroll.Rows[row_index].Cells["colPeriod"].Value = p.Period;
                dgvPayroll.Rows[row_index].Cells["colStatus"].Value = TransacStatusMapper.GetLabelFromDbValue(p.Status);
                dgvPayroll.Rows[row_index].Cells["colAmount"].Value = $"{p.Amount} XAF";
                dgvPayroll.Rows[row_index].Cells["colNetPay"].Value = $"{p.NetPay} XAF";
                dgvPayroll.Rows[row_index].Cells["colResidual"].Value = $"{p.ResidualAmount} XAF";
                dgvPayroll.Rows[row_index].Cells["colDate"].Value = p.PaidAt.ToString("D");
                dgvPayroll.Rows[row_index].Cells["colNote"].Value = p.Notes;
            }

            dgvPayroll.Visible = true;
            dgvPayroll.Refresh();
        }
        #endregion
    }
}
