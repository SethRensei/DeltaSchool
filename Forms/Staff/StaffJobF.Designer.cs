namespace DeltaSchool.Forms.Staff
{
    partial class StaffJobF
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
            this.cbJob = new RenComponent.RenComboBox();
            this.btnSave = new RenComponent.RenButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary = new RenComponent.RenTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPeriod = new RenComponent.RenComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStaffJob = new RenComponent.PaginatedDataGridView();
            this.btnDelete = new RenComponent.RenButton();
            this.btnEdit = new RenComponent.RenButton();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffJob.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cbJob
            // 
            this.cbJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbJob.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbJob.BorderSize = 2;
            this.cbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbJob.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbJob.ForeColor = System.Drawing.Color.Black;
            this.cbJob.IconColor = System.Drawing.Color.DarkCyan;
            this.cbJob.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbJob.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbJob.Location = new System.Drawing.Point(12, 222);
            this.cbJob.Name = "cbJob";
            this.cbJob.Padding = new System.Windows.Forms.Padding(2);
            this.cbJob.SelectedValue = null;
            this.cbJob.Size = new System.Drawing.Size(291, 30);
            this.cbJob.TabIndex = 1;
            this.cbJob.Texts = "";
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
            this.btnSave.Location = new System.Drawing.Point(63, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 52);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fonction / Poste 📌";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtSalary.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtSalary.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtSalary.BorderRadius = 9;
            this.txtSalary.BorderSize = 3;
            this.txtSalary.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtSalary.ForeColor = System.Drawing.Color.Black;
            this.txtSalary.Location = new System.Drawing.Point(12, 309);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSalary.MaxLength = 30;
            this.txtSalary.Multiline = false;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtSalary.PasswordChar = false;
            this.txtSalary.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSalary.PlaceholderText = "";
            this.txtSalary.Size = new System.Drawing.Size(291, 35);
            this.txtSalary.TabIndex = 2;
            this.txtSalary.Texts = "";
            this.txtSalary.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Périodicité 📌";
            // 
            // cbPeriod
            // 
            this.cbPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbPeriod.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbPeriod.BorderSize = 2;
            this.cbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPeriod.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbPeriod.ForeColor = System.Drawing.Color.Black;
            this.cbPeriod.IconColor = System.Drawing.Color.DarkCyan;
            this.cbPeriod.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbPeriod.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbPeriod.Location = new System.Drawing.Point(12, 418);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Padding = new System.Windows.Forms.Padding(2);
            this.cbPeriod.SelectedValue = null;
            this.cbPeriod.Size = new System.Drawing.Size(291, 30);
            this.cbPeriod.TabIndex = 3;
            this.cbPeriod.Texts = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salaire 📌";
            // 
            // dgvStaffJob
            // 
            this.dgvStaffJob.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStaffJob.ButtonBackColor = System.Drawing.Color.Transparent;
            this.dgvStaffJob.ButtonBorderColor = System.Drawing.Color.LightCyan;
            this.dgvStaffJob.ButtonBorderRadius = 4;
            this.dgvStaffJob.ButtonBorderSize = 2;
            this.dgvStaffJob.ButtonFont = new System.Drawing.Font("Lucida Fax", 11F);
            this.dgvStaffJob.ButtonForeColor = System.Drawing.Color.Black;
            this.dgvStaffJob.ButtonSize = new System.Drawing.Size(35, 35);
            // 
            // 
            // 
            this.dgvStaffJob.DataGrid.AllowUserToAddRows = false;
            this.dgvStaffJob.DataGrid.AllowUserToDeleteRows = false;
            this.dgvStaffJob.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStaffJob.DataGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStaffJob.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaffJob.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffJob.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaffJob.DataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffJob.DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaffJob.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaffJob.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvStaffJob.DataGrid.Margin = new System.Windows.Forms.Padding(37, 15, 37, 15);
            this.dgvStaffJob.DataGrid.Name = "dataGridView1";
            this.dgvStaffJob.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffJob.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaffJob.DataGrid.RowHeadersVisible = false;
            this.dgvStaffJob.DataGrid.RowTemplate.Height = 25;
            this.dgvStaffJob.DataGrid.Size = new System.Drawing.Size(647, 391);
            this.dgvStaffJob.DataGrid.TabIndex = 1;
            this.dgvStaffJob.Location = new System.Drawing.Point(333, 135);
            this.dgvStaffJob.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvStaffJob.Name = "dgvStaffJob";
            this.dgvStaffJob.PageSize = 20;
            this.dgvStaffJob.Size = new System.Drawing.Size(647, 460);
            this.dgvStaffJob.TabIndex = 5;
            this.dgvStaffJob.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(876, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 4;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(783, 104);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 27);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("Lucida Fax", 18F);
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(83, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(818, 45);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Text";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffJobF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(994, 608);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvStaffJob);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalary);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StaffJobF";
            this.Text = "Joindre une fonction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffJobF_FormClosed);
            this.Load += new System.EventHandler(this.StaffJobF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffJob.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenComponent.RenComboBox cbJob;
        private RenComponent.RenButton btnSave;
        private System.Windows.Forms.Label label1;
        private RenComponent.RenTextBox txtSalary;
        private System.Windows.Forms.Label label3;
        private RenComponent.RenComboBox cbPeriod;
        private System.Windows.Forms.Label label2;
        private RenComponent.PaginatedDataGridView dgvStaffJob;
        private RenComponent.RenButton btnDelete;
        private RenComponent.RenButton btnEdit;
        private System.Windows.Forms.Label lblInfo;
    }
}