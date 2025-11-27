using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DeltaSchool.Forms.Exam
{
    public partial class SelectExamForAddingF : Form
    {
        private readonly IUnitOfWork _uow;

        private int s_id, c_id, sy_id, et_id;
        private string et_name;
        public SelectExamForAddingF()
        {
            InitializeComponent();

            _uow = new UnitOfWork(new DeltaSchoolContext());
        }

        private void LoadCbx()
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
            cbClasse.SelectedIndex = 0;

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
            cbSchoolYear.SelectedIndex = 0;

            // Exam Type
            var examTypes = _uow.ExamTypes.Query().ToList();
            if (examTypes == null || examTypes.Count() == 0)
            {
                ShowAlert.InfoMsg("Veuillez d'abord ajouter un type d'examen.");
                this.Close();
                return;
            }
            cbExamType.DataSource = examTypes;
            cbExamType.DisplayMember = "Name";
            cbExamType.ValueMember = "Id";
            cbExamType.SelectedIndex = 0;
        }

        private void SelectExamForAdding_FormClosed(object sender, FormClosedEventArgs e)
            => _uow.Dispose();

        private void SelectExamForAdding_Load(object sender, EventArgs e)
        {
            LoadCbx();
            btnShow.Click += (s, ev) => ShowInfo();
            btnAddNote.Click += (s, ev) =>
            {
                var addNoteForm = new AddNoteF(s_id, et_id, et_name);
                addNoteForm.ShowDialog();
            };
        }

        private void ShowInfo()
        {
            c_id = UHelpers.ConvToInt(cbClasse);
            sy_id = UHelpers.ConvToInt(cbSchoolYear);

            var students = _uow.Students.GetAll()
                .Where(s => s.ClasseId == c_id &&
                s.SchoolYearId == sy_id)
                .ToList();


            if (!students.Any())
            {
                lblInfo.Visible = true;
                dgvStudent.Visible = false;
            }
            else
            {
                lblInfo.Visible = false;
                dgvStudent.Rows.Clear();
                foreach (var st in students)
                    dgvStudent.Rows.Add(st.Id, $"{st.Lastname} {st.Firstname}",
                        st.Gender.Equals("MALE") ? "Homme" : "Femme",
                        st.Address, st.Classe?.Name,
                        st.IsOrphan ? "Oui" : "Non"
                        );

                dgvStudent.Refresh();
                dgvStudent.Visible = true;
            }
        }

        private void DgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Header clicked
            var selectedRow = dgvStudent.Rows[e.RowIndex];
            s_id = UHelpers.ConvToInt(selectedRow.Cells["ID"].Value);
            et_id = UHelpers.ConvToInt(cbExamType);
            et_name = cbExamType.Texts;
            btnAddNote.Visible = true;
        }
    }
}
