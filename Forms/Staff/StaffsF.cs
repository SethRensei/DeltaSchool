using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using DeltaSchool.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DeltaSchool.Forms.Staff
{
    public partial class StaffsF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly StaffService _service;

        private int _staffId = -1;
        private string _staffFullname = string.Empty;

        public StaffsF()
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new StaffService(_uow);
        }

        private void LoadStaffs(IEnumerable<Data.Entity.Staff> staffs)
        {
            // Charger les parents depuis la base de données
            var dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Prénom (s)");
            dt.Columns.Add("Genre");
            dt.Columns.Add("Âge");
            dt.Columns.Add("Téléphone");
            dt.Columns.Add("Adresse");
            dt.Columns.Add("Adresse e-mail");
            dt.Columns.Add("Statut Matrimonial");
            dt.Columns.Add("Nationalité");

            foreach (var staff in staffs)
                dt.Rows.Add(staff.Id, staff.Lastname,
                    staff.Firstname, staff.Gender.Equals("MALE") ? "Homme" : "Femme",
                    staff.Birthday != null ? $"{UHelpers.CalculateAge(staff.Birthday.Value)} ans" : "_",
                    staff.PhoneNumber1, staff.Address,
                    staff.Email, MaritalStatusMapper.GetLabelFromDbValue(staff.MaritalStatus),
                    staff.Nationality);

            dgvStaff.SetData(dt);
            dgvStaff.Visible = true;
        }

        private void StaffsF_Load(object sender, System.EventArgs e)
        {
            var staffs = _uow.Staffs.GetAll();
            LoadStaffs(staffs);
            dgvStaff.DataGrid.CellClick += DgvStaff_CellClick;
        }

        private void StaffsF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        private void BtnAddJob_Click(object sender, System.EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new StaffJobF(this._staffId, this._staffFullname));
        }

        private void DgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Visible = true; btnDelete.Visible = true;
            btnAddJob.Visible = true;
            if (e.RowIndex < 0) return; // Header clicked
            var selectedRow = dgvStaff.DataGrid.Rows[e.RowIndex];
            this._staffId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            this._staffFullname = $"{selectedRow.Cells["Nom"].Value} {selectedRow.Cells["Prénom (s)"].Value}";
        }
    }
}
