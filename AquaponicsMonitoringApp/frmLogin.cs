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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            pnlLogin_Register.BackColor = Color.FromArgb(50, Color.White);
            btnLOGINform.FlatAppearance.BorderSize = 1;
            pnlLoginDetails.Visible = true;
            pnlRegisterDetails.Visible = false;
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            frmMainDashboard MainDash = new frmMainDashboard();
            MainDash.Show();
            this.Close();
        }

        private void btnREGISTER_Click(object sender, EventArgs e)
        {
            btnREGISTERform.ForeColor = Color.LimeGreen;
            btnREGISTERform.FlatAppearance.BorderSize = 1;
            btnLOGINform.ForeColor = Color.DarkGreen;
            btnLOGINform.FlatAppearance.BorderSize = 0;

            pnlRegisterDetails.Visible = true;
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            btnLOGINform.ForeColor = Color.LimeGreen;
            btnLOGINform.FlatAppearance.BorderSize = 1;
            btnREGISTERform.ForeColor = Color.DarkGreen;
            btnREGISTERform.FlatAppearance.BorderSize = 0;

            pnlRegisterDetails.Visible = false;
        }

        private void txtSecurityAnswer_Enter(object sender, EventArgs e)
        {
            if (txtSecurityAnswer.Text == "Enter Answer")
            {
                txtSecurityAnswer.Text = "";
                txtSecurityAnswer.ForeColor = Color.White;
            }
        }

        private void txtSecurityAnswer_Leave(object sender, EventArgs e)
        {
            if (txtSecurityAnswer.Text == "")
            {
                txtSecurityAnswer.Text = "Enter Answer";
                txtSecurityAnswer.ForeColor = Color.DarkSlateGray;
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "frmFormSeparator")
                {
                    Application.OpenForms[i].Close();
                }
            }
           
            frmSettingsMainDash Settings = new frmSettingsMainDash();
            Settings.Show();
            this.Close();

            
           
        }
    }
}
