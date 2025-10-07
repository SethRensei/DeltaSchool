namespace DeltaSchool.Forms.Finance
{
    partial class SchoolingF
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new RenComponent.RenTextBox();
            this.txtLastname = new RenComponent.RenTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClasse = new RenComponent.RenTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new RenComponent.RenTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSchoolYear = new RenComponent.RenComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvSchooling = new System.Windows.Forms.DataGridView();
            this.txtCode = new RenComponent.RenTextBox();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchooling)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prénom (s) 📌";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom 📌";
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtFirstname.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtFirstname.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtFirstname.BorderRadius = 9;
            this.txtFirstname.BorderSize = 3;
            this.txtFirstname.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtFirstname.ForeColor = System.Drawing.Color.Black;
            this.txtFirstname.Location = new System.Drawing.Point(158, 178);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFirstname.MaxLength = 150;
            this.txtFirstname.Multiline = false;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtFirstname.PasswordChar = false;
            this.txtFirstname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFirstname.PlaceholderText = "";
            this.txtFirstname.Size = new System.Drawing.Size(293, 35);
            this.txtFirstname.TabIndex = 3;
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
            this.txtLastname.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtLastname.ForeColor = System.Drawing.Color.Black;
            this.txtLastname.Location = new System.Drawing.Point(158, 102);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLastname.MaxLength = 120;
            this.txtLastname.Multiline = false;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtLastname.PasswordChar = false;
            this.txtLastname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastname.PlaceholderText = "";
            this.txtLastname.Size = new System.Drawing.Size(293, 35);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.Texts = "";
            this.txtLastname.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code 📌";
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
            this.txtClasse.Location = new System.Drawing.Point(684, 28);
            this.txtClasse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtClasse.MaxLength = 150;
            this.txtClasse.Multiline = false;
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtClasse.PasswordChar = false;
            this.txtClasse.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtClasse.PlaceholderText = "";
            this.txtClasse.Size = new System.Drawing.Size(293, 35);
            this.txtClasse.TabIndex = 7;
            this.txtClasse.Texts = "";
            this.txtClasse.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(605, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Classe";
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
            this.txtAddress.Location = new System.Drawing.Point(684, 102);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAddress.MaxLength = 150;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(293, 35);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(590, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adresse";
            // 
            // cbSchoolYear
            // 
            this.cbSchoolYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbSchoolYear.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbSchoolYear.BorderSize = 2;
            this.cbSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbSchoolYear.Enabled = false;
            this.cbSchoolYear.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbSchoolYear.ForeColor = System.Drawing.Color.Black;
            this.cbSchoolYear.IconColor = System.Drawing.Color.DarkCyan;
            this.cbSchoolYear.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbSchoolYear.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbSchoolYear.Location = new System.Drawing.Point(686, 178);
            this.cbSchoolYear.Name = "cbSchoolYear";
            this.cbSchoolYear.Padding = new System.Windows.Forms.Padding(2);
            this.cbSchoolYear.SelectedValue = null;
            this.cbSchoolYear.Size = new System.Drawing.Size(291, 35);
            this.cbSchoolYear.TabIndex = 4;
            this.cbSchoolYear.Texts = "";
            this.cbSchoolYear.OnSelectedIndexChanged += new System.EventHandler(this.CbSchoolYear_OnSelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(573, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Fitrer par";
            // 
            // dgvSchooling
            // 
            this.dgvSchooling.AllowUserToAddRows = false;
            this.dgvSchooling.AllowUserToDeleteRows = false;
            this.dgvSchooling.AllowUserToOrderColumns = true;
            this.dgvSchooling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSchooling.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvSchooling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchooling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchooling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchooling.ColumnHeadersHeight = 40;
            this.dgvSchooling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colClasse,
            this.colSchoolYear,
            this.colAmount,
            this.colStatus,
            this.colDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchooling.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSchooling.GridColor = System.Drawing.Color.Gray;
            this.dgvSchooling.Location = new System.Drawing.Point(12, 247);
            this.dgvSchooling.Name = "dgvSchooling";
            this.dgvSchooling.ReadOnly = true;
            this.dgvSchooling.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchooling.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSchooling.RowHeadersVisible = false;
            this.dgvSchooling.RowHeadersWidth = 21;
            this.dgvSchooling.RowTemplate.Height = 35;
            this.dgvSchooling.RowTemplate.ReadOnly = true;
            this.dgvSchooling.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchooling.Size = new System.Drawing.Size(986, 388);
            this.dgvSchooling.TabIndex = 5;
            this.dgvSchooling.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtCode.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtCode.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtCode.BorderRadius = 9;
            this.txtCode.BorderSize = 3;
            this.txtCode.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(158, 28);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCode.MaxLength = 5;
            this.txtCode.Multiline = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtCode.PasswordChar = false;
            this.txtCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCode.PlaceholderText = "";
            this.txtCode.Size = new System.Drawing.Size(293, 35);
            this.txtCode.TabIndex = 1;
            this.txtCode.Texts = "";
            this.txtCode.UnderlinedStyle = false;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 74;
            // 
            // colClasse
            // 
            this.colClasse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colClasse.HeaderText = "Classe";
            this.colClasse.Name = "colClasse";
            this.colClasse.ReadOnly = true;
            this.colClasse.Width = 83;
            // 
            // colSchoolYear
            // 
            this.colSchoolYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSchoolYear.HeaderText = "Année Scolaire";
            this.colSchoolYear.Name = "colSchoolYear";
            this.colSchoolYear.ReadOnly = true;
            this.colSchoolYear.Width = 152;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmount.HeaderText = "Montant reçu";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStatus.HeaderText = "Statut";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 80;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // SchoolingF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1010, 647);
            this.Controls.Add(this.dgvSchooling);
            this.Controls.Add(this.cbSchoolYear);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtLastname);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SchoolingF";
            this.Text = "SchoolingF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SchoolingF_FormClosed);
            this.Load += new System.EventHandler(this.SchoolingF_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SchoolingF_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchooling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RenComponent.RenTextBox txtFirstname;
        private RenComponent.RenTextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private RenComponent.RenTextBox txtClasse;
        private System.Windows.Forms.Label label4;
        private RenComponent.RenTextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private RenComponent.RenComboBox cbSchoolYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvSchooling;
        private RenComponent.RenTextBox txtCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    }
}