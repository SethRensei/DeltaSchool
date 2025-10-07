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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudent = new RenComponent.PaginatedDataGridView();
            this.btnNewTransac = new RenComponent.RenButton();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.DataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.DataGrid.GridColor = System.Drawing.Color.DimGray;
            this.dgvStudent.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.DataGrid.Margin = new System.Windows.Forms.Padding(103, 29, 103, 29);
            this.dgvStudent.DataGrid.Name = "dataGridView1";
            this.dgvStudent.DataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudent.DataGrid.RowHeadersVisible = false;
            this.dgvStudent.DataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStudent.DataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStudent.DataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.dgvStudent.DataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvStudent.DataGrid.RowTemplate.Height = 35;
            this.dgvStudent.DataGrid.RowTemplate.ReadOnly = true;
            this.dgvStudent.DataGrid.Size = new System.Drawing.Size(966, 403);
            this.dgvStudent.DataGrid.TabIndex = 1;
            this.dgvStudent.ForeColor = System.Drawing.Color.Black;
            this.dgvStudent.Location = new System.Drawing.Point(14, 123);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(966, 472);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.Visible = false;
            // 
            // btnNewTransac
            // 
            this.btnNewTransac.BackColor = System.Drawing.Color.DimGray;
            this.btnNewTransac.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnNewTransac.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewTransac.BorderRadius = 4;
            this.btnNewTransac.BorderSize = 0;
            this.btnNewTransac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTransac.FlatAppearance.BorderSize = 0;
            this.btnNewTransac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTransac.ForeColor = System.Drawing.Color.Black;
            this.btnNewTransac.Location = new System.Drawing.Point(789, 90);
            this.btnNewTransac.Name = "btnNewTransac";
            this.btnNewTransac.Size = new System.Drawing.Size(191, 26);
            this.btnNewTransac.TabIndex = 9;
            this.btnNewTransac.Text = "Nouvelle Transaction";
            this.btnNewTransac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTransac.UseVisualStyleBackColor = false;
            this.btnNewTransac.Visible = false;
            this.btnNewTransac.Click += new System.EventHandler(this.BtnNewTransac_Click);
            // 
            // StudentsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(994, 608);
            this.Controls.Add(this.btnNewTransac);
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
        private RenComponent.RenButton btnNewTransac;
    }
}