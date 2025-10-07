using RenComponent;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DeltaSchool.Forms
{
    public partial class MainForm : Form
    {
        public static MainForm Instance;
        private Form currentChildForm;
        public MainForm()
        {
            InitializeComponent();

            Instance = this;

            // Form
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.pnlTitleBar.MouseDown += this.PnlMouseDown;
            picLogo.Click += ReturnMainForm;
            lblLogo.Click += ReturnMainForm;
        }

        public void OpenChildForm(Form child_form)
        {
            if (currentChildForm != null) currentChildForm.Close();

            currentChildForm = child_form;
            child_form.TopLevel = false;
            child_form.FormBorderStyle = FormBorderStyle.None;
            child_form.Dock = DockStyle.Fill;
            //child_form.BackColor = pnlMain.BackColor;
            pnlMain.Controls.Add(child_form);
            pnlMain.Tag = child_form;
            child_form.BringToFront();
            child_form.Show();
            lblTitle.Text = child_form.Text;
        }

        private void OpenSidebarDRP(RenDropdownMenu drp, RenButton btn) => drp.Show(btn, btn.Width, 0);

        // Drap Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region -> Events
        private void PnlMouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                this.MainEllipse.AllCornerRadius = 13;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                this.MainEllipse.AllCornerRadius = 30;
            }
        }

        private void ReturnMainForm(object sender, EventArgs e)
        {
            currentChildForm.Close();
            this.lblTitle.Text = "Accueil";
        }
        
        private void BtnStudent_Click(object sender, EventArgs e)
        {
            OpenSidebarDRP(drpStudent, btnStudent);
        }
        private void AdStudentTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Student.AdStudent());
        }

        private void StudentTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Student.StudentsF());
        }

        private void ParentTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ParentStudent.ParentF());
        }

        private void AdParentSTM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ParentStudent.AddParentF());
        }

        private void BtnClasse_Click(object sender, EventArgs e)
        {
            OpenSidebarDRP(drpClasse, btnClasse);
        }

        private void ClassesAndSubjetsTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClasseSubject.ClasseAndSubjectF());
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            OpenSidebarDRP(drpStaff, btnStaff);
        }

        private void AdStaffTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.AdStaffF());
        }

        private void StaffsTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.StaffsF());
        }

        private void JobTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.JobF());
        }

        private void StaffJobTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.StaffJobF());
        }

        private void ClasseSubjectTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClasseSubject.ClasseSubjectF());
        }
        private void BtnFinance_Click(object sender, EventArgs e)
        {
            OpenSidebarDRP(drpFinance, btnFinance);
        }
        private void TransacTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Finance.SchoolingF());
        }

        private void AdPayrollTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Payroll.AdPayrollF());
        }

        private void PayrollTSM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Payroll.PayrollF());
        }
        #endregion

    }
}
