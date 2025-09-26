using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using DeltaSchool.Utilities.Extensions;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DeltaSchool.Forms.ClasseSubject
{
    public partial class AdClasseAndSubjectF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ClasseService _classeService;
        private readonly SubjectService _subjectService;
        private Classe _classe;
        private Subject _subject;

        private int _classeId = -1, _subjectId = -1;


        public AdClasseAndSubjectF()
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _classeService = new ClasseService(_uow);
            _subjectService = new SubjectService(_uow);
        }

        public AdClasseAndSubjectF(int classe = -1, int subject = -1)
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _classeService = new ClasseService(_uow);
            _subjectService = new SubjectService(_uow);

            this._classeId = classe;
            this._subjectId = subject;

            this._classe = GetClasse();
            this._subject = GetSubject();
        }

        private void AdClasseAndSubjectF_Load(object sender, EventArgs e)
        {
            cbxCycle.DataSource = Enum.GetValues(typeof(Cycle))
            .Cast<Cycle>()
            .Select(c => new CycleItem { Value = c, Label = c.GetLabel() })
            .ToList();
            cbxCycle.DisplayMember = "Label";
            cbxCycle.ValueMember = "Value";
        }

        private void BtnAddClasse_Click(object sender, EventArgs e)
        {
            if (this._classeId == -1)
            {
                var classe = new Data.Entity.Classe
                {
                    Name = txtClasse.Texts.Trim(),
                    Cycle = cbxCycle.SelectedValue.ToString(),
                    Category = rbPass.Checked ? "PASS" : "EXAM"
                };
                if (_classeService.Create(classe))
                {
                    OpenClasseAndSubjectF();
                    txtClasse.Texts = string.Empty;
                    cbxCycle.SelectedIndex = 0;
                    rbPass.Checked = true;
                }
            } else
            {
                if (this._classe != null)
                {
                    this._classe.Name = txtClasse.Texts.Trim();
                    this._classe.Cycle = cbxCycle.SelectedValue.ToString();
                    this._classe.Category = rbPass.Checked ? "PASS" : "EXAM";

                    if (_classeService.Update(this._classe))
                    {
                        MainForm.Instance.OpenChildForm(new ClasseAndSubjectF());
                        this.Close();
                    }
                    else
                        ShowAlert.DisplayMessage("Échec de la mise à jour.", ShowAlert.A_type.Error);
                }
                else
                    ShowAlert.DisplayMessage("Aucune classe trouvée.", ShowAlert.A_type.Error);
            }
        }

        private void BtnAddSubject_Click(object sender, EventArgs e)
        {
            if (this._subjectId == -1)
            {
                var subject = new Data.Entity.Subject
                {
                    Name = txtSubject.Texts.Trim()
                };
                if (_subjectService.Create(subject))
                {
                    OpenClasseAndSubjectF();
                    txtSubject.Texts = string.Empty;
                }
            }
            else
            {   if (this._subject != null)
                {
                    this._subject.Name = txtSubject.Texts.Trim();
                    if (_subjectService.Update(this._subject))
                    {
                        MainForm.Instance.OpenChildForm(new ClasseAndSubjectF());
                        this.Close();
                    }
                    else
                        ShowAlert.DisplayMessage("Échec de la mise à jour.", ShowAlert.A_type.Error);
                }
                else
                    ShowAlert.DisplayMessage("Aucune matière trouvée.", ShowAlert.A_type.Error);
            }
        }

        private void OpenClasseAndSubjectF()
        {
            var result = ShowAlert.Question("Voulez-vous allez voir la liste ?");
            if (result == DialogResult.Yes)
            {
                MainForm.Instance.OpenChildForm(new ClasseAndSubjectF());
            }
        }

        private void AdClasseAndSubjectF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        private Classe GetClasse()
        {
            var classe = _uow.Classes.GetById(this._classeId);
            if (classe == null) return null;
            this.Text = "Modification d'information";
            lblClasse.Text = "Modifier les informations de la classe";
            btnAddSubject.Enabled = false;
            txtSubject.Enabled = false;
            btnAddClasse.Text = "Mettre à jour";
            txtClasse.Texts = classe.Name;
            if (classe.Category.Equals("PASS")) rbPass.Checked = true;
            else rbExam.Checked = false;
            cbxCycle.SelectedItem = classe.Cycle;
            return classe;
        }

        private Subject GetSubject()
        {
            var subject = _uow.Subjects.GetById(this._subjectId);
            if (subject == null) return null;
            this.Text = "Modification d'information";
            lblSubject.Text = "Modifier la matière";
            btnAddClasse.Enabled = false;
            txtClasse.Enabled = false;
            btnAddSubject.Text = "Mettre à jour";
            txtSubject.Texts = subject.Name;
            return subject;
        }
    }

}
