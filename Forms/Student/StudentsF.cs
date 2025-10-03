using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DeltaSchool.Forms.Student
{
    public partial class StudentsF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly StudentService _service;

        private int _studentId;

        public StudentsF()
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new StudentService(_uow);
            _studentId = -1;
        }

        private void StudentsF_Load(object sender, System.EventArgs e)
        {
            var students = _uow.Students.GetAll();
            LoadStudents(students);

            dgvStudent.DataGrid.CellDoubleClick += DGVStudent_CellDoubleClick;
        }

        private void StudentsF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        private void DGVStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this._studentId = GlobalEvent.IDFromCellDGV(e, dgvStudent.DataGrid);
            MainForm.Instance.OpenChildForm(new AdStudent(this._studentId));
        }

        #region Private Methods
        private void LoadStudents(IEnumerable<Data.Entity.Student> students)
        {
            // Charger les parents depuis la base de données
            var dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Prénom (s)");
            dt.Columns.Add("Genre");
            dt.Columns.Add("Âge");
            dt.Columns.Add("Classe");
            dt.Columns.Add("Téléphone");
            dt.Columns.Add("Adresse");
            dt.Columns.Add("Adresse e-mail");
            dt.Columns.Add("Parent/tuteur");
            dt.Columns.Add("Nationalité");
            dt.Columns.Add("Orphelin");

            foreach (var st in students)
                dt.Rows.Add(st.Id, st.Lastname,
                    st.Firstname, st.Gender.Equals("MALE") ? "Homme" : "Femme",
                    st.Birthday != null ? $"{UHelpers.CalculateAge(st.Birthday.Value)} ans" : "_",
                    st.Classe.Name,
                    st.PhoneNumber, st.Address, st.Email,
                    st.Parent != null ? $"{st.Parent.Lastname} {st.Parent.Firstname}" : "N/A",
                    st.Nationality, st.IsOrphan ? "Oui" : "Non");

            dgvStudent.SetData(dt);
            dgvStudent.Visible = true;
        }
        #endregion
    }
}
