using System;
using System.Linq;
using System.Windows.Forms;

using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;

namespace DeltaSchool.Forms.Expense
{
    public partial class CategoryF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ExpenseCategorieservice _service;
        private bool _isEdit = false;
        private int _categoryId;
        private ExpenseCategory _expenseCategory;

        public CategoryF()
        {
            InitializeComponent();            
            _uow = new UnitOfWork(new DeltaSchoolContext());

            _service = new ExpenseCategorieservice(_uow);
        }

        private void CategoryF_Load(object sender, EventArgs e)
        {
            FillDGV();

            // Events
            dgvCategory.CellClick += (s, ce) =>
            {
                this._categoryId = GlobalEvent.IDFromCellDGV(ce, dgvCategory);
                btnDelete.Visible = true;
            };

            btnCancel.Click += (s, ce) => ResetValue();
        }

        private void CategoryF_FormClosed(object sender, FormClosedEventArgs e)
            => _uow.Dispose();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_isEdit == false)
            {
                var category = new ExpenseCategory
                {
                    Name = UHelpers.ToTitleCase(txtName.Texts),
                    Description = txtDesc.Texts.Trim()
                };
                _service.Create(category);
                FillDGV();
                ResetValue();
            }
            else
            {
                if (_expenseCategory == null)
                {
                    ShowAlert.WarningMsg("Catégorie introuvable.");
                    return;
                }

                _expenseCategory.Name = UHelpers.ToTitleCase(txtName.Texts);
                _expenseCategory.Description = txtDesc.Texts.Trim();
                _service.Update(_expenseCategory);
                FillDGV();
                ResetValue();
            }
        }

        private void DgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this._categoryId = GlobalEvent.IDFromCellDGV(e, dgvCategory);
            this._expenseCategory = _uow.ExpenseCategories.GetById(_categoryId);
            if (this._expenseCategory == null) return;
            this._isEdit = true;
            txtName.Texts = this._expenseCategory.Name;
            txtDesc.Texts = this._expenseCategory.Description;
            btnSave.Text = "Mettre à jour";
            btnDelete.Visible = false;
            btnCancel.Visible = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this._categoryId <= 0)
            {
                ShowAlert.WarningMsg("Veuillez sélectionner une catégorie à supprimer.");
                return;
            }
            else
            {
                if (ShowAlert.RemoveItem() != DialogResult.Yes) return;
                if (_service.Delete(this._categoryId))
                {
                    FillDGV();
                    ResetValue();
                }
            }
        }

        private void FillDGV()
        {
            var categories = _uow.ExpenseCategories.Query().ToList();
            dgvCategory.Rows.Clear();
            foreach (var category in categories)
            {
                dgvCategory.Rows.Add(category.Id,
                    category.Name,
                    category.Description);
            }
            dgvCategory.Visible = true;
            dgvCategory.Refresh();
        }

        private void ResetValue()
        {
            txtName.Texts = string.Empty;
            txtDesc.Texts = string.Empty;
            btnSave.Text = "Enregistrer";
            _isEdit = false;
            _categoryId = -1;
            _expenseCategory = null;
            btnCancel.Visible = false;
            btnDelete.Visible = false;
        }
    }
}
