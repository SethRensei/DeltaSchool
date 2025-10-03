namespace DeltaSchool.Forms.Staff
{
    partial class JobF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJobName = new RenComponent.RenTextBox();
            this.txtDescription = new RenComponent.RenTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new RenComponent.RenButton();
            this.dgvJob = new RenComponent.PaginatedDataGridView();
            this.btnDelete = new RenComponent.RenButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new RenComponent.RenButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de fonction 📌";
            // 
            // txtJobName
            // 
            this.txtJobName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtJobName.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtJobName.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtJobName.BorderRadius = 9;
            this.txtJobName.BorderSize = 3;
            this.txtJobName.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtJobName.ForeColor = System.Drawing.Color.Black;
            this.txtJobName.Location = new System.Drawing.Point(14, 146);
            this.txtJobName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtJobName.MaxLength = 50;
            this.txtJobName.Multiline = false;
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtJobName.PasswordChar = false;
            this.txtJobName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtJobName.PlaceholderText = "Ex: Enseignant Collège";
            this.txtJobName.Size = new System.Drawing.Size(334, 35);
            this.txtJobName.TabIndex = 1;
            this.txtJobName.Texts = "";
            this.txtJobName.UnderlinedStyle = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtDescription.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtDescription.BorderRadius = 9;
            this.txtDescription.BorderSize = 3;
            this.txtDescription.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(14, 253);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtDescription.PlaceholderText = "Dites en quoi consiste la fonction si nécéssaire";
            this.txtDescription.Size = new System.Drawing.Size(334, 201);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
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
            this.btnSave.Location = new System.Drawing.Point(94, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 52);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Ajouter";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dgvJob
            // 
            this.dgvJob.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvJob.ButtonBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvJob.ButtonBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvJob.ButtonBorderRadius = 0;
            this.dgvJob.ButtonBorderSize = 0;
            this.dgvJob.ButtonFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvJob.ButtonForeColor = System.Drawing.Color.White;
            this.dgvJob.ButtonSize = new System.Drawing.Size(35, 35);
            // 
            // 
            // 
            this.dgvJob.DataGrid.AllowUserToAddRows = false;
            this.dgvJob.DataGrid.AllowUserToDeleteRows = false;
            this.dgvJob.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJob.DataGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvJob.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJob.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJob.DataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJob.DataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvJob.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJob.DataGrid.GridColor = System.Drawing.Color.DimGray;
            this.dgvJob.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvJob.DataGrid.Margin = new System.Windows.Forms.Padding(172, 40, 172, 40);
            this.dgvJob.DataGrid.Name = "dataGridView1";
            this.dgvJob.DataGrid.RowHeadersVisible = false;
            this.dgvJob.DataGrid.RowTemplate.Height = 35;
            this.dgvJob.DataGrid.Size = new System.Drawing.Size(613, 470);
            this.dgvJob.DataGrid.TabIndex = 1;
            this.dgvJob.Location = new System.Drawing.Point(383, 70);
            this.dgvJob.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvJob.Name = "dgvJob";
            this.dgvJob.PageSize = 15;
            this.dgvJob.Size = new System.Drawing.Size(613, 539);
            this.dgvJob.TabIndex = 18;
            this.dgvJob.Visible = false;
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
            this.btnDelete.Location = new System.Drawing.Point(892, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 27);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(23, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ce champ est requis";
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
            this.btnCancel.Location = new System.Drawing.Point(383, 43);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 27);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Annuler l\'opération";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // JobF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1010, 647);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvJob);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtJobName);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "JobF";
            this.Text = "Gestionnaire de Poste";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JobF_FormClosed);
            this.Load += new System.EventHandler(this.JobF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RenComponent.RenTextBox txtJobName;
        private RenComponent.RenTextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private RenComponent.RenButton btnSave;
        private RenComponent.PaginatedDataGridView dgvJob;
        private RenComponent.RenButton btnDelete;
        private System.Windows.Forms.Label label3;
        private RenComponent.RenButton btnCancel;
    }
}