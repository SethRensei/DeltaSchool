using System;
using System.Data;
using System.Windows.Forms;

using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Forms.Staff
{
    public partial class JobF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly JobService _service;
        private bool _isEdit = false;
        private int _jobId;
        private Job _job;

        public JobF()
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new JobService(_uow);
            _jobId = -1;
        }

        #region -> Events
        private void JobF_Load(object sender, EventArgs e)
        {
            dgvJob.DataGrid.CellClick += DgvJob_CellClick;
            LoadJobs();
            dgvJob.DataGrid.CellDoubleClick += (s, ce) =>
            {
                this._jobId = GlobalEvent.IDFromCellDGV(ce, dgvJob.DataGrid);
                this._job = _uow.Jobs.GetById(_jobId);
                if (this._job == null) return;
                this._isEdit = true;
                txtJobName.Texts = this._job.Name;
                txtDescription.Texts = this._job.Description;
                btnSave.Text = "Modifier";
                btnDelete.Visible = false;
            };
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if(_isEdit == false)
            {
                var job = new Job
                {
                    Name = UHelpers.ToTitleCase(txtJobName.Texts),
                    Description = UHelpers.GetValueOrtNull(txtDescription.Texts)
                };

                if (!_service.Create(job))
                    ShowAlert.WarningMsg("Ajout échoué");
                else
                {
                    LoadJobs();
                    ResetValue();
                }
            } else
            {
                this._job.Name = UHelpers.ToTitleCase(txtJobName.Texts);
                this._job.Description = UHelpers.GetValueOrtNull(txtDescription.Texts);
                if (_service.Update(this._job))
                {
                    LoadJobs();
                    ResetValue();
                }
            }
        }

        private void DgvJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Visible = true;
            this._jobId = GlobalEvent.IDFromCellDGV(e, dgvJob.DataGrid);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this._jobId == -1)
            {
                ShowAlert.InfoMsg("Veuillez sélectionner unz fonction.");
                return;
            }
            else
            {
                if (ShowAlert.RemoveItem() != DialogResult.Yes) return;
                if (!_service.Delete(this._jobId))
                    ShowAlert.WarningMsg("Échec de la suppression.");
                else
                {
                    LoadJobs();
                    ResetValue();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void JobF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        #endregion

        #region -> Private Methods
        private void LoadJobs()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nom de fonction");
            dt.Columns.Add("Description");

            var jobs = _uow.Jobs.GetAll();
            foreach (var job in jobs)
                dt.Rows.Add(job.Id, job.Name, job.Description);

            dgvJob.SetData(dt);
            dgvJob.Visible = true;
            btnCancel.Visible = true;
        }

        private void ResetValue()
        {
            this.txtJobName.Texts = string.Empty;
            this.txtDescription.Texts = string.Empty;
            this._jobId = -1;
            this._isEdit = false;
            btnSave.Text = "Ajouter";
            btnDelete.Visible = false;
        }

        #endregion
    }
}
