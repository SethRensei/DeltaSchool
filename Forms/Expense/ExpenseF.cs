using DeltaSchool.Core.Services;
using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using DeltaSchool.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DeltaSchool.Forms.Expense
{
    public partial class ExpenseF : Form
    {
        private readonly IUnitOfWork _uow;
        private readonly ExpenseService _service;
        private bool _isEdit = false;
        private int _expenseId;
        private Data.Entity.Expense _expense;

        public ExpenseF()
        {
            InitializeComponent();
            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);

            _service = new ExpenseService(_uow);
        }

        private void ExpenseF_Load(object sender, EventArgs e)
        {
            txtAmount.KeyPress += GlobalEvent.NumberOnly;

            dpIncurredAt.MaxDate = DateTime.Today;
            dpIncurredAt.Value = dpIncurredAt.MaxDate;

            cbCategory.Items.Clear();
            var categories = _uow.ExpenseCategories.Query()
                .Select(ec => new { ec.Id, ec.Name })
                .ToList();
            cbCategory.DataSource = categories;
            cbCategory.ValueMember = "Id";
            cbCategory.DisplayMember = "Name";
            cbCategory.SelectedIndex = 0;

            btnCancel.Click += (s, v) => ResetValue();

            FillDGV();
        }

        private void ExpenseF_FormClosed(object sender, FormClosedEventArgs e)
            => _uow.Dispose();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_isEdit == false)
            {
                if (cbCategory.SelectedIndex == -1)
                {
                    ShowAlert.WarningMsg("Le choix d'une catégorie est obligatoire");
                    return;
                }
                var expense = new Data.Entity.Expense
                {
                    CategoryId = Convert.ToInt32(cbCategory.SelectedValue.ToString()),
                    Amount = UHelpers.ConvertAmount(txtAmount.Texts),
                    IncurredAt = dpIncurredAt.Value,
                    Description = txtDesc.Texts.Trim()
                };

                _service.Create(expense);
                FillDGV();
                ResetValue();
            }
            else
            {
                if (_expense == null)
                {
                    ShowAlert.WarningMsg("Aucune dépense interne trouvée");
                    return;
                }

                _expense.CategoryId = Convert.ToInt32(cbCategory.SelectedValue.ToString());
                _expense.Amount = UHelpers.ConvertAmount(txtAmount.Texts);
                _expense.IncurredAt = dpIncurredAt.Value;
                _expense.Description = txtDesc.Texts.Trim();
                _service.Update(_expense);
                FillDGV();
                ResetValue();
            }
        }

        private void FillDGV()
        {
            var expenses = _service.GetAll();

            dgvExpense.Rows.Clear();
            foreach (var exp in expenses)
                dgvExpense.Rows.Add(exp.Id,
                    exp.ExpenseCategory != null ? exp.ExpenseCategory.Name : "N/A",
                    $"{exp.Amount} FCFA", exp.IncurredAt.ToString("D"), exp.Description);

            dgvExpense.Refresh();
            dgvExpense.Visible = true;
        }

        private void ResetValue()
        {
            cbCategory.SelectedIndex = 0;
            txtAmount.Texts = string.Empty;
            txtDesc.Texts = string.Empty;
            dpIncurredAt.MaxDate = DateTime.Today;
            dpIncurredAt.Value = dpIncurredAt.MaxDate;
            _isEdit = false;
            _expense = null;
            btnSave.Text = "Enregistrer";
            btnCancel.Visible = false;
        }

        private void DgvExpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _expenseId = GlobalEvent.IDFromCellDGV(e, dgvExpense);
            _expense = _uow.Expenses.GetById(_expenseId);
            if (_expense == null) return;
            _isEdit = true;
            if (_expense.CategoryId != null)
                cbCategory.SelectedValue = _expense.CategoryId;
            else cbCategory.SelectedIndex = -1;
            txtAmount.Texts = _expense.Amount.ToString();
            dpIncurredAt.Value = _expense.IncurredAt;
            txtDesc.Texts = _expense.Description;
            btnSave.Text = "Mettre à jour";
            btnCancel.Visible = true;
        }
    }
}
