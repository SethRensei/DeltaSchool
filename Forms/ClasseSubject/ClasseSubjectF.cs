using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Forms.ClasseSubject
{
    public partial class ClasseSubjectF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ClasseSubjectService _service;

        private Data.Entity.ClasseSubject _clSb;
        private int _csId;

        private bool _isEdit = false;
        public ClasseSubjectF()
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new ClasseSubjectService(_uow);
            _csId = -1;
        }

        private void ClasseSubject_Load(object sender, EventArgs e)
        {
            AllLoadCbx();
            LoadClasseSubjects();

            txtCoeff.KeyPress += GlobalEvent.NumberOnly;
            dgvClasseSubject.DataGrid.CellClick += DgvClasseSubject_CellClick;
            dgvClasseSubject.DataGrid.CellDoubleClick += (s, ce) =>
            {
                this._csId = GlobalEvent.IDFromCellDGV(ce, dgvClasseSubject.DataGrid);
                this._clSb = _uow.ClasseSubjects.GetById(_csId);
                if (this._clSb == null) return;
                this._isEdit = true;
                txtCoeff.Texts = Convert.ToString(this._clSb.Coeff);
                cbSubject.SelectedValue = this._clSb.Subject.Id;
                cbClasse.SelectedValue = this._clSb.Classe.Id;
                if (this._clSb.StaffId != null)
                    cbStaff.SelectedValue = this._clSb.StaffId;
                else
                    cbStaff.SelectedIndex = -1;

                btnSave.Text = "Modifier";
                btnDelete.Visible = false;
            };
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(this._isEdit == false)
            {
                var cs = new Data.Entity.ClasseSubject
                {
                    ClasseId = Convert.ToInt32(cbClasse.SelectedValue.ToString()),
                    SubjectId = Convert.ToInt32(cbSubject.SelectedValue.ToString()),
                    Coeff = Convert.ToInt32(txtCoeff.Texts),
                };

                if (cbStaff.SelectedIndex == -1) cs.StaffId = null;
                else cs.StaffId = Convert.ToInt32(cbStaff.SelectedValue.ToString());

                if (!_service.Create(cs))
                    ShowAlert.WarningMsg("Ajout échoué");
                else
                {
                    AllLoadCbx();
                    LoadClasseSubjects();
                    ResetValue();
                }
            }
            else
            {
                this._clSb.Coeff = Convert.ToInt32(txtCoeff.Texts);
                this._clSb.ClasseId = Convert.ToInt32(cbClasse.SelectedValue.ToString());
                this._clSb.SubjectId = Convert.ToInt32(cbSubject.SelectedValue.ToString());

                if (cbStaff.SelectedIndex == -1) _clSb.StaffId = null;
                else _clSb.StaffId = Convert.ToInt32(cbStaff.SelectedValue.ToString());
                if (_service.Update(this._clSb))
                {
                    AllLoadCbx();
                    LoadClasseSubjects();
                    ResetValue();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this._csId == -1)
            {
                ShowAlert.InfoMsg("Veuillez sélectionner unz fonction.");
                return;
            }
            else
            {
                if (ShowAlert.RemoveItem() != DialogResult.Yes) return;
                if (!_service.Delete(this._csId))
                    ShowAlert.WarningMsg("Échec de la suppression.");
                else
                {
                    LoadClasseSubjects();
                    ResetValue();
                }
            }
        }

        private void DgvClasseSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Visible = true;
            this._csId = GlobalEvent.IDFromCellDGV(e, dgvClasseSubject.DataGrid);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            AllLoadCbx();
            LoadClasseSubjects();
            ResetValue();
        }

        private void ClasseSubjectF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        #region -> Private Methods

        private void AllLoadCbx()
        {
            // Classe
            var classes = _uow.Classes.GetAll();
            cbClasse.DataSource = classes;
            cbClasse.ValueMember = "Id";
            cbClasse.DisplayMember = "Name";
            cbClasse.SelectedIndex = 0;                

            // Subject
            var subjects = _uow.Subjects.GetAll();
            cbSubject.DataSource = subjects;
            cbSubject.ValueMember = "Id";
            cbSubject.DisplayMember = "Name";


            // Staff
            var staffs = _uow.Staffs.GetAll()
                .Select(s => new { s.Id, FullName = $"{s.Lastname} {s.Firstname}" })
                .ToList();

            cbStaff.DataSource = staffs;
            cbStaff.ValueMember = "Id";
            cbStaff.DisplayMember = "FullName";
            cbStaff.SelectedIndex = -1; // Set null
        }

        private void LoadClasseSubjects()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Classe");
            dt.Columns.Add("Matière");
            dt.Columns.Add("Coeff");
            dt.Columns.Add("Professeur");

            var cs = _uow.ClasseSubjects.GetAll();
            foreach (var c in cs)
                dt.Rows.Add(c.Id, c.Classe.Name,
                    c.Subject.Name, c.Coeff,
                    c.Staff != null
                    ? $"{c.Staff.Lastname} {c.Staff.Firstname}"
                    : "N/A");

            dgvClasseSubject.SetData(dt);
            dgvClasseSubject.Visible = true;
        }

        private void ResetValue()
        {
            txtCoeff.Texts = string.Empty;
            btnSave.Text = "Enregistrer";
            this._isEdit = false;
            this._csId = -1;
            btnDelete.Visible = false;
        }
        #endregion
    }
}
