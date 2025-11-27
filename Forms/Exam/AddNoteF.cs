using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Forms.Exam
{
    public partial class AddNoteF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly NoteService service;
        private DeltaSchool.Data.Entity.Student student;
        private readonly int student_id, exam_id;

        public AddNoteF()
            => InitializeComponent();

        public AddNoteF(int student, int exam_id, string term)
        {
            InitializeComponent();
            this.student_id = student;
            this.exam_id = exam_id;
            this.lblTitle.Text += $" : {term}";
            this.student = null;

            _uow = new UnitOfWork(new DeltaSchoolContext());
            service = new NoteService(_uow);

            // Load Info Student
            FillInfoStudent();
            FillDgv();
        }

        private void AddNote_Load(object sender, System.EventArgs e)
        {
            btnClose.Click += (s, c) => this.Close();
            this.FormClosed += (s, c) => _uow.Dispose();
            
        }

        private void FillInfoStudent()
        {
            student = _uow.Students.GetAll()
                .Where(s => s.Id == this.student_id)
                .Include(s => s.Classe)
                .Include(s => s.SchoolYear)
                .AsNoTracking()
                .FirstOrDefault();
            txtLastname.Texts = student.Lastname;
            txtFirstname.Texts = student.Firstname;
            txtGender.Texts = student.Gender == "MALE" ? "Masculin": "Féminin";
            txtAddress.Texts = student.Address;
            txtClasse.Texts = student.Classe?.Name;
            txtSchoolYear.Texts = student.SchoolYear?.Label;
        }

        private void DgvNote_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvNote.CurrentCell.ColumnIndex == dgvNote.Columns["colHomework"].Index ||
                dgvNote.CurrentCell.ColumnIndex == dgvNote.Columns["colComp"].Index || 
                dgvNote.CurrentCell.ColumnIndex == dgvNote.Columns["colDuty"].Index)
            {
                TextBox tb = e.Control as TextBox;

                if (tb != null)
                {
                    // On retire d’abord l’ancien event pour éviter les doubles événements
                    tb.KeyPress -= GlobalEvent.DecimalOnly;
                    tb.KeyPress += GlobalEvent.DecimalOnly;
                }
            }
        }

        private void FillDgv()
        {
            if (student == null) return;

            var subjects = _uow.ClasseSubjects.GetAll()
                .Where(s => s.ClasseId == student.ClasseId).ToList();

            dgvNote.Rows.Clear();
            foreach (var s in subjects)
                dgvNote.Rows.Add(s.Subject.Name, s.Coeff);

            dgvNote.Refresh();
            dgvNote.Visible = true;
        }
    }
}
