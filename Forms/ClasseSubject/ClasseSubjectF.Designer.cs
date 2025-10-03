namespace DeltaSchool.Forms.ClasseSubject
{
    partial class ClasseSubjectF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbStaff = new RenComponent.RenComboBox();
            this.cbClasse = new RenComponent.RenComboBox();
            this.cbSubject = new RenComponent.RenComboBox();
            this.txtCoeff = new RenComponent.RenTextBox();
            this.btnSave = new RenComponent.RenButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvClasseSubject = new RenComponent.PaginatedDataGridView();
            this.btnDelete = new RenComponent.RenButton();
            this.btnCancel = new RenComponent.RenButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasseSubject.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStaff
            // 
            this.cbStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbStaff.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbStaff.BorderSize = 2;
            this.cbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbStaff.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbStaff.ForeColor = System.Drawing.Color.Black;
            this.cbStaff.IconColor = System.Drawing.Color.DarkCyan;
            this.cbStaff.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbStaff.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbStaff.Location = new System.Drawing.Point(12, 395);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Padding = new System.Windows.Forms.Padding(2);
            this.cbStaff.SelectedValue = null;
            this.cbStaff.Size = new System.Drawing.Size(262, 30);
            this.cbStaff.TabIndex = 8;
            this.cbStaff.Texts = "";
            // 
            // cbClasse
            // 
            this.cbClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbClasse.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbClasse.BorderSize = 2;
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbClasse.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbClasse.ForeColor = System.Drawing.Color.Black;
            this.cbClasse.IconColor = System.Drawing.Color.DarkCyan;
            this.cbClasse.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbClasse.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbClasse.Location = new System.Drawing.Point(12, 131);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Padding = new System.Windows.Forms.Padding(2);
            this.cbClasse.SelectedValue = null;
            this.cbClasse.Size = new System.Drawing.Size(262, 30);
            this.cbClasse.TabIndex = 8;
            this.cbClasse.Texts = "";
            // 
            // cbSubject
            // 
            this.cbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbSubject.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbSubject.BorderSize = 2;
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbSubject.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbSubject.ForeColor = System.Drawing.Color.Black;
            this.cbSubject.IconColor = System.Drawing.Color.DarkCyan;
            this.cbSubject.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbSubject.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbSubject.Location = new System.Drawing.Point(12, 220);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Padding = new System.Windows.Forms.Padding(2);
            this.cbSubject.SelectedValue = null;
            this.cbSubject.Size = new System.Drawing.Size(262, 30);
            this.cbSubject.TabIndex = 8;
            this.cbSubject.Texts = "";
            // 
            // txtCoeff
            // 
            this.txtCoeff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtCoeff.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtCoeff.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtCoeff.BorderRadius = 9;
            this.txtCoeff.BorderSize = 3;
            this.txtCoeff.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtCoeff.ForeColor = System.Drawing.Color.Black;
            this.txtCoeff.Location = new System.Drawing.Point(12, 307);
            this.txtCoeff.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCoeff.MaxLength = 120;
            this.txtCoeff.Multiline = false;
            this.txtCoeff.Name = "txtCoeff";
            this.txtCoeff.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtCoeff.PasswordChar = false;
            this.txtCoeff.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCoeff.PlaceholderText = "";
            this.txtCoeff.Size = new System.Drawing.Size(262, 35);
            this.txtCoeff.TabIndex = 9;
            this.txtCoeff.Texts = "";
            this.txtCoeff.UnderlinedStyle = false;
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
            this.btnSave.Location = new System.Drawing.Point(52, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Classe 📌";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Matière 📌";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Coefficient 📌";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enseignant";
            // 
            // dgvClasseSubject
            // 
            this.dgvClasseSubject.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvClasseSubject.ButtonBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvClasseSubject.ButtonBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvClasseSubject.ButtonBorderRadius = 0;
            this.dgvClasseSubject.ButtonBorderSize = 0;
            this.dgvClasseSubject.ButtonFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvClasseSubject.ButtonForeColor = System.Drawing.Color.LightCyan;
            this.dgvClasseSubject.ButtonSize = new System.Drawing.Size(35, 35);
            // 
            // 
            // 
            this.dgvClasseSubject.DataGrid.AllowUserToAddRows = false;
            this.dgvClasseSubject.DataGrid.AllowUserToDeleteRows = false;
            this.dgvClasseSubject.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasseSubject.DataGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvClasseSubject.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClasseSubject.DataGrid.ColumnHeadersHeight = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasseSubject.DataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClasseSubject.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClasseSubject.DataGrid.GridColor = System.Drawing.Color.Gray;
            this.dgvClasseSubject.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvClasseSubject.DataGrid.Margin = new System.Windows.Forms.Padding(172, 40, 172, 40);
            this.dgvClasseSubject.DataGrid.Name = "dataGridView1";
            this.dgvClasseSubject.DataGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasseSubject.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClasseSubject.DataGrid.RowHeadersVisible = false;
            this.dgvClasseSubject.DataGrid.RowTemplate.Height = 35;
            this.dgvClasseSubject.DataGrid.RowTemplate.ReadOnly = true;
            this.dgvClasseSubject.DataGrid.Size = new System.Drawing.Size(604, 406);
            this.dgvClasseSubject.DataGrid.TabIndex = 1;
            this.dgvClasseSubject.Location = new System.Drawing.Point(376, 120);
            this.dgvClasseSubject.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvClasseSubject.Name = "dgvClasseSubject";
            this.dgvClasseSubject.Size = new System.Drawing.Size(604, 475);
            this.dgvClasseSubject.TabIndex = 15;
            this.dgvClasseSubject.Visible = false;
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
            this.btnDelete.Location = new System.Drawing.Point(876, 93);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 27);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(374, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 27);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Annuler l\'opération";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ClasseSubjectF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(994, 608);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvClasseSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCoeff);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.cbStaff);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ClasseSubjectF";
            this.Text = "Assignation Matière - Classe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClasseSubjectF_FormClosed);
            this.Load += new System.EventHandler(this.ClasseSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasseSubject.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenComponent.RenComboBox cbStaff;
        private RenComponent.RenComboBox cbClasse;
        private RenComponent.RenComboBox cbSubject;
        private RenComponent.RenTextBox txtCoeff;
        private RenComponent.RenButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RenComponent.PaginatedDataGridView dgvClasseSubject;
        private RenComponent.RenButton btnDelete;
        private RenComponent.RenButton btnCancel;
    }
}