using System;
using System.Linq;
using System.Windows.Forms;

using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Forms.Student
{
    public partial class AdStudent : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly StudentService _service;

        private readonly Data.Entity.Student _student;
        private readonly int _parentId = -1, _studentId = -1;
        private readonly string _parentFullname = string.Empty;
        private readonly bool _isEdit = false;

        public AdStudent()
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new StudentService(_uow);
        }

        public AdStudent(int studentId)
        {
            InitializeComponent();
            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);
            _service = new StudentService(_uow);
            _studentId = studentId;
            this._isEdit = true;
            this.Text = "Modification d'infos élève";
            btnSave.Text = "Mettre à jour";
            this._student = GetStudent();
            if (this._student == null)
            {
                ShowAlert.WarningMsg("Échec de chargement des infos. Veuillez réessayer.");
                this.Close();
                return;
            }
            else
            {
                // Load student info
                txtLastname.Texts = this._student.Lastname;
                txtFirstname.Texts = this._student.Firstname;
                chkOrphan.Checked = this._student.IsOrphan;
                if (this._student.Gender.Equals("MALE")) rbMale.Checked = true;
                else rbFemale.Checked = true;
                txtAddress.Texts = this._student.Address;
                txtPhone.Texts = this._student.PhoneNumber;
                txtBirthplace.Texts = this._student.Birthplace;
                txtNationality.Texts = this._student.Nationality;
                txtEmail.Texts = this._student.Email;
                txtHomeInsti.Texts = this._student.HomeInstitution;
                txtObs.Texts = this._student.Observations;
            }
        }

        public AdStudent(int parentId, string parentFullname)
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new StudentService(_uow);
            _parentId = parentId;
            _parentFullname = parentFullname;
        }

        private void AdStudentF_Load(object sender, EventArgs e)
        {
            dpBirthday.MaxDate = DateTime.Today; dpBirthday.Value = dpBirthday.MaxDate;
            
            this.txtLastname.KeyPress += GlobalEvent.Letters;
            this.txtFirstname.KeyPress += GlobalEvent.Letters;
            this.txtPhone.KeyPress += GlobalEvent.PhoneNumber;

            AllLoadCbx();
            if(_parentId != -1)
            {
                cbParent.Enabled = false;
                cbParent.Visible = false;
                lblParent.Visible = false;

                chkOrphan.Enabled = false;
                chkOrphan.Checked = false;
                chkOrphan.Visible = false;

                lblOrphan.Text = $"Enfant : {this._parentFullname}\n\nCliquez pour retourner\nà la Liste des parents";
                lblOrphan.Cursor = Cursors.Hand;
                lblOrphan.Click += (s, ev) => MainForm.Instance.OpenChildForm(new ParentStudent.ParentF());
            }

            if (this._student != null)
                if (this._student.Birthday != null)
                    dpBirthday.Value = this._student.Birthday.Value;
        }

        private string Gender => rbMale.Checked ? "MALE" : "FEMALE";

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this._isEdit == false)
            {
                var student = new Data.Entity.Student
                {
                    Lastname = txtLastname.Texts.Trim().ToUpper(),
                    Firstname = UHelpers.ToTitleCase(txtFirstname.Texts),
                    Gender = Gender,
                    Address = txtAddress.Texts.Trim(),
                    PhoneNumber = UHelpers.GetValueOrtNull(txtPhone.Texts),
                    Birthplace = UHelpers.GetValueOrtNull(txtBirthplace.Texts),
                    Nationality = UHelpers.GetValueOrtNull(txtNationality.Texts),
                    Email = UHelpers.GetValueOrtNull(txtEmail.Texts.ToLower()),
                    HomeInstitution = UHelpers.GetValueOrtNull(txtHomeInsti.Texts),
                    ClasseId = Convert.ToInt32(cbClasse.SelectedValue.ToString()),
                    SchoolYearId = Convert.ToInt32(cbSchoolYear.SelectedValue.ToString()),
                    LocationId = Convert.ToInt32(cbLocation.SelectedValue.ToString()),
                    IsOrphan = chkOrphan.Checked,
                    Observations = UHelpers.GetValueOrtNull(txtObs.Texts),
                };

                if (dpBirthday.Value != dpBirthday.MaxDate)
                    student.Birthday = dpBirthday.Value;

                if (_parentId != -1)
                    student.ParentId = _parentId;

                if (cbParent.SelectedIndex == -1) student.ParentId = null;
                else student.ParentId = Convert.ToInt32(cbParent.SelectedValue.ToString());

                if (!_service.Create(student))
                    ShowAlert.WarningMsg("Échec de l'ajout du personnel.");
                else
                {
                    if (ShowAlert.Question("Voulez-vous effectuer une nouvelle inscription ?") == DialogResult.No)
                        MainForm.Instance.OpenChildForm(new StudentsF());
                    else
                        ResetValue();
                }
            }
            else
            {
                this._student.Lastname = txtLastname.Texts.Trim().ToUpper();
                this._student.Firstname = UHelpers.ToTitleCase(txtFirstname.Texts);
                this._student.Gender = Gender;
                this._student.Address = txtAddress.Texts.Trim();
                this._student.PhoneNumber = UHelpers.GetValueOrtNull(txtPhone.Texts);
                this._student.Birthplace = UHelpers.GetValueOrtNull(txtBirthplace.Texts);
                this._student.Nationality = UHelpers.GetValueOrtNull(txtNationality.Texts);
                this._student.Email = UHelpers.GetValueOrtNull(txtEmail.Texts.ToLower());
                this._student.HomeInstitution = UHelpers.GetValueOrtNull(txtHomeInsti.Texts);
                this._student.ClasseId = Convert.ToInt32(cbClasse.SelectedValue.ToString());
                this._student.SchoolYearId = Convert.ToInt32(cbSchoolYear.SelectedValue.ToString());
                this._student.LocationId = Convert.ToInt32(cbLocation.SelectedValue.ToString());
                this._student.IsOrphan = chkOrphan.Checked;
                this._student.Observations = UHelpers.GetValueOrtNull(txtObs.Texts);                

                if (dpBirthday.Value != dpBirthday.MaxDate)
                    this._student.Birthday = dpBirthday.Value;

                if (cbParent.SelectedIndex == -1) this._student.ParentId = null;
                else this._student.ParentId = Convert.ToInt32(cbParent.SelectedValue.ToString());

                if (_service.Update(this._student))
                    MainForm.Instance.OpenChildForm(new StudentsF());
                else
                    ShowAlert.ErrorMsg("Échec de la mise à jour des infos.");
            }
        }

        private void AdStudentF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        private void ChkOrphan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrphan.Checked)
            {
                cbParent.Enabled = false;
                cbParent.Visible = false;
                lblParent.Visible = false;
                cbParent.SelectedIndex = -1;
            }
            else
            {
                cbParent.Enabled = true;
                cbParent.Visible = true;
                lblParent.Visible = true;
            }
        }

        #region -> Private Methods
        private void AllLoadCbx()
        {
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
            if (this._isEdit && this._student != null)
                cbClasse.SelectedValue = this._student.ClasseId;
            else
                cbClasse.SelectedIndex = 0; // Current classe

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
            if (this._isEdit && this._student != null)
                cbSchoolYear.SelectedValue = this._student.SchoolYearId;
            else
                cbSchoolYear.SelectedIndex = 0; // Current year

            // Location
            var locations = _uow.Locations.GetAll()
                .Select(l => new { l.Id, Locate = $"{l.Name} -> {l.Code}"})
                .ToList();

            if (locations == null || locations.Count() == 0)
            {
                ShowAlert.InfoMsg("Veuillez d'abord ajouter un site.");
                this.Close();
                return;
            }
            cbLocation.DataSource = locations;
            cbLocation.ValueMember = "Id";
            cbLocation.DisplayMember = "Locate";
            if (this._isEdit && this._student != null)
                cbLocation.SelectedValue = this._student.LocationId;
            else
                cbLocation.SelectedIndex = 0; // Current location


            // Parent
            var parents = _uow.ParentStudents.GetAll()
                .OrderBy(p => p.Lastname)
                .Select(p => new { p.Id, FullName = $"{p.Lastname} {p.Firstname}" })
                .ToList();

            cbParent.DataSource = parents;
            cbParent.ValueMember = "Id";
            cbParent.DisplayMember = "Fullname";
            if (this._isEdit && this._student != null && this._student.Parent != null)
                cbParent.SelectedValue = this._student.ParentId;
            else
                cbParent.SelectedIndex = -1; // Set null
        }

        private Data.Entity.Student GetStudent()
        {
            if (this._studentId == -1) return null;
            return _uow.Students.GetById(this._studentId);
        }

        private void ResetValue()
        {
            AllLoadCbx();
            txtLastname.Texts = string.Empty;
            txtFirstname.Texts = string.Empty;
            rbMale.Checked = true;
            txtAddress.Texts = string.Empty;
            txtPhone.Texts = string.Empty;
            chkOrphan.Checked = false;
            dpBirthday.Value = dpBirthday.MaxDate;
            txtBirthplace.Texts = string.Empty;
            txtNationality.Texts = string.Empty;
            txtEmail.Texts = string.Empty;
            txtHomeInsti.Texts = string.Empty;
            txtObs.Texts = string.Empty;
        }
        #endregion
    }
}
