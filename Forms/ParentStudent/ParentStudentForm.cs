using System;
using System.Windows.Forms;

using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Services;
using DeltaSchool.Utilities;

namespace DeltaSchool.Forms.ParentStudent
{
    public partial class ParentStudentForm : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ParentStudentService _parentService;
        public ParentStudentForm()
        {
            InitializeComponent();

            // Ici on injecte manuellement UnitOfWork (en prod, utiliser DI container)
            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _parentService = new ParentStudentService(_uow);
        }

        #region -> Events
        private void AddPaStudentForm_Load(object sender, EventArgs e)
        {
            this.txtPhone.KeyPress += GlobalEvent.PhoneNumber;
            this.txtLastname.KeyPress += GlobalEvent.Letters;
            this.txtFirstname.KeyPress += GlobalEvent.Letters;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var gender = rbMale.Checked ? "MALE" : "FEMALE";
            var parent = new Data.Entity.ParentStudent
            {
                Firstname = txtFirstname.Texts,
                Lastname = txtLastname.Texts.Trim().ToUpper(),
                Gender = gender,
                PhoneNumber = txtPhone.Texts,
                Address = txtAddress.Texts,
                Email = string.IsNullOrWhiteSpace(txtEmail.Texts) ? null : txtEmail.Texts.Trim(),
                Profession = string.IsNullOrWhiteSpace(txtProfession.Texts) ? null : txtProfession.Texts.Trim(),
                EmerContact = string.IsNullOrWhiteSpace(txtEmContact.Texts) ? null : txtEmContact.Texts.Trim(),
            };

            if (!_parentService.Create(parent))
                ShowAlert.DisplayMessage("Échec de l'ajout du parent.", ShowAlert.A_type.Error);

        }

        private void AddPaStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        #endregion
    }
}
