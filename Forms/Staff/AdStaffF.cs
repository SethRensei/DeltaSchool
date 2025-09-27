using System;
using System.Linq;
using System.Windows.Forms;

using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using DeltaSchool.Utilities.Extensions;

namespace DeltaSchool.Forms.Staff
{
    public partial class AdStaffF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly StaffService _service;

        public AdStaffF()
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new StaffService(_uow);
        }

        private void AdStaffF_Load(object sender, EventArgs e)
        {
            dpBirthday.MaxDate = DateTime.Today; dpBirthday.Value = dpBirthday.MaxDate;
            dpHireDate.MaxDate = DateTime.Today; dpHireDate.Value = dpHireDate.MinDate;
            
            this.txtLastname.KeyPress += GlobalEvent.Letters;
            this.txtFirstname.KeyPress += GlobalEvent.Letters;
            this.txtEmCtcName.KeyPress += GlobalEvent.Letters;
            this.txtPhone1.KeyPress += GlobalEvent.PhoneNumber;
            this.txtPhone2.KeyPress += GlobalEvent.PhoneNumber;
            this.txtEmCtcPhone.KeyPress += GlobalEvent.PhoneNumber;

            cbMaritalStatus.DataSource = Enum.GetValues(typeof(MaritalStatus))
                .Cast<MaritalStatus>()
                .Select(m => new MaritalStatusItem { Value = m, Label = m.GetLabel() })
                .ToList();

            cbMaritalStatus.DisplayMember = "Label";
            cbMaritalStatus.ValueMember = "Value";

            //ShowAlert.DisplayMessage(dpBirthday.Value.ToString("yyyy-MM-dd"), ShowAlert.A_type.Info);
        }

        private string Gender => rbMale.Checked ? "MALE" : "FEMALE";

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var staff = new Data.Entity.Staff
            {
                Lastname = txtLastname.Texts.Trim().ToUpper(),
                Firstname = UHelpers.ToTitleCase(txtFirstname.Texts),
                Gender = Gender,
                Address = txtAddress.Texts.Trim(),
                PhoneNumber1 = txtPhone1.Texts.Trim(),
                MaritalStatus = cbMaritalStatus.SelectedValue.ToString(),
                PhoneNumber2 = UHelpers.GetValueOrtNull(txtPhone2.Texts),
                Email = UHelpers.GetValueOrtNull(txtEmail.Texts),
                Birthplace = UHelpers.GetValueOrtNull(txtBirthplace.Texts),
                Nationality = UHelpers.GetValueOrtNull(txtNationality.Texts),
                EmergencyContact = UHelpers.GetValueOrtNull(txtEmCtcName.Texts),
                EmergencyPhone = UHelpers.GetValueOrtNull(txtEmCtcPhone.Texts),
            };

            if (dpBirthday.Value != dpBirthday.MaxDate)
                staff.Birthday = dpBirthday.Value;
            if(dpHireDate.Value != dpHireDate.MinDate)
                staff.HireDate = dpHireDate.Value;

            if (!_service.Create(staff))
                ShowAlert.WarningMsg("Échec de l'ajout du personnel.");
        }

        private void AdStaffF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }
    }
}
