using System.Windows.Forms;

namespace DeltaSchool.Forms.Exam
{
    partial class AddNoteF
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtSchoolYear = new RenComponent.RenTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGender = new RenComponent.RenTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new RenComponent.RenTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClasse = new RenComponent.RenTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new RenComponent.RenTextBox();
            this.txtLastname = new RenComponent.RenTextBox();
            this.pnlTitleBar = new RenComponent.RenPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new RenComponent.RenButton();
            this.dgvNote = new System.Windows.Forms.DataGridView();
            this.colSubjct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoeff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHomework = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSchoolYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtClasse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Controls.Add(this.txtLastname);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(0, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Personnelles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(702, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Année Scolaire";
            // 
            // txtSchoolYear
            // 
            this.txtSchoolYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtSchoolYear.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtSchoolYear.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtSchoolYear.BorderRadius = 9;
            this.txtSchoolYear.BorderSize = 3;
            this.txtSchoolYear.Enabled = false;
            this.txtSchoolYear.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtSchoolYear.ForeColor = System.Drawing.Color.Black;
            this.txtSchoolYear.Location = new System.Drawing.Point(706, 121);
            this.txtSchoolYear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSchoolYear.MaxLength = 150;
            this.txtSchoolYear.Multiline = false;
            this.txtSchoolYear.Name = "txtSchoolYear";
            this.txtSchoolYear.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtSchoolYear.PasswordChar = false;
            this.txtSchoolYear.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSchoolYear.PlaceholderText = "";
            this.txtSchoolYear.Size = new System.Drawing.Size(290, 35);
            this.txtSchoolYear.TabIndex = 23;
            this.txtSchoolYear.Texts = "";
            this.txtSchoolYear.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(702, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Genre";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtGender.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtGender.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtGender.BorderRadius = 9;
            this.txtGender.BorderSize = 3;
            this.txtGender.Enabled = false;
            this.txtGender.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtGender.ForeColor = System.Drawing.Color.Black;
            this.txtGender.Location = new System.Drawing.Point(706, 50);
            this.txtGender.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGender.MaxLength = 150;
            this.txtGender.Multiline = false;
            this.txtGender.Name = "txtGender";
            this.txtGender.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtGender.PasswordChar = false;
            this.txtGender.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGender.PlaceholderText = "";
            this.txtGender.Size = new System.Drawing.Size(290, 35);
            this.txtGender.TabIndex = 21;
            this.txtGender.Texts = "";
            this.txtGender.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adresse";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtAddress.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtAddress.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtAddress.BorderRadius = 9;
            this.txtAddress.BorderSize = 3;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(31, 121);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAddress.MaxLength = 150;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(290, 35);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(371, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Classe";
            // 
            // txtClasse
            // 
            this.txtClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtClasse.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtClasse.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtClasse.BorderRadius = 9;
            this.txtClasse.BorderSize = 3;
            this.txtClasse.Enabled = false;
            this.txtClasse.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtClasse.ForeColor = System.Drawing.Color.Black;
            this.txtClasse.Location = new System.Drawing.Point(375, 121);
            this.txtClasse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtClasse.MaxLength = 30;
            this.txtClasse.Multiline = false;
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtClasse.PasswordChar = false;
            this.txtClasse.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtClasse.PlaceholderText = "";
            this.txtClasse.Size = new System.Drawing.Size(290, 35);
            this.txtClasse.TabIndex = 15;
            this.txtClasse.Texts = "";
            this.txtClasse.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(371, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prénom (s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nom";
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtFirstname.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtFirstname.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtFirstname.BorderRadius = 9;
            this.txtFirstname.BorderSize = 3;
            this.txtFirstname.Enabled = false;
            this.txtFirstname.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtFirstname.ForeColor = System.Drawing.Color.Black;
            this.txtFirstname.Location = new System.Drawing.Point(375, 50);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFirstname.MaxLength = 150;
            this.txtFirstname.Multiline = false;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtFirstname.PasswordChar = false;
            this.txtFirstname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFirstname.PlaceholderText = "";
            this.txtFirstname.Size = new System.Drawing.Size(290, 35);
            this.txtFirstname.TabIndex = 18;
            this.txtFirstname.Texts = "";
            this.txtFirstname.UnderlinedStyle = false;
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtLastname.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtLastname.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtLastname.BorderRadius = 9;
            this.txtLastname.BorderSize = 3;
            this.txtLastname.Enabled = false;
            this.txtLastname.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtLastname.ForeColor = System.Drawing.Color.Black;
            this.txtLastname.Location = new System.Drawing.Point(31, 50);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLastname.MaxLength = 120;
            this.txtLastname.Multiline = false;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtLastname.PasswordChar = false;
            this.txtLastname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastname.PlaceholderText = "";
            this.txtLastname.Size = new System.Drawing.Size(290, 35);
            this.txtLastname.TabIndex = 19;
            this.txtLastname.Texts = "";
            this.txtLastname.UnderlinedStyle = false;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitleBar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlTitleBar.BorderRadius = 0;
            this.pnlTitleBar.BorderSize = 0;
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.ForeColor = System.Drawing.Color.White;
            this.pnlTitleBar.GradientAngle = 95F;
            this.pnlTitleBar.GradientBottomColor = System.Drawing.Color.DarkSlateGray;
            this.pnlTitleBar.GradientTopColor = System.Drawing.Color.MidnightBlue;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1010, 36);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LightCyan;
            this.lblTitle.Location = new System.Drawing.Point(28, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Enregistrer la note";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DeltaSchool.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(964, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgvNote
            // 
            this.dgvNote.AllowUserToAddRows = false;
            this.dgvNote.AllowUserToDeleteRows = false;
            this.dgvNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNote.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNote.ColumnHeadersHeight = 40;
            this.dgvNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubjct,
            this.colCoeff,
            this.colHomework,
            this.colDuty,
            this.colComp});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNote.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNote.Location = new System.Drawing.Point(31, 210);
            this.dgvNote.Name = "dgvNote";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNote.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNote.RowHeadersVisible = false;
            this.dgvNote.RowHeadersWidth = 21;
            this.dgvNote.RowTemplate.Height = 35;
            this.dgvNote.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNote.Size = new System.Drawing.Size(745, 425);
            this.dgvNote.TabIndex = 2;
            this.dgvNote.Visible = false;
            this.dgvNote.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvNote_EditingControlShowing);
            // 
            // colSubjct
            // 
            this.colSubjct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubjct.HeaderText = "Matière";
            this.colSubjct.Name = "colSubjct";
            this.colSubjct.ReadOnly = true;
            // 
            // colCoeff
            // 
            this.colCoeff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCoeff.HeaderText = "Coeff";
            this.colCoeff.MaxInputLength = 3;
            this.colCoeff.MinimumWidth = 50;
            this.colCoeff.Name = "colCoeff";
            this.colCoeff.ReadOnly = true;
            this.colCoeff.Width = 77;
            // 
            // colHomework
            // 
            this.colHomework.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHomework.HeaderText = "Devoir 1";
            this.colHomework.MaxInputLength = 5;
            this.colHomework.MinimumWidth = 120;
            this.colHomework.Name = "colHomework";
            this.colHomework.Width = 120;
            // 
            // colDuty
            // 
            this.colDuty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDuty.HeaderText = "Devoir Dep";
            this.colDuty.MaxInputLength = 5;
            this.colDuty.MinimumWidth = 120;
            this.colDuty.Name = "colDuty";
            this.colDuty.Width = 120;
            // 
            // colComp
            // 
            this.colComp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colComp.HeaderText = "Composition";
            this.colComp.MaxInputLength = 5;
            this.colComp.MinimumWidth = 120;
            this.colComp.Name = "colComp";
            this.colComp.Width = 120;
            // 
            // AddNoteF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1010, 647);
            this.Controls.Add(this.dgvNote);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddNoteF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addNote";
            this.Load += new System.EventHandler(this.AddNote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private RenComponent.RenTextBox txtSchoolYear;
        private System.Windows.Forms.Label label3;
        private RenComponent.RenTextBox txtGender;
        private System.Windows.Forms.Label label4;
        private RenComponent.RenTextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private RenComponent.RenTextBox txtClasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RenComponent.RenTextBox txtFirstname;
        private RenComponent.RenTextBox txtLastname;
        private RenComponent.RenPanel pnlTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private RenComponent.RenButton btnClose;
        private System.Windows.Forms.DataGridView dgvNote;
        private DataGridViewTextBoxColumn colSubjct;
        private DataGridViewTextBoxColumn colCoeff;
        private DataGridViewTextBoxColumn colHomework;
        private DataGridViewTextBoxColumn colDuty;
        private DataGridViewTextBoxColumn colComp;
    }
}