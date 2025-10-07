namespace DeltaSchool.Forms.Payroll
{
    partial class PayrollF
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new RenComponent.RenTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new RenComponent.RenTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new RenComponent.RenTextBox();
            this.txtLastname = new RenComponent.RenTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricule = new RenComponent.RenTextBox();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.cbPeriod = new RenComponent.RenComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResidual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbPeriod);
            this.gbSearch.Controls.Add(this.label7);
            this.gbSearch.Controls.Add(this.label4);
            this.gbSearch.Controls.Add(this.txtAddress);
            this.gbSearch.Controls.Add(this.label6);
            this.gbSearch.Controls.Add(this.txtPhone);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Controls.Add(this.txtFirstname);
            this.gbSearch.Controls.Add(this.txtLastname);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.txtMatricule);
            this.gbSearch.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(979, 223);
            this.gbSearch.TabIndex = 4;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Recherche le personnel par Matricule";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 2;
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
            this.txtAddress.Location = new System.Drawing.Point(24, 154);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAddress.MaxLength = 150;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(290, 35);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(345, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "N° Tel";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtPhone.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtPhone.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtPhone.BorderRadius = 9;
            this.txtPhone.BorderSize = 3;
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(349, 154);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPhone.MaxLength = 30;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.Size = new System.Drawing.Size(290, 35);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(665, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prénom (s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(345, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 9;
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
            this.txtFirstname.Location = new System.Drawing.Point(669, 74);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFirstname.MaxLength = 150;
            this.txtFirstname.Multiline = false;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtFirstname.PasswordChar = false;
            this.txtFirstname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFirstname.PlaceholderText = "";
            this.txtFirstname.Size = new System.Drawing.Size(290, 35);
            this.txtFirstname.TabIndex = 10;
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
            this.txtLastname.Location = new System.Drawing.Point(349, 74);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLastname.MaxLength = 120;
            this.txtLastname.Multiline = false;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtLastname.PasswordChar = false;
            this.txtLastname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastname.PlaceholderText = "";
            this.txtLastname.Size = new System.Drawing.Size(290, 35);
            this.txtLastname.TabIndex = 11;
            this.txtLastname.Texts = "";
            this.txtLastname.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matricule 📌";
            // 
            // txtMatricule
            // 
            this.txtMatricule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtMatricule.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtMatricule.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtMatricule.BorderRadius = 9;
            this.txtMatricule.BorderSize = 3;
            this.txtMatricule.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtMatricule.ForeColor = System.Drawing.Color.Black;
            this.txtMatricule.Location = new System.Drawing.Point(24, 74);
            this.txtMatricule.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMatricule.MaxLength = 50;
            this.txtMatricule.Multiline = false;
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtMatricule.PasswordChar = false;
            this.txtMatricule.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatricule.PlaceholderText = "";
            this.txtMatricule.Size = new System.Drawing.Size(290, 35);
            this.txtMatricule.TabIndex = 13;
            this.txtMatricule.Texts = "";
            this.txtMatricule.UnderlinedStyle = false;
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.AllowUserToAddRows = false;
            this.dgvPayroll.AllowUserToDeleteRows = false;
            this.dgvPayroll.AllowUserToOrderColumns = true;
            this.dgvPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPayroll.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayroll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayroll.ColumnHeadersHeight = 40;
            this.dgvPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPeriod,
            this.colStatus,
            this.colAmount,
            this.colNetPay,
            this.colResidual,
            this.colDate,
            this.colNote});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayroll.GridColor = System.Drawing.Color.Gray;
            this.dgvPayroll.Location = new System.Drawing.Point(5, 241);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.ReadOnly = true;
            this.dgvPayroll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.RowHeadersWidth = 21;
            this.dgvPayroll.RowTemplate.Height = 35;
            this.dgvPayroll.RowTemplate.ReadOnly = true;
            this.dgvPayroll.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.Size = new System.Drawing.Size(986, 388);
            this.dgvPayroll.TabIndex = 6;
            this.dgvPayroll.Visible = false;
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
            this.cbPeriod.Items.AddRange(new object[] {
            "OCTOBRE",
            "NOVEMBRE",
            "DECEMBRE",
            "JANVIER",
            "FEVRIER",
            "MARS",
            "AVRIL",
            "MAI",
            "JUIN",
            "JUILLET",
            "OAÛT",
            "SEPTEMBRE"});
            this.cbPeriod.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbPeriod.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbPeriod.Location = new System.Drawing.Point(669, 154);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Padding = new System.Windows.Forms.Padding(2);
            this.cbPeriod.SelectedValue = null;
            this.cbPeriod.Size = new System.Drawing.Size(290, 35);
            this.cbPeriod.TabIndex = 15;
            this.cbPeriod.Texts = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(665, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Période 📌";
            // 
            // colNote
            // 
            this.colNote.HeaderText = "Notes";
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            this.colNote.Width = 78;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colResidual
            // 
            this.colResidual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colResidual.HeaderText = "Réliquat";
            this.colResidual.Name = "colResidual";
            this.colResidual.ReadOnly = true;
            this.colResidual.Width = 99;
            // 
            // colNetPay
            // 
            this.colNetPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNetPay.HeaderText = "Net à payer";
            this.colNetPay.Name = "colNetPay";
            this.colNetPay.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmount.HeaderText = "Montant payé";
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
            // colPeriod
            // 
            this.colPeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPeriod.HeaderText = "Période";
            this.colPeriod.Name = "colPeriod";
            this.colPeriod.ReadOnly = true;
            // 
            // PayrollF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1010, 647);
            this.Controls.Add(this.dgvPayroll);
            this.Controls.Add(this.gbSearch);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PayrollF";
            this.Text = "Voir les paiements";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PayrollF_FormClosed);
            this.Load += new System.EventHandler(this.PayrollF_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PayrollF_KeyDown);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label label4;
        private RenComponent.RenTextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private RenComponent.RenTextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RenComponent.RenTextBox txtFirstname;
        private RenComponent.RenTextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private RenComponent.RenTextBox txtMatricule;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private RenComponent.RenComboBox cbPeriod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResidual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
    }
}