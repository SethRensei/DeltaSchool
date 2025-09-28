namespace DeltaSchool.Forms.Student
{
    partial class StudentsF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudent = new RenComponent.PaginatedDataGridView();
            this.btnEdit = new RenComponent.RenButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStudent.ButtonBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvStudent.ButtonBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvStudent.ButtonBorderRadius = 0;
            this.dgvStudent.ButtonBorderSize = 0;
            this.dgvStudent.ButtonFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvStudent.ButtonForeColor = System.Drawing.Color.White;
            this.dgvStudent.ButtonSize = new System.Drawing.Size(35, 35);
            // 
            // 
            // 
            this.dgvStudent.DataGrid.AllowUserToAddRows = false;
            this.dgvStudent.DataGrid.AllowUserToDeleteRows = false;
            this.dgvStudent.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudent.DataGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStudent.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStudent.DataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStudent.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.DataGrid.GridColor = System.Drawing.Color.DimGray;
            this.dgvStudent.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.DataGrid.Margin = new System.Windows.Forms.Padding(22, 11, 22, 11);
            this.dgvStudent.DataGrid.Name = "dataGridView1";
            this.dgvStudent.DataGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStudent.DataGrid.RowHeadersVisible = false;
            this.dgvStudent.DataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStudent.DataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStudent.DataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.dgvStudent.DataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvStudent.DataGrid.RowTemplate.Height = 35;
            this.dgvStudent.DataGrid.RowTemplate.ReadOnly = true;
            this.dgvStudent.DataGrid.Size = new System.Drawing.Size(932, 403);
            this.dgvStudent.DataGrid.TabIndex = 1;
            this.dgvStudent.ForeColor = System.Drawing.Color.Black;
            this.dgvStudent.Location = new System.Drawing.Point(14, 123);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(932, 472);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.Visible = false;
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
            this.btnEdit.Location = new System.Drawing.Point(862, 93);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 27);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            // 
            // StudentsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(994, 608);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvStudent);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StudentsF";
            this.Text = "Liste des élèves";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentsF_FormClosed);
            this.Load += new System.EventHandler(this.StudentsF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RenComponent.PaginatedDataGridView dgvStudent;
        private RenComponent.RenButton btnEdit;
    }
}