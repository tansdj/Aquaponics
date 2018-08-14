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
    public partial class frmEditSensor : Form
    {
        public frmEditSensor()
        {
            InitializeComponent();
            pnlMainDashLayout.BackColor = Color.FromArgb(40, 91, 55);
            btnEditSensor.BackColor = Color.FromArgb(58, 131, 79);
        }

        private void btnEditSensor_Click(object sender, EventArgs e)
        {
            frmEditSensor EditSensor = new frmEditSensor();
            EditSensor.Show();
            this.Close();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            frmSettingsMainDash MainSettings = new frmSettingsMainDash();
            MainSettings.Show();
            this.Close();
        }
    }
}
