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
    public partial class frmNotificationSettings : Form
    {
        public frmNotificationSettings()
        {
            InitializeComponent();
            pnlMainDashLayout.BackColor = Color.FromArgb(40, 91, 55);
            btnNotificationSettings.BackColor = Color.FromArgb(58, 131, 79);
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            frmSettingsMainDash MainSettings = new frmSettingsMainDash();
            MainSettings.Show();
            this.Close();
        }

        private void btnNotificationSettings_Click(object sender, EventArgs e)
        {
            frmNotificationSettings NotificationSettings = new frmNotificationSettings();
            NotificationSettings.Show();
            this.Close();
        }
    }
}
