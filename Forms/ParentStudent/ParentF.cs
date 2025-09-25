using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Services;
using DeltaSchool.Utilities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DeltaSchool.Forms.ParentStudent
{
    public partial class ParentF : Form
    {

        private readonly IUnitOfWork _uow;
        private readonly ParentStudentService _parentService;
        private int _parentId;

        public ParentF()
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _parentService = new ParentStudentService(_uow);
            this._parentId = -1;
        }

        private void ParentF_Load(object sender, EventArgs e)
        {
            btnAdd.Click += (s, ev) => {
                MainForm.Instance.OpenChildForm(new AddParentF());
            };

            btnDelete.Click += (s, ev) => {
                if (this._parentId == -1)
                {
                    ShowAlert.DisplayMessage("Veuillez sélectionner un parent.", ShowAlert.A_type.Warning);
                    return;
                }
                else
                {
                    if (ShowAlert.RemoveItem() != DialogResult.Yes) return;
                    if (!_parentService.Delete(this._parentId))
                        ShowAlert.DisplayMessage("Échec de la suppression.", ShowAlert.A_type.Error);
                    else
                    {
                        LoadParents();
                        btnAddStudent.Visible = false; btnEdit.Visible = false; btnDelete.Visible = false;
                        this._parentId = -1;
                    }
                }
            };

            btnEdit.Click += (s, ev) => {
                if (this._parentId == -1)
                {
                    ShowAlert.DisplayMessage("Veuillez sélectionner un parent.", ShowAlert.A_type.Warning);
                    return;
                }
                else
                {
                    MainForm.Instance.OpenChildForm(new AddParentF(this._parentId));
                }
            };

            dgvParent.DataGrid.CellClick += DgvParent_CellClick;

            LoadParents();
        }

        private void LoadParents()
        {
            // Charger les parents depuis la base de données
            var dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Prénom (s)");
            dt.Columns.Add("Genre");
            dt.Columns.Add("Téléphone");
            dt.Columns.Add("Adresse");
            dt.Columns.Add("Adresse e-mail");
            dt.Columns.Add("Profession");
            dt.Columns.Add("Contact d'urgence");
            
            var parents = _uow.ParentStudents.GetAll();
            foreach (var p in parents)
                dt.Rows.Add(p.Id, p.Lastname, p.Firstname, p.Gender, p.PhoneNumber, p.Address, p.Email, p.Profession, p.EmerContact);

            dgvParent.SetData(dt);
            dgvParent.Visible = true;
            btnAdd.Visible = true;
        }

        #region -> Events
        private void ParentF_FormClosed(object sender, FormClosedEventArgs e)
        {
            _uow.Dispose();
        }

        private void DgvParent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddStudent.Visible = true; btnEdit.Visible = true; btnDelete.Visible = true;
            if (e.RowIndex < 0) return; // Header clicked
            var selectedRow = dgvParent.DataGrid.Rows[e.RowIndex];
            this._parentId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            
        }
        #endregion
    }
}
