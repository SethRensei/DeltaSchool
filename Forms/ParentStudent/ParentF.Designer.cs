namespace DeltaSchool.Forms.ParentStudent
{
    partial class ParentF
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
            this.btnAdd = new RenComponent.RenButton();
            this.dgvParent = new RenComponent.PaginatedDataGridView();
            this.btnEdit = new RenComponent.RenButton();
            this.btnDelete = new RenComponent.RenButton();
            this.btnAddStudent = new RenComponent.RenButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParent.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 4;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(830, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ajouter un parent";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            // 
            // dgvParent
            // 
            this.dgvParent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvParent.ButtonBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvParent.ButtonBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvParent.ButtonBorderRadius = 0;
            this.dgvParent.ButtonBorderSize = 0;
            this.dgvParent.ButtonFont = new System.Drawing.Font("Lucida Fax", 12F);
            this.dgvParent.ButtonForeColor = System.Drawing.Color.LightCyan;
            this.dgvParent.ButtonSize = new System.Drawing.Size(35, 35);
            // 
            // 
            // 
            this.dgvParent.DataGrid.AllowUserToAddRows = false;
            this.dgvParent.DataGrid.AllowUserToDeleteRows = false;
            this.dgvParent.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParent.DataGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvParent.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParent.DataGrid.ColumnHeadersHeight = 39;
            this.dgvParent.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParent.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvParent.DataGrid.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.dgvParent.DataGrid.Name = "dataGridView1";
            this.dgvParent.DataGrid.ReadOnly = true;
            this.dgvParent.DataGrid.RowHeadersVisible = false;
            this.dgvParent.DataGrid.RowTemplate.Height = 35;
            this.dgvParent.DataGrid.Size = new System.Drawing.Size(979, 417);
            this.dgvParent.DataGrid.TabIndex = 1;
            this.dgvParent.Location = new System.Drawing.Point(14, 148);
            this.dgvParent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvParent.Name = "dgvParent";
            this.dgvParent.Size = new System.Drawing.Size(979, 486);
            this.dgvParent.TabIndex = 2;
            this.dgvParent.Visible = false;
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
            this.btnEdit.Location = new System.Drawing.Point(661, 114);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 27);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Modifier le parent";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
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
            this.btnDelete.Location = new System.Drawing.Point(476, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 27);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Supprimer le parent";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.DimGray;
            this.btnAddStudent.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnAddStudent.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddStudent.BorderRadius = 4;
            this.btnAddStudent.BorderSize = 0;
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.Location = new System.Drawing.Point(309, 114);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(161, 27);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Ajouter un enfant";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Visible = false;
            // 
            // ParentF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1058, 647);
            this.Controls.Add(this.dgvParent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ParentF";
            this.Text = "Parents D\'élèves";
            this.Load += new System.EventHandler(this.ParentF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParent.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RenComponent.RenButton btnAdd;
        private RenComponent.PaginatedDataGridView dgvParent;
        private RenComponent.RenButton btnEdit;
        private RenComponent.RenButton btnDelete;
        private RenComponent.RenButton btnAddStudent;
    }
}