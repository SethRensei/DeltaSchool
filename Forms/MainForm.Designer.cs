namespace DeltaSchool.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new RenComponent.RenPanel();
            this.btnStaff = new RenComponent.RenButton();
            this.btnClasse = new RenComponent.RenButton();
            this.btnStudent = new RenComponent.RenButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar = new RenComponent.RenPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMaximize = new RenComponent.RenButton();
            this.btnMinimize = new RenComponent.RenButton();
            this.btnClose = new RenComponent.RenButton();
            this.MainEllipse = new RenComponent.RenEllipse();
            this.pnlMain = new RenComponent.RenPanel();
            this.drpStudent = new RenComponent.RenDropdownMenu(this.components);
            this.adStudentTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.studentTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.parentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adParentSTM = new System.Windows.Forms.ToolStripMenuItem();
            this.parentTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.drpClasse = new RenComponent.RenDropdownMenu(this.components);
            this.classesAndSubjetsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.classeSubjectTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.drpStaff = new RenComponent.RenDropdownMenu(this.components);
            this.adStaffTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.staffsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.jobTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.drpStudent.SuspendLayout();
            this.drpClasse.SuspendLayout();
            this.drpStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlMenu.BorderRadius = 0;
            this.pnlMenu.BorderSize = 0;
            this.pnlMenu.Controls.Add(this.btnStaff);
            this.pnlMenu.Controls.Add(this.btnClasse);
            this.pnlMenu.Controls.Add(this.btnStudent);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.White;
            this.pnlMenu.GradientAngle = 90F;
            this.pnlMenu.GradientBottomColor = System.Drawing.Color.Transparent;
            this.pnlMenu.GradientTopColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(234, 700);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnStaff.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnStaff.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStaff.BorderRadius = 0;
            this.btnStaff.BorderSize = 0;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.LightCyan;
            this.btnStaff.Image = global::DeltaSchool.Properties.Resources.staff;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 216);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(0);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(234, 46);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = " Personnel   ▶";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // btnClasse
            // 
            this.btnClasse.BackColor = System.Drawing.Color.Transparent;
            this.btnClasse.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClasse.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClasse.BorderRadius = 0;
            this.btnClasse.BorderSize = 0;
            this.btnClasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClasse.FlatAppearance.BorderSize = 0;
            this.btnClasse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClasse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasse.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasse.ForeColor = System.Drawing.Color.LightCyan;
            this.btnClasse.Image = global::DeltaSchool.Properties.Resources.classroom;
            this.btnClasse.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClasse.Location = new System.Drawing.Point(0, 170);
            this.btnClasse.Margin = new System.Windows.Forms.Padding(0);
            this.btnClasse.Name = "btnClasse";
            this.btnClasse.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnClasse.Size = new System.Drawing.Size(234, 46);
            this.btnClasse.TabIndex = 2;
            this.btnClasse.Text = " Classes   ▶";
            this.btnClasse.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClasse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClasse.UseVisualStyleBackColor = false;
            this.btnClasse.Click += new System.EventHandler(this.BtnClasse_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnStudent.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnStudent.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStudent.BorderRadius = 0;
            this.btnStudent.BorderSize = 0;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.LightCyan;
            this.btnStudent.Image = global::DeltaSchool.Properties.Resources.student;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStudent.Location = new System.Drawing.Point(0, 124);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(234, 46);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = " Élèves   ▶";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(234, 124);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogo.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.LightCyan;
            this.lblLogo.Location = new System.Drawing.Point(73, 33);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(159, 32);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Delta School";
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::DeltaSchool.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(-5, -1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(98, 79);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitleBar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlTitleBar.BorderRadius = 0;
            this.pnlTitleBar.BorderSize = 0;
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.ForeColor = System.Drawing.Color.White;
            this.pnlTitleBar.GradientAngle = 95F;
            this.pnlTitleBar.GradientBottomColor = System.Drawing.Color.DarkSlateGray;
            this.pnlTitleBar.GradientTopColor = System.Drawing.Color.MidnightBlue;
            this.pnlTitleBar.Location = new System.Drawing.Point(234, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1010, 53);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LightCyan;
            this.lblTitle.Location = new System.Drawing.Point(28, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Accueil";
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BorderColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BorderRadius = 0;
            this.btnMaximize.BorderSize = 0;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = global::DeltaSchool.Properties.Resources.maximize;
            this.btnMaximize.Location = new System.Drawing.Point(933, 7);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(21, 27);
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderRadius = 0;
            this.btnMinimize.BorderSize = 0;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::DeltaSchool.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(892, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 27);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
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
            this.btnClose.Location = new System.Drawing.Point(965, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MainEllipse
            // 
            this.MainEllipse.AllCornerRadius = 30;
            this.MainEllipse.BottomLeft = 30;
            this.MainEllipse.BottomRight = 30;
            this.MainEllipse.TargetControl = this;
            this.MainEllipse.TopLeft = 30;
            this.MainEllipse.TopRight = 30;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlMain.BorderRadius = 0;
            this.pnlMain.BorderSize = 0;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.White;
            this.pnlMain.GradientAngle = 90F;
            this.pnlMain.GradientBottomColor = System.Drawing.Color.Transparent;
            this.pnlMain.GradientTopColor = System.Drawing.Color.Transparent;
            this.pnlMain.Location = new System.Drawing.Point(234, 53);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1010, 647);
            this.pnlMain.TabIndex = 0;
            // 
            // drpStudent
            // 
            this.drpStudent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.drpStudent.DropShadowEnabled = false;
            this.drpStudent.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.drpStudent.IsMainMenu = false;
            this.drpStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adStudentTSM,
            this.studentTSM,
            this.parentsToolStripMenuItem});
            this.drpStudent.MenuItemHeight = 25;
            this.drpStudent.MenuItemTextColor = System.Drawing.Color.LightCyan;
            this.drpStudent.Name = "drpStudent";
            this.drpStudent.PrimaryColor = System.Drawing.Color.DarkSlateGray;
            this.drpStudent.ShowImageMargin = false;
            this.drpStudent.Size = new System.Drawing.Size(159, 94);
            // 
            // adStudentTSM
            // 
            this.adStudentTSM.Margin = new System.Windows.Forms.Padding(0, 3, 0, 9);
            this.adStudentTSM.Name = "adStudentTSM";
            this.adStudentTSM.Size = new System.Drawing.Size(158, 22);
            this.adStudentTSM.Text = "Inscription";
            this.adStudentTSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentTSM
            // 
            this.studentTSM.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.studentTSM.Name = "studentTSM";
            this.studentTSM.Size = new System.Drawing.Size(158, 22);
            this.studentTSM.Text = "Liste d\'élèves";
            this.studentTSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parentsToolStripMenuItem
            // 
            this.parentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adParentSTM,
            this.parentTSM});
            this.parentsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.parentsToolStripMenuItem.Name = "parentsToolStripMenuItem";
            this.parentsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.parentsToolStripMenuItem.Text = "Parents";
            this.parentsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adParentSTM
            // 
            this.adParentSTM.BackColor = System.Drawing.Color.DarkSlateGray;
            this.adParentSTM.Name = "adParentSTM";
            this.adParentSTM.Size = new System.Drawing.Size(136, 22);
            this.adParentSTM.Text = "Ajouter";
            this.adParentSTM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adParentSTM.Click += new System.EventHandler(this.AdParentSTM_Click);
            // 
            // parentTSM
            // 
            this.parentTSM.BackColor = System.Drawing.Color.DarkSlateGray;
            this.parentTSM.Name = "parentTSM";
            this.parentTSM.Size = new System.Drawing.Size(136, 22);
            this.parentTSM.Text = "Liste";
            this.parentTSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parentTSM.Click += new System.EventHandler(this.ParentTSM_Click);
            // 
            // drpClasse
            // 
            this.drpClasse.BackColor = System.Drawing.Color.DarkSlateGray;
            this.drpClasse.DropShadowEnabled = false;
            this.drpClasse.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.drpClasse.IsMainMenu = false;
            this.drpClasse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classesAndSubjetsTSM,
            this.classeSubjectTSM});
            this.drpClasse.MenuItemHeight = 25;
            this.drpClasse.MenuItemTextColor = System.Drawing.Color.LightCyan;
            this.drpClasse.Name = "drpStudent";
            this.drpClasse.PrimaryColor = System.Drawing.Color.DarkSlateGray;
            this.drpClasse.ShowImageMargin = false;
            this.drpClasse.Size = new System.Drawing.Size(276, 85);
            // 
            // classesAndSubjetsTSM
            // 
            this.classesAndSubjetsTSM.Margin = new System.Windows.Forms.Padding(0, 3, 0, 9);
            this.classesAndSubjetsTSM.Name = "classesAndSubjetsTSM";
            this.classesAndSubjetsTSM.Size = new System.Drawing.Size(275, 22);
            this.classesAndSubjetsTSM.Text = "Liste classes et matières";
            this.classesAndSubjetsTSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classesAndSubjetsTSM.Click += new System.EventHandler(this.ClassesAndSubjetsTSM_Click);
            // 
            // classeSubjectTSM
            // 
            this.classeSubjectTSM.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.classeSubjectTSM.Name = "classeSubjectTSM";
            this.classeSubjectTSM.Size = new System.Drawing.Size(275, 22);
            this.classeSubjectTSM.Text = "Assignation Classe - Matière";
            this.classeSubjectTSM.Click += new System.EventHandler(this.ClasseSubjectTSM_Click);
            // 
            // drpStaff
            // 
            this.drpStaff.BackColor = System.Drawing.Color.DarkSlateGray;
            this.drpStaff.DropShadowEnabled = false;
            this.drpStaff.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.drpStaff.IsMainMenu = false;
            this.drpStaff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adStaffTSM,
            this.staffsTSM,
            this.jobTSM});
            this.drpStaff.MenuItemHeight = 25;
            this.drpStaff.MenuItemTextColor = System.Drawing.Color.LightCyan;
            this.drpStaff.Name = "drpStudent";
            this.drpStaff.PrimaryColor = System.Drawing.Color.DarkSlateGray;
            this.drpStaff.ShowImageMargin = false;
            this.drpStaff.Size = new System.Drawing.Size(225, 94);
            // 
            // adStaffTSM
            // 
            this.adStaffTSM.Margin = new System.Windows.Forms.Padding(0, 3, 0, 9);
            this.adStaffTSM.Name = "adStaffTSM";
            this.adStaffTSM.Size = new System.Drawing.Size(224, 22);
            this.adStaffTSM.Text = "Ajouter du personnel";
            this.adStaffTSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adStaffTSM.Click += new System.EventHandler(this.AdStaffTSM_Click);
            // 
            // staffsTSM
            // 
            this.staffsTSM.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.staffsTSM.Name = "staffsTSM";
            this.staffsTSM.Size = new System.Drawing.Size(224, 22);
            this.staffsTSM.Text = "Liste du personnel";
            this.staffsTSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffsTSM.Click += new System.EventHandler(this.StaffsTSM_Click);
            // 
            // jobTSM
            // 
            this.jobTSM.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.jobTSM.Name = "jobTSM";
            this.jobTSM.Size = new System.Drawing.Size(224, 22);
            this.jobTSM.Text = "Gestion de fonction";
            this.jobTSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jobTSM.Click += new System.EventHandler(this.JobTSM_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1244, 700);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(1244, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.drpStudent.ResumeLayout(false);
            this.drpClasse.ResumeLayout(false);
            this.drpStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RenComponent.RenPanel pnlMenu;
        private RenComponent.RenPanel pnlTitleBar;
        private RenComponent.RenButton btnClose;
        private RenComponent.RenEllipse MainEllipse;
        private RenComponent.RenButton btnMinimize;
        private RenComponent.RenButton btnMaximize;
        private RenComponent.RenPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogo;
        private RenComponent.RenButton btnStudent;
        private RenComponent.RenDropdownMenu drpStudent;
        private System.Windows.Forms.ToolStripMenuItem adStudentTSM;
        private System.Windows.Forms.ToolStripMenuItem studentTSM;
        private System.Windows.Forms.ToolStripMenuItem parentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adParentSTM;
        private System.Windows.Forms.ToolStripMenuItem parentTSM;
        private RenComponent.RenButton btnClasse;
        private RenComponent.RenDropdownMenu drpClasse;
        private System.Windows.Forms.ToolStripMenuItem classesAndSubjetsTSM;
        private System.Windows.Forms.ToolStripMenuItem classeSubjectTSM;
        private RenComponent.RenButton btnStaff;
        private RenComponent.RenDropdownMenu drpStaff;
        private System.Windows.Forms.ToolStripMenuItem adStaffTSM;
        private System.Windows.Forms.ToolStripMenuItem staffsTSM;
        private System.Windows.Forms.ToolStripMenuItem jobTSM;
    }
}