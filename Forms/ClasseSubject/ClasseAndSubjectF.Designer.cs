namespace DeltaSchool.Forms.ClasseSubject
{
    partial class ClasseAndSubjectF
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
            this.dgvClasse = new RenComponent.PaginatedDataGridView();
            this.dgvSubject = new RenComponent.PaginatedDataGridView();
            this.lblClasses = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnOpenAdClasseAndSubjectF = new RenComponent.RenButton();
            this.btnEditClasse = new RenComponent.RenButton();
            this.btnDeleteClasse = new RenComponent.RenButton();
            this.btnEditSubject = new RenComponent.RenButton();
            this.btnDeleteSubject = new RenComponent.RenButton();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClasse
            // 
            this.dgvClasse.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvClasse.ButtonBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvClasse.ButtonBorderColor = System.Drawing.Color.LightCyan;
            this.dgvClasse.ButtonBorderRadius = 5;
            this.dgvClasse.ButtonBorderSize = 2;
            this.dgvClasse.ButtonFont = new System.Drawing.Font("Lucida Fax", 12F);
            this.dgvClasse.ButtonForeColor = System.Drawing.Color.LightCyan;
            this.dgvClasse.ButtonSize = new System.Drawing.Size(30, 30);
            // 
            // 
            // 
            this.dgvClasse.DataGrid.AllowUserToAddRows = false;
            this.dgvClasse.DataGrid.AllowUserToDeleteRows = false;
            this.dgvClasse.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasse.DataGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvClasse.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClasse.DataGrid.ColumnHeadersHeight = 40;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasse.DataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClasse.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClasse.DataGrid.GridColor = System.Drawing.Color.DimGray;
            this.dgvClasse.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvClasse.DataGrid.Margin = new System.Windows.Forms.Padding(172, 40, 172, 40);
            this.dgvClasse.DataGrid.Name = "dataGridView1";
            this.dgvClasse.DataGrid.ReadOnly = true;
            this.dgvClasse.DataGrid.RowHeadersVisible = false;
            this.dgvClasse.DataGrid.RowTemplate.Height = 35;
            this.dgvClasse.DataGrid.Size = new System.Drawing.Size(524, 393);
            this.dgvClasse.DataGrid.TabIndex = 1;
            this.dgvClasse.Location = new System.Drawing.Point(14, 158);
            this.dgvClasse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvClasse.Name = "dgvClasse";
            this.dgvClasse.Size = new System.Drawing.Size(524, 462);
            this.dgvClasse.TabIndex = 0;
            this.dgvClasse.Visible = false;
            // 
            // dgvSubject
            // 
            this.dgvSubject.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvSubject.ButtonBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvSubject.ButtonBorderColor = System.Drawing.Color.LightCyan;
            this.dgvSubject.ButtonBorderRadius = 5;
            this.dgvSubject.ButtonBorderSize = 2;
            this.dgvSubject.ButtonFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubject.ButtonForeColor = System.Drawing.Color.LightCyan;
            this.dgvSubject.ButtonSize = new System.Drawing.Size(30, 30);
            // 
            // 
            // 
            this.dgvSubject.DataGrid.AllowUserToAddRows = false;
            this.dgvSubject.DataGrid.AllowUserToDeleteRows = false;
            this.dgvSubject.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubject.DataGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvSubject.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubject.DataGrid.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubject.DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubject.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubject.DataGrid.GridColor = System.Drawing.Color.DimGray;
            this.dgvSubject.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvSubject.DataGrid.Margin = new System.Windows.Forms.Padding(287, 55, 287, 55);
            this.dgvSubject.DataGrid.Name = "dataGridView1";
            this.dgvSubject.DataGrid.ReadOnly = true;
            this.dgvSubject.DataGrid.RowHeadersVisible = false;
            this.dgvSubject.DataGrid.RowTemplate.Height = 35;
            this.dgvSubject.DataGrid.Size = new System.Drawing.Size(426, 391);
            this.dgvSubject.DataGrid.TabIndex = 1;
            this.dgvSubject.Location = new System.Drawing.Point(576, 158);
            this.dgvSubject.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.Size = new System.Drawing.Size(426, 460);
            this.dgvSubject.TabIndex = 0;
            this.dgvSubject.Visible = false;
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Font = new System.Drawing.Font("Lucida Fax", 18F);
            this.lblClasses.Location = new System.Drawing.Point(212, 127);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(103, 27);
            this.lblClasses.TabIndex = 1;
            this.lblClasses.Text = "Classes";
            this.lblClasses.Visible = false;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Lucida Fax", 18F);
            this.lblSubject.Location = new System.Drawing.Point(715, 126);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(116, 27);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Matières";
            this.lblSubject.Visible = false;
            // 
            // btnOpenAdClasseAndSubjectF
            // 
            this.btnOpenAdClasseAndSubjectF.BackColor = System.Drawing.Color.DimGray;
            this.btnOpenAdClasseAndSubjectF.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnOpenAdClasseAndSubjectF.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpenAdClasseAndSubjectF.BorderRadius = 4;
            this.btnOpenAdClasseAndSubjectF.BorderSize = 0;
            this.btnOpenAdClasseAndSubjectF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenAdClasseAndSubjectF.FlatAppearance.BorderSize = 0;
            this.btnOpenAdClasseAndSubjectF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAdClasseAndSubjectF.ForeColor = System.Drawing.Color.Black;
            this.btnOpenAdClasseAndSubjectF.Location = new System.Drawing.Point(-3, -1);
            this.btnOpenAdClasseAndSubjectF.Name = "btnOpenAdClasseAndSubjectF";
            this.btnOpenAdClasseAndSubjectF.Size = new System.Drawing.Size(241, 40);
            this.btnOpenAdClasseAndSubjectF.TabIndex = 2;
            this.btnOpenAdClasseAndSubjectF.Text = "Ajouter une classe/matière";
            this.btnOpenAdClasseAndSubjectF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAdClasseAndSubjectF.UseVisualStyleBackColor = false;
            this.btnOpenAdClasseAndSubjectF.Click += new System.EventHandler(this.BtnOpenAdClasseAndSubjectF_Click);
            // 
            // btnEditClasse
            // 
            this.btnEditClasse.BackColor = System.Drawing.Color.DimGray;
            this.btnEditClasse.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnEditClasse.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditClasse.BorderRadius = 4;
            this.btnEditClasse.BorderSize = 0;
            this.btnEditClasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClasse.FlatAppearance.BorderSize = 0;
            this.btnEditClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClasse.ForeColor = System.Drawing.Color.Black;
            this.btnEditClasse.Location = new System.Drawing.Point(14, 124);
            this.btnEditClasse.Name = "btnEditClasse";
            this.btnEditClasse.Size = new System.Drawing.Size(99, 27);
            this.btnEditClasse.TabIndex = 2;
            this.btnEditClasse.Text = "Modifier";
            this.btnEditClasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditClasse.UseVisualStyleBackColor = false;
            this.btnEditClasse.Visible = false;
            this.btnEditClasse.Click += new System.EventHandler(this.BtnEditClasse_Click);
            // 
            // btnDeleteClasse
            // 
            this.btnDeleteClasse.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteClasse.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnDeleteClasse.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteClasse.BorderRadius = 4;
            this.btnDeleteClasse.BorderSize = 0;
            this.btnDeleteClasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClasse.FlatAppearance.BorderSize = 0;
            this.btnDeleteClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClasse.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteClasse.Location = new System.Drawing.Point(430, 127);
            this.btnDeleteClasse.Name = "btnDeleteClasse";
            this.btnDeleteClasse.Size = new System.Drawing.Size(108, 26);
            this.btnDeleteClasse.TabIndex = 2;
            this.btnDeleteClasse.Text = "Supprimer";
            this.btnDeleteClasse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteClasse.UseVisualStyleBackColor = false;
            this.btnDeleteClasse.Visible = false;
            this.btnDeleteClasse.Click += new System.EventHandler(this.BtnDeleteClasse_Click);
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.BackColor = System.Drawing.Color.DimGray;
            this.btnEditSubject.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnEditSubject.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditSubject.BorderRadius = 4;
            this.btnEditSubject.BorderSize = 0;
            this.btnEditSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSubject.FlatAppearance.BorderSize = 0;
            this.btnEditSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSubject.ForeColor = System.Drawing.Color.Black;
            this.btnEditSubject.Location = new System.Drawing.Point(574, 126);
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.Size = new System.Drawing.Size(87, 27);
            this.btnEditSubject.TabIndex = 2;
            this.btnEditSubject.Text = "Modifier";
            this.btnEditSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSubject.UseVisualStyleBackColor = false;
            this.btnEditSubject.Visible = false;
            this.btnEditSubject.Click += new System.EventHandler(this.BtnEditSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteSubject.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnDeleteSubject.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteSubject.BorderRadius = 4;
            this.btnDeleteSubject.BorderSize = 0;
            this.btnDeleteSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSubject.FlatAppearance.BorderSize = 0;
            this.btnDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSubject.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSubject.Location = new System.Drawing.Point(895, 128);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(107, 26);
            this.btnDeleteSubject.TabIndex = 2;
            this.btnDeleteSubject.Text = "Supprimer";
            this.btnDeleteSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteSubject.UseVisualStyleBackColor = false;
            this.btnDeleteSubject.Visible = false;
            this.btnDeleteSubject.Click += new System.EventHandler(this.BtnDeleteSubject_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 18F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(161, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(818, 45);
            this.label9.TabIndex = 3;
            this.label9.Text = "LISTE CLASSES ET MATIÈRES DISPONIBLES";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClasseAndSubjectF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1010, 647);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnEditSubject);
            this.Controls.Add(this.btnDeleteClasse);
            this.Controls.Add(this.btnEditClasse);
            this.Controls.Add(this.btnOpenAdClasseAndSubjectF);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.dgvSubject);
            this.Controls.Add(this.dgvClasse);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ClasseAndSubjectF";
            this.Text = "Liste Classes - Matières";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClasseAndSubjectF_FormClosed);
            this.Load += new System.EventHandler(this.ClasseAndSubjectF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenComponent.PaginatedDataGridView dgvClasse;
        private RenComponent.PaginatedDataGridView dgvSubject;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.Label lblSubject;
        private RenComponent.RenButton btnOpenAdClasseAndSubjectF;
        private RenComponent.RenButton btnEditClasse;
        private RenComponent.RenButton btnDeleteClasse;
        private RenComponent.RenButton btnEditSubject;
        private RenComponent.RenButton btnDeleteSubject;
        private System.Windows.Forms.Label label9;
    }
}