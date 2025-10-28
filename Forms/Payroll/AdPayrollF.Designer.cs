namespace DeltaSchool.Forms.Payroll
{
    partial class AdPayrollF
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
            this.gbAdPay = new System.Windows.Forms.GroupBox();
            this.btnSave = new RenComponent.RenButton();
            this.dpPeriod = new RenComponent.RenDatePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPeriod = new RenComponent.RenComboBox();
            this.cbStatus = new RenComponent.RenComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNotes = new RenComponent.RenTextBox();
            this.txtAmount = new RenComponent.RenTextBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new RenComponent.RenTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNetPay = new RenComponent.RenTextBox();
            this.txtPhone = new RenComponent.RenTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new RenComponent.RenTextBox();
            this.txtLastname = new RenComponent.RenTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricule = new RenComponent.RenTextBox();
            this.gbAdPay.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdPay
            // 
            this.gbAdPay.Controls.Add(this.btnSave);
            this.gbAdPay.Controls.Add(this.dpPeriod);
            this.gbAdPay.Controls.Add(this.label10);
            this.gbAdPay.Controls.Add(this.cbPeriod);
            this.gbAdPay.Controls.Add(this.cbStatus);
            this.gbAdPay.Controls.Add(this.label7);
            this.gbAdPay.Controls.Add(this.label11);
            this.gbAdPay.Controls.Add(this.label8);
            this.gbAdPay.Controls.Add(this.label9);
            this.gbAdPay.Controls.Add(this.txtNotes);
            this.gbAdPay.Controls.Add(this.txtAmount);
            this.gbAdPay.Font = new System.Drawing.Font("Lucida Fax", 16.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdPay.Location = new System.Drawing.Point(19, 258);
            this.gbAdPay.Name = "gbAdPay";
            this.gbAdPay.Size = new System.Drawing.Size(979, 352);
            this.gbAdPay.TabIndex = 2;
            this.gbAdPay.TabStop = false;
            this.gbAdPay.Text = "Enregistrement du paiement";
            this.gbAdPay.Visible = false;
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
            this.btnSave.Location = new System.Drawing.Point(340, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(223, 52);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dpPeriod
            // 
            this.dpPeriod.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.dpPeriod.BorderSize = 3;
            this.dpPeriod.CalendarForeColor = System.Drawing.Color.Black;
            this.dpPeriod.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.dpPeriod.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.dpPeriod.CalendarTitleForeColor = System.Drawing.Color.LightCyan;
            this.dpPeriod.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dpPeriod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dpPeriod.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.dpPeriod.Location = new System.Drawing.Point(13, 174);
            this.dpPeriod.MaxDate = new System.DateTime(2025, 10, 5, 0, 0, 0, 0);
            this.dpPeriod.MinDate = new System.DateTime(2025, 6, 30, 0, 0, 0, 0);
            this.dpPeriod.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpPeriod.Name = "dpPeriod";
            this.dpPeriod.Size = new System.Drawing.Size(280, 35);
            this.dpPeriod.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.dpPeriod.TabIndex = 5;
            this.dpPeriod.TextColor = System.Drawing.Color.Black;
            this.dpPeriod.Value = new System.DateTime(2025, 10, 5, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date de paiement 📌";
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
            this.cbPeriod.Location = new System.Drawing.Point(319, 86);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Padding = new System.Windows.Forms.Padding(2);
            this.cbPeriod.SelectedValue = null;
            this.cbPeriod.Size = new System.Drawing.Size(221, 35);
            this.cbPeriod.TabIndex = 4;
            this.cbPeriod.Texts = "";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbStatus.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbStatus.BorderSize = 2;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbStatus.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbStatus.IconColor = System.Drawing.Color.DarkCyan;
            this.cbStatus.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbStatus.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbStatus.Location = new System.Drawing.Point(319, 174);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(2);
            this.cbStatus.SelectedValue = null;
            this.cbStatus.Size = new System.Drawing.Size(221, 35);
            this.cbStatus.TabIndex = 6;
            this.cbStatus.Texts = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(315, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mois 📌";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(567, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Notes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Montant payé 📌";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(315, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Statut 📌";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtNotes.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtNotes.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtNotes.BorderRadius = 9;
            this.txtNotes.BorderSize = 3;
            this.txtNotes.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtNotes.ForeColor = System.Drawing.Color.Black;
            this.txtNotes.Location = new System.Drawing.Point(571, 86);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNotes.MaxLength = 30;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtNotes.PasswordChar = false;
            this.txtNotes.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtNotes.PlaceholderText = "Commentaires ou remarques";
            this.txtNotes.Size = new System.Drawing.Size(388, 123);
            this.txtNotes.TabIndex = 7;
            this.txtNotes.Texts = "";
            this.txtNotes.UnderlinedStyle = false;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtAmount.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtAmount.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtAmount.BorderRadius = 9;
            this.txtAmount.BorderSize = 3;
            this.txtAmount.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.Location = new System.Drawing.Point(8, 86);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAmount.MaxLength = 30;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtAmount.PasswordChar = false;
            this.txtAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.Size = new System.Drawing.Size(285, 35);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Texts = "";
            this.txtAmount.UnderlinedStyle = false;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.label4);
            this.gbSearch.Controls.Add(this.txtAddress);
            this.gbSearch.Controls.Add(this.label5);
            this.gbSearch.Controls.Add(this.label6);
            this.gbSearch.Controls.Add(this.txtNetPay);
            this.gbSearch.Controls.Add(this.txtPhone);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Controls.Add(this.txtFirstname);
            this.gbSearch.Controls.Add(this.txtLastname);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.txtMatricule);
            this.gbSearch.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(19, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(979, 223);
            this.gbSearch.TabIndex = 3;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(665, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Net à payer";
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
            // txtNetPay
            // 
            this.txtNetPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtNetPay.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtNetPay.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtNetPay.BorderRadius = 9;
            this.txtNetPay.BorderSize = 3;
            this.txtNetPay.Enabled = false;
            this.txtNetPay.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtNetPay.ForeColor = System.Drawing.Color.Black;
            this.txtNetPay.Location = new System.Drawing.Point(669, 154);
            this.txtNetPay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNetPay.MaxLength = 30;
            this.txtNetPay.Multiline = false;
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtNetPay.PasswordChar = false;
            this.txtNetPay.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNetPay.PlaceholderText = "";
            this.txtNetPay.Size = new System.Drawing.Size(290, 35);
            this.txtNetPay.TabIndex = 6;
            this.txtNetPay.Texts = "";
            this.txtNetPay.UnderlinedStyle = false;
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
            // AdPayrollF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1010, 647);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbAdPay);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdPayrollF";
            this.Text = "Nouveau paiement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdPayrollF_FormClosed);
            this.Load += new System.EventHandler(this.AdPayrollF_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdPayrollF_KeyDown);
            this.gbAdPay.ResumeLayout(false);
            this.gbAdPay.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAdPay;
        private RenComponent.RenDatePicker dpPeriod;
        private System.Windows.Forms.Label label10;
        private RenComponent.RenComboBox cbPeriod;
        private RenComponent.RenComboBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private RenComponent.RenTextBox txtNotes;
        private RenComponent.RenTextBox txtAmount;
        private RenComponent.RenButton btnSave;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label label4;
        private RenComponent.RenTextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private RenComponent.RenTextBox txtNetPay;
        private RenComponent.RenTextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RenComponent.RenTextBox txtFirstname;
        private RenComponent.RenTextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private RenComponent.RenTextBox txtMatricule;
    }
}