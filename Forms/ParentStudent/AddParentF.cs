using System;
using System.Windows.Forms;

using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Services;
using DeltaSchool.Utilities;

namespace DeltaSchool.Forms.ParentStudent
{
    public partial class AddParentF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ParentStudentService _service;
        private int _parentId;
        private Data.Entity.ParentStudent parent;

        public AddParentF()
        {
            InitializeComponent();

            // Ici on injecte manuellement UnitOfWork (en prod, utiliser DI container)
            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new ParentStudentService(_uow);
            this._parentId = -1;
        }

        public AddParentF(int parentId)
        {
            InitializeComponent();

            // Ici on injecte manuellement UnitOfWork (en prod, utiliser DI container)
            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new ParentStudentService(_uow);
            this._parentId = parentId;
        }

        #region -> Events
        private void AddPaStudentForm_Load(object sender, EventArgs e)
        {
            this.txtPhone.KeyPress += GlobalEvent.PhoneNumber;
            this.txtLastname.KeyPress += GlobalEvent.Letters;
            this.txtFirstname.KeyPress += GlobalEvent.Letters;

            if (this._parentId != -1)
            {
                btnSave.Visible = false; btnSave.Enabled = false;
                btnEdit.Visible = true;
                this.parent = _uow.ParentStudents.GetById(this._parentId);
                if (this.parent == null) return;
                this.Text = "Modifier un parent";
                txtLastname.Texts = this.parent.Lastname;
                txtFirstname.Texts = this.parent.Firstname;
                txtEmail.Texts = this.parent.Email;
                txtPhone.Texts = this.parent.PhoneNumber;
                txtAddress.Texts = this.parent.Address;
                txtProfession.Texts = this.parent.Profession;
                txtEmContact.Texts = this.parent.EmerContact;
                if (this.parent.Gender.Equals("MALE")) rbMale.Checked = true;
                else rbFemale.Checked = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var parent = new Data.Entity.ParentStudent
            {
                Lastname = txtLastname.Texts.Trim().ToUpper(),
                Firstname = UHelpers.ToTitleCase(txtFirstname.Texts),
                Gender = Gender,
                PhoneNumber = txtPhone.Texts.Trim(),
                Address = txtAddress.Texts.Trim(),
                Email = UHelpers.GetValueOrtNull(txtEmail.Texts),
                Profession = UHelpers.GetValueOrtNull(txtProfession.Texts),
                EmerContact = UHelpers.GetValueOrtNull(txtEmail.Texts),
            };

            if (!_service.Create(parent))
                ShowAlert.WarningMsg("Échec de l'ajout du parent.");

        }

        private void AddPaStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        private string Gender => rbMale.Checked ? "MALE" : "FEMALE";

        #endregion

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.parent != null)
            {
                parent.Firstname = UHelpers.ToTitleCase(txtFirstname.Texts);
                parent.Lastname = txtLastname.Texts.Trim().ToUpper();
                parent.Gender = Gender;
                parent.PhoneNumber = txtPhone.Texts;
                parent.Address = txtAddress.Texts;
                parent.Email = string.IsNullOrWhiteSpace(txtEmail.Texts) ? null : txtEmail.Texts.Trim();
                parent.Profession = string.IsNullOrWhiteSpace(txtProfession.Texts) ? null : txtProfession.Texts.Trim();
                parent.EmerContact = string.IsNullOrWhiteSpace(txtEmContact.Texts) ? null : txtEmContact.Texts.Trim();

                if (_service.Update(parent))
                    MainForm.Instance.OpenChildForm(new ParentF());
            } else
                ShowAlert.WarningMsg("Aucun parent trouvé.");
        }
    }
}
