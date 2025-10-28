namespace DeltaSchool.Forms.Expense
{
    partial class ExpenseF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new RenComponent.RenButton();
            this.txtDesc = new RenComponent.RenTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmount = new RenComponent.RenTextBox();
            this.dpIncurredAt = new RenComponent.RenDatePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCategory = new RenComponent.RenComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIncurred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new RenComponent.RenButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description 📌";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderRadius = 8;
            this.btnSave.BorderSize = 3;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(64, 551);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(223, 52);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtDesc.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtDesc.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtDesc.BorderRadius = 9;
            this.txtDesc.BorderSize = 3;
            this.txtDesc.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.Location = new System.Drawing.Point(14, 407);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDesc.MaxLength = 490;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtDesc.PasswordChar = false;
            this.txtDesc.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtDesc.PlaceholderText = "ex : Les manuels, le papier, les marqueurs, etc.";
            this.txtDesc.Size = new System.Drawing.Size(345, 123);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.Texts = "";
            this.txtDesc.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Montant 📌";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtAmount.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtAmount.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtAmount.BorderRadius = 9;
            this.txtAmount.BorderSize = 3;
            this.txtAmount.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.Location = new System.Drawing.Point(14, 219);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAmount.MaxLength = 30;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtAmount.PasswordChar = false;
            this.txtAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.Size = new System.Drawing.Size(343, 35);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.Texts = "";
            this.txtAmount.UnderlinedStyle = false;
            // 
            // dpIncurredAt
            // 
            this.dpIncurredAt.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.dpIncurredAt.BorderSize = 3;
            this.dpIncurredAt.CalendarForeColor = System.Drawing.Color.Black;
            this.dpIncurredAt.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.dpIncurredAt.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.dpIncurredAt.CalendarTitleForeColor = System.Drawing.Color.LightCyan;
            this.dpIncurredAt.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dpIncurredAt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dpIncurredAt.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.dpIncurredAt.Location = new System.Drawing.Point(14, 309);
            this.dpIncurredAt.MaxDate = new System.DateTime(2025, 10, 5, 0, 0, 0, 0);
            this.dpIncurredAt.MinDate = new System.DateTime(2025, 6, 30, 0, 0, 0, 0);
            this.dpIncurredAt.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpIncurredAt.Name = "dpIncurredAt";
            this.dpIncurredAt.Size = new System.Drawing.Size(343, 35);
            this.dpIncurredAt.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.dpIncurredAt.TabIndex = 3;
            this.dpIncurredAt.TextColor = System.Drawing.Color.Black;
            this.dpIncurredAt.Value = new System.DateTime(2025, 10, 5, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date de paiement 📌";
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbCategory.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbCategory.BorderSize = 2;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbCategory.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCategory.IconColor = System.Drawing.Color.DarkCyan;
            this.cbCategory.Items.AddRange(new object[] {
            "OCTOBRE",
            "NOVEMBRE",
            "DECEMBRE",
            "JANVIER",
            "FEVRIER",
            "MARS",
            "AVRIL",
            "MAI",
            "JUIN",
            "JUILLET",
            "OAÛT",
            "SEPTEMBRE"});
            this.cbCategory.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbCategory.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbCategory.Location = new System.Drawing.Point(12, 136);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Padding = new System.Windows.Forms.Padding(2);
            this.cbCategory.SelectedValue = null;
            this.cbCategory.Size = new System.Drawing.Size(345, 35);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.Texts = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Catégorie 📌";
            // 
            // dgvExpense
            // 
            this.dgvExpense.AllowUserToAddRows = false;
            this.dgvExpense.AllowUserToDeleteRows = false;
            this.dgvExpense.AllowUserToOrderColumns = true;
            this.dgvExpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExpense.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpense.ColumnHeadersHeight = 40;
            this.dgvExpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colCategory,
            this.colAmount,
            this.colIncurred,
            this.colDesc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpense.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpense.GridColor = System.Drawing.Color.Gray;
            this.dgvExpense.Location = new System.Drawing.Point(382, 136);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.ReadOnly = true;
            this.dgvExpense.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpense.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpense.RowHeadersVisible = false;
            this.dgvExpense.RowHeadersWidth = 21;
            this.dgvExpense.RowTemplate.Height = 35;
            this.dgvExpense.RowTemplate.ReadOnly = true;
            this.dgvExpense.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpense.Size = new System.Drawing.Size(616, 506);
            this.dgvExpense.TabIndex = 6;
            this.dgvExpense.Visible = false;
            this.dgvExpense.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExpense_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 15;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 51;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Catégorie";
            this.colCategory.MinimumWidth = 180;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 180;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Montant dépensé";
            this.colAmount.MinimumWidth = 120;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 173;
            // 
            // colIncurred
            // 
            this.colIncurred.HeaderText = "Date";
            this.colIncurred.MinimumWidth = 50;
            this.colIncurred.Name = "colIncurred";
            this.colIncurred.ReadOnly = true;
            this.colIncurred.Width = 69;
            // 
            // colDesc
            // 
            this.colDesc.HeaderText = "Description";
            this.colDesc.MinimumWidth = 350;
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            this.colDesc.Width = 350;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 4;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(823, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annuler l\'opération";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            // 
            // ExpenseF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1010, 647);
            this.Controls.Add(this.dgvExpense);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dpIncurredAt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDesc);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ExpenseF";
            this.Text = "Nos Dépenses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExpenseF_FormClosed);
            this.Load += new System.EventHandler(this.ExpenseF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private RenComponent.RenButton btnSave;
        private RenComponent.RenTextBox txtDesc;
        private System.Windows.Forms.Label label8;
        private RenComponent.RenTextBox txtAmount;
        private RenComponent.RenDatePicker dpIncurredAt;
        private System.Windows.Forms.Label label10;
        private RenComponent.RenComboBox cbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvExpense;
        private RenComponent.RenButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIncurred;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
    }
}