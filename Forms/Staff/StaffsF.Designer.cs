namespace DeltaSchool.Forms.Staff
{
    partial class StaffsF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStaff = new RenComponent.PaginatedDataGridView();
            this.btnDelete = new RenComponent.RenButton();
            this.btnEdit = new RenComponent.RenButton();
            this.btnAddJob = new RenComponent.RenButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStaff.ButtonBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvStaff.ButtonBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvStaff.ButtonBorderRadius = 0;
            this.dgvStaff.ButtonBorderSize = 0;
            this.dgvStaff.ButtonFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvStaff.ButtonForeColor = System.Drawing.Color.White;
            this.dgvStaff.ButtonSize = new System.Drawing.Size(35, 35);
            // 
            // 
            // 
            this.dgvStaff.DataGrid.AllowUserToAddRows = false;
            this.dgvStaff.DataGrid.AllowUserToDeleteRows = false;
            this.dgvStaff.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStaff.DataGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStaff.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStaff.DataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStaff.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.DataGrid.GridColor = System.Drawing.Color.DimGray;
            this.dgvStaff.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvStaff.DataGrid.Margin = new System.Windows.Forms.Padding(62, 21, 62, 21);
            this.dgvStaff.DataGrid.Name = "dataGridView1";
            this.dgvStaff.DataGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStaff.DataGrid.RowHeadersVisible = false;
            this.dgvStaff.DataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStaff.DataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStaff.DataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.dgvStaff.DataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvStaff.DataGrid.RowTemplate.Height = 35;
            this.dgvStaff.DataGrid.RowTemplate.ReadOnly = true;
            this.dgvStaff.DataGrid.Size = new System.Drawing.Size(966, 403);
            this.dgvStaff.DataGrid.TabIndex = 1;
            this.dgvStaff.ForeColor = System.Drawing.Color.Black;
            this.dgvStaff.Location = new System.Drawing.Point(14, 123);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(966, 472);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.Visible = false;
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
            this.btnDelete.Location = new System.Drawing.Point(876, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
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
            this.btnEdit.Location = new System.Drawing.Point(779, 95);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 27);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.DimGray;
            this.btnAddJob.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnAddJob.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddJob.BorderRadius = 4;
            this.btnAddJob.BorderSize = 0;
            this.btnAddJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddJob.FlatAppearance.BorderSize = 0;
            this.btnAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJob.ForeColor = System.Drawing.Color.Black;
            this.btnAddJob.Location = new System.Drawing.Point(584, 95);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(187, 27);
            this.btnAddJob.TabIndex = 4;
            this.btnAddJob.Text = "Joindre une fonction";
            this.btnAddJob.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Visible = false;
            this.btnAddJob.Click += new System.EventHandler(this.BtnAddJob_Click);
            // 
            // StaffsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(994, 608);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvStaff);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StaffsF";
            this.Text = "Liste du personnel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffsF_FormClosed);
            this.Load += new System.EventHandler(this.StaffsF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RenComponent.PaginatedDataGridView dgvStaff;
        private RenComponent.RenButton btnDelete;
        private RenComponent.RenButton btnEdit;
        private RenComponent.RenButton btnAddJob;
    }
}