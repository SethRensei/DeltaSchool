namespace DeltaSchool.Forms.Finance
{
    partial class AdSchoolingF
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
            this.label9 = new System.Windows.Forms.Label();
            this.cbStatus = new RenComponent.RenComboBox();
            this.cbType = new RenComponent.RenComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAmount = new RenComponent.RenTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dpPeriod = new RenComponent.RenDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSchoolYear = new RenComponent.RenComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbClasse = new RenComponent.RenComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new RenComponent.RenButton();
            this.btnCancel = new RenComponent.RenButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cbPeriod = new RenComponent.RenComboBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(96, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(818, 38);
            this.label9.TabIndex = 0;
            this.label9.Text = "Les champs avec \"📌\" sont obligatoires";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cbStatus.Location = new System.Drawing.Point(549, 148);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(2);
            this.cbStatus.SelectedValue = null;
            this.cbStatus.Size = new System.Drawing.Size(352, 30);
            this.cbStatus.TabIndex = 4;
            this.cbStatus.Texts = "";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbType.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbType.BorderSize = 2;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbType.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbType.ForeColor = System.Drawing.Color.Black;
            this.cbType.IconColor = System.Drawing.Color.DarkCyan;
            this.cbType.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbType.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbType.Location = new System.Drawing.Point(62, 148);
            this.cbType.Name = "cbType";
            this.cbType.Padding = new System.Windows.Forms.Padding(2);
            this.cbType.SelectedValue = null;
            this.cbType.Size = new System.Drawing.Size(352, 30);
            this.cbType.TabIndex = 1;
            this.cbType.Texts = "";
            this.cbType.OnSelectedIndexChanged += new System.EventHandler(this.CbType_OnSelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(545, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Statut 📌";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(58, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Type de paiement 📌";
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
            this.txtAmount.Location = new System.Drawing.Point(62, 249);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAmount.MaxLength = 30;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtAmount.PasswordChar = false;
            this.txtAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.Size = new System.Drawing.Size(354, 35);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.Texts = "";
            this.txtAmount.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montant payé 📌";
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
            this.dpPeriod.Location = new System.Drawing.Point(66, 368);
            this.dpPeriod.MaxDate = new System.DateTime(2025, 10, 5, 0, 0, 0, 0);
            this.dpPeriod.MinDate = new System.DateTime(2025, 6, 30, 0, 0, 0, 0);
            this.dpPeriod.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpPeriod.Name = "dpPeriod";
            this.dpPeriod.Size = new System.Drawing.Size(350, 35);
            this.dpPeriod.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.dpPeriod.TabIndex = 3;
            this.dpPeriod.TextColor = System.Drawing.Color.Black;
            this.dpPeriod.Value = new System.DateTime(2025, 10, 5, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(62, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date de paiement 📌";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(545, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Année scolaire";
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
            this.cbSchoolYear.Location = new System.Drawing.Point(549, 373);
            this.cbSchoolYear.Name = "cbSchoolYear";
            this.cbSchoolYear.Padding = new System.Windows.Forms.Padding(2);
            this.cbSchoolYear.SelectedValue = null;
            this.cbSchoolYear.Size = new System.Drawing.Size(352, 30);
            this.cbSchoolYear.TabIndex = 6;
            this.cbSchoolYear.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(545, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Classe";
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
            this.cbClasse.Location = new System.Drawing.Point(549, 249);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Padding = new System.Windows.Forms.Padding(2);
            this.cbClasse.SelectedValue = null;
            this.cbClasse.Size = new System.Drawing.Size(352, 30);
            this.cbClasse.TabIndex = 5;
            this.cbClasse.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(66, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mois";
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
            this.btnSave.Location = new System.Drawing.Point(385, 573);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(231, 52);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(549, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 26);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Annuler l\'opération";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(96, 69);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(221, 22);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Nouvelle transaction :";
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
            "JUIN"});
            this.cbPeriod.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbPeriod.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbPeriod.Location = new System.Drawing.Point(70, 474);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Padding = new System.Windows.Forms.Padding(2);
            this.cbPeriod.SelectedValue = null;
            this.cbPeriod.Size = new System.Drawing.Size(352, 30);
            this.cbPeriod.TabIndex = 7;
            this.cbPeriod.Texts = "";
            // 
            // AdSchoolingF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1010, 647);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dpPeriod);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.cbSchoolYear);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdSchoolingF";
            this.Text = "Nouvel transaction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdSchoolingF_FormClosed);
            this.Load += new System.EventHandler(this.AdSchoolingF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private RenComponent.RenComboBox cbStatus;
        private RenComponent.RenComboBox cbType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private RenComponent.RenTextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private RenComponent.RenDatePicker dpPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RenComponent.RenComboBox cbSchoolYear;
        private System.Windows.Forms.Label label4;
        private RenComponent.RenComboBox cbClasse;
        private System.Windows.Forms.Label label5;
        private RenComponent.RenButton btnSave;
        private RenComponent.RenButton btnCancel;
        private System.Windows.Forms.Label lblInfo;
        private RenComponent.RenComboBox cbPeriod;
    }
}