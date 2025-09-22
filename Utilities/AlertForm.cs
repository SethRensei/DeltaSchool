using System;
using System.Drawing;
using System.Windows.Forms;

using DeltaSchool.Properties;

namespace DeltaSchool.Utilities
{
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
        }

        public enum EnmAction
        {
            wait,
            start,
            close
        }

        public enum EnmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private AlertForm.EnmAction action;
        private int pos_x, pos_y;

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = EnmAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case EnmAction.wait:
                    timer1.Interval = 5000;
                    action = EnmAction.close;
                    break;
                case EnmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.pos_x < this.Location.X)
                        this.Left--;
                    else
                        if (this.Opacity == 1.0)
                        action = EnmAction.wait;
                    break;
                case EnmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;

                    if (base.Opacity == 0.0)
                        base.Close();
                    break;
            }
        }

        public void ShowAlert(string message, EnmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "Alert " + i.ToString();
                AlertForm frm = (AlertForm)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.pos_x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.pos_y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.pos_x, this.pos_y);
                    break;
                }
            }
            this.pos_x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case EnmType.Success:
                    this.pic_box.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case EnmType.Error:
                    this.pic_box.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case EnmType.Warning:
                    this.pic_box.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
                case EnmType.Info:
                    this.pic_box.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
            }

            this.lblMsg.Text = message;

            this.Show();
            this.action = EnmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
