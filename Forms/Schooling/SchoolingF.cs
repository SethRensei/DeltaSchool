using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using DeltaSchool.Utilities.Extensions;

namespace DeltaSchool.Forms.Finance
{
    public partial class SchoolingF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly StudentService _service;

        private Data.Entity.Student _student = null;
        public SchoolingF()
        {
            InitializeComponent();
            this.KeyPreview = true;

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new StudentService(_uow);
        }

        private void SchoolingF_Load(object sender, EventArgs e)
        {
            txtCode.KeyPress += GlobalEvent.NumberOnly;

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
            cbSchoolYear.SelectedIndex = -1;
        }
        private void SchoolingF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Search();
                e.Handled = true;
            }
        }

        private void SchoolingF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        private void CbSchoolYear_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSchoolYear.SelectedIndex != -1 && cbSchoolYear.SelectedValue != null)
            {
                if (int.TryParse(cbSchoolYear.SelectedValue.ToString(), out int schoolYearId))
                {
                    var schoolings = _uow.Schoolings.GetBySchoolYearAndStudent(schoolYearId, _student.Id);
                    FillDGV(schoolings);
                }
            }
        }

        private void Search()
        {
            if(string.IsNullOrWhiteSpace(txtCode.Texts) ||
                string.IsNullOrWhiteSpace(txtLastname.Texts) ||
                string.IsNullOrWhiteSpace(txtFirstname.Texts))
            {
                ShowAlert.WarningMsg("Veuillez renseigner les champs obligatoire");
                return;
            }
            _student = _service.FindStudentForSchooling(txtCode.Texts,
                txtLastname.Texts, txtFirstname.Texts);

            if (_student != null)
            {
                txtClasse.Texts = _student.Classe.Name;
                txtAddress.Texts = _student.Address;
                cbSchoolYear.Enabled = true;

                FillDGV(_student.Schoolings);
            }
        }

        private void FillDGV(IEnumerable<Data.Entity.Schooling> schoolings)
        {
            dgvSchooling.Rows.Clear();

            foreach (var sc in schoolings)
            {
                int row_index = dgvSchooling.Rows.Add();

                dgvSchooling.Rows[row_index].Cells["colType"].Value = TransacTypeMapper.GetLabelFromDbValue(sc.Type);
                dgvSchooling.Rows[row_index].Cells["colClasse"].Value = sc.Classe.Name;
                dgvSchooling.Rows[row_index].Cells["colSchoolYear"].Value = sc.SchoolYear.Label;
                dgvSchooling.Rows[row_index].Cells["colAmount"].Value = $"{sc.Amount} XAF";
                dgvSchooling.Rows[row_index].Cells["colStatus"].Value = TransacStatusMapper.GetLabelFromDbValue(sc.Status);
                dgvSchooling.Rows[row_index].Cells["colDate"].Value = sc.PaidAt.ToString("D");
            }
            dgvSchooling.Visible = true;
            dgvSchooling.Refresh();
        }
    }
}
