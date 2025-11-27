using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using DeltaSchool.Utilities.Extensions;

namespace DeltaSchool.Forms.Staff
{
    public partial class StaffJobF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly StaffJobService _service;

        private StaffJob _staffJob;
        private int _staffId = -1, _staffJobId = -1;
        private bool _isEdit = false;
        private string _sInfo = string.Empty;

        public StaffJobF()
        {
            InitializeComponent();
            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new StaffJobService(_uow);

            lblInfo.Text = "Liste de fonctions (postes) pour le personnel";
            btnSave.Enabled = false;
            txtSalary.Enabled = false;
        }
        public StaffJobF(int staffId, string staffName)
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new StaffJobService(_uow);
            _staffId = staffId;
            lblInfo.Text = $"Ajouter une fonction (un poste) pour -> {staffName}";
        }

        #region -> Events
        private void StaffJobF_Load(object sender, EventArgs e)
        {
            var staffJobs = _uow.StaffJobs.GetAll();
            LoadDGV(staffJobs);
            LoadCbx();
            txtSalary.KeyPress += GlobalEvent.NumberOnly;
            dgvStaffJob.DataGrid.CellClick += DgvStaffJob_CellClick;

            dgvStaffJob.DataGrid.CellDoubleClick += (s, ce) =>
            {
                this._staffJobId = GlobalEvent.IDFromCellDGV(ce, dgvStaffJob.DataGrid);
                this._staffJob = _uow.StaffJobs.GetById(_staffJobId);
                if (this._staffJob == null) return;
                this._isEdit = true;
                cbJob.SelectedValue = this._staffJob.Job.Id;
                txtSalary.Texts = Convert.ToString(this._staffJob.Salary);
                if (this._staffJob.Periodicity is string perStr && Enum.TryParse(perStr, out Periodicity selectedPe))
                    cbPeriod.SelectedValue = selectedPe;
                else
                    ShowAlert.WarningMsg("Periodicité introuvable ou mal typé.");

                btnSave.Text = "Modifier";
                btnSave.Enabled = true;
                txtSalary.Enabled = true;
                lblInfo.Text = $"Modification fonction : {this._sInfo}";
                btnDelete.Visible = false;
            };
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(this._isEdit == false)
            {
                var sj = new StaffJob
                {
                    StaffId = this._staffId,
                    JobId = Convert.ToInt32(cbJob.SelectedValue.ToString()),
                    Periodicity = cbPeriod.SelectedValue.ToString(),
                    Salary = Convert.ToDecimal(txtSalary.Texts.Trim())
                };

                if (_service.Create(sj))
                    ResetValue();
                else
                    ShowAlert.WarningMsg("Enregistrement échoué");
            } else
            {
                this._staffJob.JobId = Convert.ToInt32(cbJob.SelectedValue.ToString());
                this._staffJob.Periodicity = cbPeriod.SelectedValue.ToString();
                this._staffJob.Salary = Convert.ToDecimal(txtSalary.Texts.Trim());

                if (_service.Update(this._staffJob))
                    ResetValue();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this._staffJobId != -1)
            {
                if (ShowAlert.RemoveItem() != DialogResult.Yes) return;
                _service.Delete(this._staffJobId);
                ResetValue();
            } else
            {
                ShowAlert.InfoMsg("Veuillez sélectionner une fonction (un poste).");
                return;
            }
        }

        private void DgvStaffJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Visible = true;
            if (e.RowIndex < 0) return; // Header clicked
            var selectedRow = dgvStaffJob.DataGrid.Rows[e.RowIndex];
            this._staffJobId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            this._sInfo = selectedRow.Cells["Enseignant/Personnel"].Value.ToString();
        }

        private void StaffJobF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }
        #endregion

        #region -> Private Methods
        private void LoadDGV(IEnumerable<StaffJob> staffJobs)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Enseignant/Personnel");
            dt.Columns.Add("Poste");
            dt.Columns.Add("Salaire");
            dt.Columns.Add("Périodicité");
            dt.Columns.Add("Date d'embauche");

            foreach(var sj in staffJobs)
                dt.Rows.Add(sj.Id, $"{sj.Staff.Lastname} {sj.Staff.Firstname}",
                    sj.Job.Name, $"{sj.Salary} FCFA",
                    PeriodicityMapper.GetLabelFromDbValue(sj.Periodicity), sj.Staff.HireDate?.ToString("D"));

            dgvStaffJob.SetData(dt);
            dgvStaffJob.Visible = true;
        }

        private void LoadCbx()
        {
            var jobs = _uow.Jobs.GetAll()
                .Select(j => new { j.Id, j.Name})
                .ToList();
            cbJob.DataSource = jobs;
            cbJob.DisplayMember = "Name";
            cbJob.ValueMember = "Id";
            cbJob.SelectedIndex = 0;

            // Periodicity
            cbPeriod.DataSource = Enum.GetValues(typeof(Periodicity))
                .Cast<Periodicity>()
                .Select(m => new PeriodicityItem { Value = m, Label = m.GetLabel() })
                .ToList();
            cbPeriod.DisplayMember = "Label";
            cbPeriod.ValueMember = "Value";
        }

        private void ResetValue()
        {
            LoadCbx();
            var staffJobs = _uow.StaffJobs.GetAll();
            LoadDGV(staffJobs);
            txtSalary.Texts = string.Empty;
            btnDelete.Visible = false;
            btnSave.Text = "Enregistrer";
        }
        #endregion
    }
}
