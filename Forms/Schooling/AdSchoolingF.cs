using System;
using System.Linq;
using System.Windows.Forms;

using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Forms.Student;
using DeltaSchool.Utilities;
using DeltaSchool.Utilities.Extensions;

namespace DeltaSchool.Forms.Finance
{
    public partial class AdSchoolingF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly SchoolingService _service;
        private readonly Data.Entity.Student _student;

        private bool _isEdit;

        public AdSchoolingF()
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new SchoolingService(_uow);
        }

        public AdSchoolingF(Data.Entity.Student student)
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new SchoolingService(_uow);

            this._student = student;
        }

        #region -> Private Methods
        private void LoadAllCombo()
        {
            // Payment Method
            cbType.DataSource = Enum.GetValues(typeof(TransacType))
                .Cast<TransacType>()
                .Select(c => new TransacTypeItem { Value = c, Label = c.GetLabel() })
                .ToList();
            cbType.DisplayMember = "Label";
            cbType.ValueMember = "Value";

            // Payment Status
            cbStatus.DataSource = Enum.GetValues(typeof(TransacStatus))
                .Cast<TransacStatus>()
                .Select(c => new TransacStatusItem { Value = c, Label = c.GetLabel() })
                .ToList();
            cbStatus.DisplayMember = "Label";
            cbStatus.ValueMember = "Value";

            // Classe
            var classes = _uow.Classes.GetAll();
            if (classes == null || classes.Count() == 0)
            {
                ShowAlert.InfoMsg("Veuillez d'abord ajouter une classe.");
                this.Close();
                return;
            }
            cbClasse.DataSource = classes;
            cbClasse.DisplayMember = "Name";
            cbClasse.ValueMember = "Id";
            cbClasse.SelectedIndex = -1;

            // School Year
            var schoolYears = _uow.SchoolYears.GetAll();
            if (schoolYears == null || schoolYears.Count() == 0)
            {
                ShowAlert.InfoMsg("Veuillez d'abord ajouter une année scolaire.");
                this.Close();
                return;
            }
            cbSchoolYear.DataSource = schoolYears;
            cbSchoolYear.DisplayMember = "Label";
            cbSchoolYear.ValueMember = "Id";
            cbSchoolYear.SelectedIndex = -1;
        }

        private void ResetValue()
        {
            LoadAllCombo();
            txtAmount.Texts = string.Empty;
            dpPeriod.MaxDate = DateTime.Today;
            dpPeriod.Value = dpPeriod.MaxDate;
            cbPeriod.SelectedIndex = -1;
            cbPeriod.Enabled = false;
        }
        #endregion

        #region -> Events
        private void AdSchoolingF_Load(object sender, EventArgs e)
        {
            LoadAllCombo();
            txtAmount.KeyPress += GlobalEvent.NumberOnly;

            dpPeriod.MaxDate = DateTime.Today;
            dpPeriod.Value = dpPeriod.MaxDate;

            if (_student != null)
                lblInfo.Text += $" {_student.Lastname} {_student.Firstname}";
        }

        private void CbType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedValue.ToString() == "SCHOOL_FEES")
                cbPeriod.Enabled = true;
            else
            {
                cbPeriod.SelectedIndex = -1;
                cbPeriod.Enabled = false;
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetValue();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(this._isEdit ==  false)
            {

                if (cbType.SelectedValue.ToString() == TransacType.SCHOOL_FEES.ToString())
                {
                    if (string.IsNullOrWhiteSpace(cbPeriod.SelectedItem.ToString()))
                    {
                        ShowAlert.ErrorMsg("Veuillez indiquer la période pour les frais de scolarité");
                        return;
                    }
                }

                var period = cbPeriod.SelectedIndex != -1 ? cbPeriod.SelectedItem.ToString() : null;

                var sc = new Data.Entity.Schooling
                {
                    StudentId = _student.Id,
                    Status = cbStatus.SelectedValue.ToString(),
                    Type = cbType.SelectedValue.ToString(),
                    Amount = UHelpers.ConvertAmount(txtAmount.Texts),
                    PaidAt = dpPeriod.Value,
                    Period = period
                };

                if (sc.Amount <= 0)
                    return;

                if (cbClasse.SelectedIndex == -1)
                    sc.ClasseId = _student.ClasseId;
                else
                    sc.ClasseId = Convert.ToInt32(cbClasse.SelectedValue.ToString());
                if(cbSchoolYear.SelectedIndex == -1)
                    sc.SchoolYearId = _student.SchoolYearId;
                else
                    sc.SchoolYearId = Convert.ToInt32(cbSchoolYear.SelectedValue.ToString());

                if (!_service.Create(sc))
                    ShowAlert.WarningMsg("Impossible d'enregistrer cette transaction\nCar il existe une (des) erreur(s).");
                else
                {
                    if (ShowAlert.Question("Voulez-vous effectuer une nouvelle transaction ?") == DialogResult.No)
                        MainForm.Instance.OpenChildForm(new StudentsF());
                    else
                        ResetValue();
                }
            }
        }

        private void AdSchoolingF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        #endregion

    }
}
