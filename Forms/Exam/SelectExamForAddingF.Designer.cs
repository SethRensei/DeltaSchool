namespace DeltaSchool.Forms.Exam
{
    partial class SelectExamForAddingF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShow = new RenComponent.RenButton();
            this.cbExamType = new RenComponent.RenComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSchoolYear = new RenComponent.RenComboBox();
            this.cbClasse = new RenComponent.RenComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAddNote = new RenComponent.RenButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.cbExamType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSchoolYear);
            this.groupBox1.Controls.Add(this.cbClasse);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Effectuez un choix";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnShow.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnShow.BorderRadius = 8;
            this.btnShow.BorderSize = 3;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(435, 104);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(140, 38);
            this.btnShow.TabIndex = 26;
            this.btnShow.Text = "Afficher";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // cbExamType
            // 
            this.cbExamType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbExamType.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbExamType.BorderSize = 2;
            this.cbExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbExamType.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbExamType.ForeColor = System.Drawing.Color.Black;
            this.cbExamType.IconColor = System.Drawing.Color.DarkCyan;
            this.cbExamType.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbExamType.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbExamType.Location = new System.Drawing.Point(709, 60);
            this.cbExamType.Name = "cbExamType";
            this.cbExamType.Padding = new System.Windows.Forms.Padding(2);
            this.cbExamType.SelectedValue = null;
            this.cbExamType.Size = new System.Drawing.Size(291, 30);
            this.cbExamType.TabIndex = 25;
            this.cbExamType.Texts = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(705, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Type d\'examen 📌";
            // 
            // cbSchoolYear
            // 
            this.cbSchoolYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbSchoolYear.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbSchoolYear.BorderSize = 2;
            this.cbSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbSchoolYear.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbSchoolYear.ForeColor = System.Drawing.Color.Black;
            this.cbSchoolYear.IconColor = System.Drawing.Color.DarkCyan;
            this.cbSchoolYear.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbSchoolYear.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbSchoolYear.Location = new System.Drawing.Point(364, 60);
            this.cbSchoolYear.Name = "cbSchoolYear";
            this.cbSchoolYear.Padding = new System.Windows.Forms.Padding(2);
            this.cbSchoolYear.SelectedValue = null;
            this.cbSchoolYear.Size = new System.Drawing.Size(291, 30);
            this.cbSchoolYear.TabIndex = 23;
            this.cbSchoolYear.Texts = "";
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
            this.cbClasse.Location = new System.Drawing.Point(14, 60);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Padding = new System.Windows.Forms.Padding(2);
            this.cbClasse.SelectedValue = null;
            this.cbClasse.Size = new System.Drawing.Size(291, 30);
            this.cbClasse.TabIndex = 22;
            this.cbClasse.Texts = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(360, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Année scolaire 📌";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(10, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 22);
            this.label13.TabIndex = 21;
            this.label13.Text = "Classe 📌";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToOrderColumns = true;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.ColumnHeadersHeight = 40;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colName,
            this.colGender,
            this.colAddress,
            this.colClasse,
            this.colOrphan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.GridColor = System.Drawing.Color.Gray;
            this.dgvStudent.Location = new System.Drawing.Point(12, 186);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidth = 21;
            this.dgvStudent.RowTemplate.Height = 35;
            this.dgvStudent.RowTemplate.ReadOnly = true;
            this.dgvStudent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.Size = new System.Drawing.Size(986, 449);
            this.dgvStudent.TabIndex = 6;
            this.dgvStudent.Visible = false;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudent_CellClick);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInfo.Location = new System.Drawing.Point(181, 156);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(654, 24);
            this.lblInfo.TabIndex = 22;
            this.lblInfo.Text = "Aucun donnée trouvée correspondant aux critères choisis";
            this.lblInfo.Visible = false;
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackColor = System.Drawing.Color.DimGray;
            this.btnAddNote.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnAddNote.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddNote.BorderRadius = 4;
            this.btnAddNote.BorderSize = 0;
            this.btnAddNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNote.FlatAppearance.BorderSize = 0;
            this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.ForeColor = System.Drawing.Color.Black;
            this.btnAddNote.Location = new System.Drawing.Point(14, 157);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(108, 27);
            this.btnAddNote.TabIndex = 23;
            this.btnAddNote.Text = "Aller noter";
            this.btnAddNote.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 15;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 51;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Nom complet";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.FillWeight = 95F;
            this.colGender.HeaderText = "Genre";
            this.colGender.MinimumWidth = 95;
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 95;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddress.HeaderText = "Adresse";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colClasse
            // 
            this.colClasse.HeaderText = "Classe";
            this.colClasse.MinimumWidth = 105;
            this.colClasse.Name = "colClasse";
            this.colClasse.ReadOnly = true;
            this.colClasse.Width = 105;
            // 
            // colOrphan
            // 
            this.colOrphan.FillWeight = 40F;
            this.colOrphan.HeaderText = "Orphelin ?";
            this.colOrphan.MinimumWidth = 40;
            this.colOrphan.Name = "colOrphan";
            this.colOrphan.ReadOnly = true;
            this.colOrphan.Width = 118;
            // 
            // SelectExamForAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1010, 647);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SelectExamForAdding";
            this.Text = "SelectExamForAdding";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectExamForAdding_FormClosed);
            this.Load += new System.EventHandler(this.SelectExamForAdding_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private RenComponent.RenComboBox cbExamType;
        private System.Windows.Forms.Label label1;
        private RenComponent.RenComboBox cbSchoolYear;
        private RenComponent.RenComboBox cbClasse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private RenComponent.RenButton btnShow;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lblInfo;
        private RenComponent.RenButton btnAddNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrphan;
    }
}