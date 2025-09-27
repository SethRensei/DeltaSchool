using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using DeltaSchool.Utilities.Extensions;
using System;
using System.Data;
using System.Windows.Forms;

namespace DeltaSchool.Forms.ClasseSubject
{
    public partial class ClasseAndSubjectF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ClasseService _classeService;
        private readonly SubjectService _subjectService;
        private int _classeId, _subjectId;

        public ClasseAndSubjectF()
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _classeService = new ClasseService(_uow);
            _subjectService = new SubjectService(_uow);
            this._classeId = -1; this._subjectId = -1;
        }

        private void ClasseAndSubjectF_Load(object sender, System.EventArgs e)
        {
            LoadClasses();
            LoadSubjects();
            dgvClasse.DataGrid.CellClick += DgvClasse_CellClick;
            dgvSubject.DataGrid.CellClick += DgvSubject_CellClick;
        }


        private void LoadClasses()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Cycle");
            dt.Columns.Add("Catégorie");

            var classes = _uow.Classes.GetAll();
            foreach (var classe in classes)
                dt.Rows.Add(classe.Id, classe.Name, CycleMapper.GetLabelFromDbValue(classe.Cycle), classe.Category == "PASS" ? "Classe de passage": "Classe d'examen");

            dgvClasse.SetData(dt);
            dgvClasse.Visible = true;
            lblClasses.Visible = true;
        }

        private void LoadSubjects()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            var subjects = _uow.Subjects.GetAll();
            foreach (var subject in subjects)
                dt.Rows.Add(subject.Id, subject.Name);
            dgvSubject.SetData(dt);
            dgvSubject.Visible = true;
            lblSubject.Visible = true;
        }

        private void BtnOpenAdClasseAndSubjectF_Click(object sender, System.EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new AdClasseAndSubjectF());
        }

        private void ClasseAndSubjectF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        private void DgvClasse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteClasse.Visible = true; btnEditClasse.Visible = true;
            if (e.RowIndex < 0) return; // Header clicked
            var selectedRow = dgvClasse.DataGrid.Rows[e.RowIndex];
            this._classeId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

        }

        private void BtnEditClasse_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new AdClasseAndSubjectF(classe : this._classeId));
        }

        private void BtnDeleteClasse_Click(object sender, EventArgs e)
        {
            if (this._classeId == -1)
            {
                ShowAlert.InfoMsg("Veuillez sélectionner une classe.");
                return;
            }
            else
            {
                if (ShowAlert.RemoveItem() != DialogResult.Yes) return;
                if (!_classeService.Delete(this._classeId))
                    ShowAlert.WarningMsg("Échec de la suppression.");
                else
                {
                    LoadClasses();
                    btnEditClasse.Visible = false; btnDeleteClasse.Visible = false;
                    this._classeId = -1;
                }
            }
        }

        private void DgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditSubject.Visible = true; btnDeleteSubject.Visible = true;
            if (e.RowIndex < 0) return; // Header clicked
            var selectedRow = dgvSubject.DataGrid.Rows[e.RowIndex];
            this._subjectId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

        }

        private void BtnEditSubject_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new AdClasseAndSubjectF(subject: this._subjectId));
        }

        private void BtnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (this._subjectId == -1)
            {
                ShowAlert.InfoMsg("Veuillez sélectionner une matière.");
                return;
            }
            else
            {
                if (ShowAlert.RemoveItem() != DialogResult.Yes) return;
                if (!_subjectService.Delete(this._subjectId))
                    ShowAlert.WarningMsg("Échec de la suppression.");
                else
                {
                    LoadSubjects();
                    btnEditSubject.Visible = false; btnDeleteSubject.Visible = false;
                    this._subjectId = -1;
                }
            }
        }
    }
}
