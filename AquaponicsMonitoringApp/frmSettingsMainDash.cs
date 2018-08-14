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
    public partial class frmSettingsMainDash : Form
    {
        public frmSettingsMainDash()
        {
            InitializeComponent();
            pnlMainDashLayout.BackColor = Color.FromArgb(40, 91, 55);
            btnAddSensor.BackColor = Color.FromArgb(58, 131, 79);
        }

        private void btnMinimizeSettings_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseSettings_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizeSettings_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseSettings_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxExistingTank_CheckedChanged(object sender, EventArgs e)
        {
            pnlExistingTank.Visible = true;
            cbxExistingTank.Checked = false;
        }

        private void cbxChooseNewTank_CheckedChanged(object sender, EventArgs e)
        {
            pnlExistingTank.Visible = false;
        }

        private void cmbSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSensorType.SelectedItem.ToString() == "Temperature")
            {
                pnlPhCriticalRange.Visible = false;
                pnlMessage.Visible = false;
            }
            if (cmbSensorType.SelectedItem.ToString() == "pH")
            {
                pnlPhCriticalRange.Visible = true;
                pnlMessage.Visible = false;
            }
        }

        private void btnAddSensor_Click(object sender, EventArgs e)
        {
            frmSettingsMainDash AddSensor = new frmSettingsMainDash();
            AddSensor.Show();
            btnAddSensor.BackColor = Color.FromArgb(58, 131, 79);
        }

        private void btnEditSensor_Click(object sender, EventArgs e)
        {
            frmEditSensor EditSensor = new frmEditSensor();
            EditSensor.Show();
            this.Close();
            
        }

        private void btnNotificationSettings_Click(object sender, EventArgs e)
        {
            frmNotificationSettings NotificationSettings = new frmNotificationSettings();
            NotificationSettings.Show();
            this.Close();
        }

        private void pnlDashSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
