using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AquaponicsMonitoringApp
{
    public partial class frmMainDashboard : Form
    {
        public frmMainDashboard()
        {
            InitializeComponent();
        }

        private void frmMainDashboard_Load(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(58, 131, 79);
        }

        private void pnlDashSideMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlMainDashLayout_Paint(object sender, PaintEventArgs e)
        {
            pnlMainDashLayout.BackColor = Color.FromArgb(40, 91, 55);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlDashAction1_Paint(object sender, PaintEventArgs e)
        {
            pnlDashAction1.BackColor = Color.FromArgb(40, 91, 55);
            pnlDashAction1Header.BackColor = Color.FromArgb(0, 51, 40);
        }

        private void pnlDashAction2_Paint(object sender, PaintEventArgs e)
        {
            pnlDashAction2.BackColor = Color.FromArgb(40, 91, 55);
            pnlDashAction2Header.BackColor = Color.FromArgb(0, 51, 40);
        }

        private void pnlDashAction3_Paint(object sender, PaintEventArgs e)
        {
            pnlDashAction3.BackColor = Color.FromArgb(40, 91, 55);
            pnlDashAction3Header.BackColor = Color.FromArgb(0, 51, 40);
        }

        private void pnlDashAction4_Paint(object sender, PaintEventArgs e)
        {
            pnlDashAction4.BackColor = Color.FromArgb(40, 91, 55);
            pnlDashAction4Header.BackColor = Color.FromArgb(0, 51, 40);
        }

        private void pnlDashAction5_Paint(object sender, PaintEventArgs e)
        {
            pnlDashAction5.BackColor = Color.FromArgb(40, 91, 55);
            pnlDashAction5Header.BackColor = Color.FromArgb(0, 51, 40);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmFormSeparator Separator = new frmFormSeparator();
            Separator.Show();
            frmLogin Login = new frmLogin();
            Login.Show();
            btnDashboard.BackColor = Color.Transparent;
            btnSettings.BackColor = Color.FromArgb(58, 131, 79);
        }
    }

}
