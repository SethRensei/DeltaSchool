namespace DeltaSchool.Forms.Student
{
    partial class AdStudent
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
            this.btnSave = new RenComponent.RenButton();
            this.rbFemale = new RenComponent.RenRadioButton();
            this.rbMale = new RenComponent.RenRadioButton();
            this.lblOrphan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new RenComponent.RenTextBox();
            this.txtPhone = new RenComponent.RenTextBox();
            this.txtBirthplace = new RenComponent.RenTextBox();
            this.txtEmail = new RenComponent.RenTextBox();
            this.txtFirstname = new RenComponent.RenTextBox();
            this.txtLastname = new RenComponent.RenTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNationality = new RenComponent.RenTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbClasse = new RenComponent.RenComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHomeInsti = new RenComponent.RenTextBox();
            this.txtObs = new RenComponent.RenTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.dpBirthday = new RenComponent.RenDatePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSchoolYear = new RenComponent.RenComboBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.cbParent = new RenComponent.RenComboBox();
            this.chkOrphan = new RenComponent.RenToggleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLocation = new RenComponent.RenComboBox();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(366, 547);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(231, 52);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.CheckedColor = System.Drawing.Color.MidnightBlue;
            this.rbFemale.FlatAppearance.BorderSize = 3;
            this.rbFemale.Location = new System.Drawing.Point(163, 252);
            this.rbFemale.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbFemale.Size = new System.Drawing.Size(104, 24);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.Text = "Femme";
            this.rbFemale.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.CheckedColor = System.Drawing.Color.MidnightBlue;
            this.rbMale.FlatAppearance.BorderSize = 3;
            this.rbMale.Location = new System.Drawing.Point(33, 252);
            this.rbMale.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbMale.Name = "rbMale";
            this.rbMale.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbMale.Size = new System.Drawing.Size(104, 24);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Homme";
            this.rbMale.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblOrphan
            // 
            this.lblOrphan.AutoSize = true;
            this.lblOrphan.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.lblOrphan.ForeColor = System.Drawing.Color.Black;
            this.lblOrphan.Location = new System.Drawing.Point(85, 488);
            this.lblOrphan.Name = "lblOrphan";
            this.lblOrphan.Size = new System.Drawing.Size(110, 22);
            this.lblOrphan.TabIndex = 0;
            this.lblOrphan.Text = "Orphelin ?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "N° Tel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(335, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lieu de naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(335, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adresse e-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adresse 📌";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prénom (s) 📌";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Genre 📌";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(90, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(818, 38);
            this.label9.TabIndex = 13;
            this.label9.Text = "Les champs avec \"📌\" sont obligatoires";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom 📌";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtAddress.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtAddress.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtAddress.BorderRadius = 9;
            this.txtAddress.BorderSize = 3;
            this.txtAddress.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(14, 342);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAddress.MaxLength = 150;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(293, 35);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtPhone.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtPhone.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtPhone.BorderRadius = 9;
            this.txtPhone.BorderSize = 3;
            this.txtPhone.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(14, 426);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPhone.MaxLength = 30;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.Size = new System.Drawing.Size(293, 35);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlinedStyle = false;
            // 
            // txtBirthplace
            // 
            this.txtBirthplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtBirthplace.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtBirthplace.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtBirthplace.BorderRadius = 9;
            this.txtBirthplace.BorderSize = 3;
            this.txtBirthplace.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtBirthplace.ForeColor = System.Drawing.Color.Black;
            this.txtBirthplace.Location = new System.Drawing.Point(339, 175);
            this.txtBirthplace.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBirthplace.MaxLength = 100;
            this.txtBirthplace.Multiline = false;
            this.txtBirthplace.Name = "txtBirthplace";
            this.txtBirthplace.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtBirthplace.PasswordChar = false;
            this.txtBirthplace.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBirthplace.PlaceholderText = "";
            this.txtBirthplace.Size = new System.Drawing.Size(291, 35);
            this.txtBirthplace.TabIndex = 8;
            this.txtBirthplace.Texts = "";
            this.txtBirthplace.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtEmail.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtEmail.BorderRadius = 9;
            this.txtEmail.BorderSize = 3;
            this.txtEmail.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(339, 342);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.MaxLength = 90;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(291, 35);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
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
            this.txtFirstname.Location = new System.Drawing.Point(14, 175);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFirstname.MaxLength = 150;
            this.txtFirstname.Multiline = false;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtFirstname.PasswordChar = false;
            this.txtFirstname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFirstname.PlaceholderText = "";
            this.txtFirstname.Size = new System.Drawing.Size(293, 35);
            this.txtFirstname.TabIndex = 2;
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
            this.txtLastname.Location = new System.Drawing.Point(14, 90);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLastname.MaxLength = 120;
            this.txtLastname.Multiline = false;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtLastname.PasswordChar = false;
            this.txtLastname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastname.PlaceholderText = "";
            this.txtLastname.Size = new System.Drawing.Size(293, 35);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.Texts = "";
            this.txtLastname.UnderlinedStyle = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(335, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date de naissance";
            // 
            // txtNationality
            // 
            this.txtNationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtNationality.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtNationality.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtNationality.BorderRadius = 9;
            this.txtNationality.BorderSize = 3;
            this.txtNationality.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtNationality.ForeColor = System.Drawing.Color.Black;
            this.txtNationality.Location = new System.Drawing.Point(339, 257);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNationality.MaxLength = 100;
            this.txtNationality.Multiline = false;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtNationality.PasswordChar = false;
            this.txtNationality.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNationality.PlaceholderText = "";
            this.txtNationality.Size = new System.Drawing.Size(291, 35);
            this.txtNationality.TabIndex = 9;
            this.txtNationality.Texts = "";
            this.txtNationality.UnderlinedStyle = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(335, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nationnalité";
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
            this.cbClasse.Location = new System.Drawing.Point(666, 100);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Padding = new System.Windows.Forms.Padding(2);
            this.cbClasse.SelectedValue = null;
            this.cbClasse.Size = new System.Drawing.Size(291, 30);
            this.cbClasse.TabIndex = 12;
            this.cbClasse.Texts = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(662, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Classe 📌";
            // 
            // txtHomeInsti
            // 
            this.txtHomeInsti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtHomeInsti.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtHomeInsti.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtHomeInsti.BorderRadius = 9;
            this.txtHomeInsti.BorderSize = 3;
            this.txtHomeInsti.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtHomeInsti.ForeColor = System.Drawing.Color.Black;
            this.txtHomeInsti.Location = new System.Drawing.Point(339, 428);
            this.txtHomeInsti.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHomeInsti.MaxLength = 100;
            this.txtHomeInsti.Multiline = false;
            this.txtHomeInsti.Name = "txtHomeInsti";
            this.txtHomeInsti.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtHomeInsti.PasswordChar = false;
            this.txtHomeInsti.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHomeInsti.PlaceholderText = "";
            this.txtHomeInsti.Size = new System.Drawing.Size(291, 35);
            this.txtHomeInsti.TabIndex = 11;
            this.txtHomeInsti.Texts = "";
            this.txtHomeInsti.UnderlinedStyle = false;
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.txtObs.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtObs.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txtObs.BorderRadius = 9;
            this.txtObs.BorderSize = 3;
            this.txtObs.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txtObs.ForeColor = System.Drawing.Color.Black;
            this.txtObs.Location = new System.Drawing.Point(666, 342);
            this.txtObs.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtObs.MaxLength = 2000;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtObs.PasswordChar = false;
            this.txtObs.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtObs.PlaceholderText = "Vous pouvez spécifier des allergies, des maladies, le comportement, etc.";
            this.txtObs.Size = new System.Drawing.Size(313, 253);
            this.txtObs.TabIndex = 16;
            this.txtObs.Texts = "";
            this.txtObs.UnderlinedStyle = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(335, 402);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(235, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Établissement d\'origine";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.lblObs.ForeColor = System.Drawing.Color.Black;
            this.lblObs.Location = new System.Drawing.Point(662, 316);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(127, 22);
            this.lblObs.TabIndex = 0;
            this.lblObs.Text = "Observation";
            // 
            // dpBirthday
            // 
            this.dpBirthday.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.dpBirthday.BorderSize = 3;
            this.dpBirthday.CalendarForeColor = System.Drawing.Color.Black;
            this.dpBirthday.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.dpBirthday.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.dpBirthday.CalendarTitleForeColor = System.Drawing.Color.LightCyan;
            this.dpBirthday.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dpBirthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dpBirthday.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.dpBirthday.Location = new System.Drawing.Point(339, 95);
            this.dpBirthday.MaxDate = new System.DateTime(2025, 10, 5, 0, 0, 0, 0);
            this.dpBirthday.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dpBirthday.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpBirthday.Name = "dpBirthday";
            this.dpBirthday.Size = new System.Drawing.Size(291, 35);
            this.dpBirthday.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.dpBirthday.TabIndex = 7;
            this.dpBirthday.TextColor = System.Drawing.Color.Black;
            this.dpBirthday.Value = new System.DateTime(2025, 10, 5, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(662, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Année scolaire 📌";
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
            this.cbSchoolYear.Location = new System.Drawing.Point(666, 180);
            this.cbSchoolYear.Name = "cbSchoolYear";
            this.cbSchoolYear.Padding = new System.Windows.Forms.Padding(2);
            this.cbSchoolYear.SelectedValue = null;
            this.cbSchoolYear.Size = new System.Drawing.Size(291, 30);
            this.cbSchoolYear.TabIndex = 13;
            this.cbSchoolYear.Texts = "";
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.lblParent.ForeColor = System.Drawing.Color.Black;
            this.lblParent.Location = new System.Drawing.Point(335, 476);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(159, 22);
            this.lblParent.TabIndex = 0;
            this.lblParent.Text = "Parent / Tuteur";
            // 
            // cbParent
            // 
            this.cbParent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbParent.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbParent.BorderSize = 2;
            this.cbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbParent.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbParent.ForeColor = System.Drawing.Color.Black;
            this.cbParent.IconColor = System.Drawing.Color.DarkCyan;
            this.cbParent.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbParent.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbParent.Location = new System.Drawing.Point(339, 502);
            this.cbParent.Name = "cbParent";
            this.cbParent.Padding = new System.Windows.Forms.Padding(2);
            this.cbParent.SelectedValue = null;
            this.cbParent.Size = new System.Drawing.Size(291, 30);
            this.cbParent.TabIndex = 14;
            this.cbParent.Texts = "";
            // 
            // chkOrphan
            // 
            this.chkOrphan.Location = new System.Drawing.Point(19, 488);
            this.chkOrphan.MinimumSize = new System.Drawing.Size(45, 22);
            this.chkOrphan.Name = "chkOrphan";
            this.chkOrphan.OffBackColor = System.Drawing.Color.CornflowerBlue;
            this.chkOrphan.OffToggleColor = System.Drawing.Color.MidnightBlue;
            this.chkOrphan.OnBackColor = System.Drawing.Color.LightCyan;
            this.chkOrphan.OnToggleColor = System.Drawing.Color.DarkSlateGray;
            this.chkOrphan.Size = new System.Drawing.Size(60, 24);
            this.chkOrphan.TabIndex = 15;
            this.chkOrphan.UseVisualStyleBackColor = true;
            this.chkOrphan.CheckedChanged += new System.EventHandler(this.ChkOrphan_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(662, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Site 📌";
            // 
            // cbLocation
            // 
            this.cbLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.cbLocation.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbLocation.BorderSize = 2;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbLocation.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.cbLocation.ForeColor = System.Drawing.Color.Black;
            this.cbLocation.IconColor = System.Drawing.Color.DarkCyan;
            this.cbLocation.ListBackColor = System.Drawing.Color.DarkSlateGray;
            this.cbLocation.ListTextColor = System.Drawing.Color.LightCyan;
            this.cbLocation.Location = new System.Drawing.Point(666, 257);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Padding = new System.Windows.Forms.Padding(2);
            this.cbLocation.SelectedValue = null;
            this.cbLocation.Size = new System.Drawing.Size(291, 30);
            this.cbLocation.TabIndex = 13;
            this.cbLocation.Texts = "";
            // 
            // AdStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(994, 608);
            this.Controls.Add(this.chkOrphan);
            this.Controls.Add(this.cbParent);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.cbSchoolYear);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.dpBirthday);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblOrphan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtHomeInsti);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtBirthplace);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtLastname);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdStudent";
            this.Text = "Inscription d\'élève";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdStudentF_FormClosed);
            this.Load += new System.EventHandler(this.AdStudentF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenComponent.RenButton btnSave;
        private RenComponent.RenRadioButton rbFemale;
        private RenComponent.RenRadioButton rbMale;
        private System.Windows.Forms.Label lblOrphan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private RenComponent.RenTextBox txtAddress;
        private RenComponent.RenTextBox txtPhone;
        private RenComponent.RenTextBox txtBirthplace;
        private RenComponent.RenTextBox txtEmail;
        private RenComponent.RenTextBox txtFirstname;
        private RenComponent.RenTextBox txtLastname;
        private System.Windows.Forms.Label label10;
        private RenComponent.RenTextBox txtNationality;
        private System.Windows.Forms.Label label11;
        private RenComponent.RenComboBox cbClasse;
        private System.Windows.Forms.Label label13;
        private RenComponent.RenTextBox txtHomeInsti;
        private RenComponent.RenTextBox txtObs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblObs;
        private RenComponent.RenDatePicker dpBirthday;
        private System.Windows.Forms.Label label12;
        private RenComponent.RenComboBox cbSchoolYear;
        private System.Windows.Forms.Label lblParent;
        private RenComponent.RenComboBox cbParent;
        private RenComponent.RenToggleButton chkOrphan;
        private System.Windows.Forms.Label label8;
        private RenComponent.RenComboBox cbLocation;
    }
}