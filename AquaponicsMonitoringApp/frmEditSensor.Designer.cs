namespace AquaponicsMonitoringApp
{
    partial class frmEditSensor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditSensor));
            this.pnlMainDashLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDashSideMenu = new System.Windows.Forms.Panel();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnEditSensor = new System.Windows.Forms.Button();
            this.pnlDashContext = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSystemSettings = new System.Windows.Forms.Label();
            this.lblDashDivider = new System.Windows.Forms.Label();
            this.lblDashSubHeader = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeaderMainDash = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pnlMainDashLayout.SuspendLayout();
            this.pnlDashSideMenu.SuspendLayout();
            this.pnlDashContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlHeaderMainDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainDashLayout
            // 
            this.pnlMainDashLayout.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainDashLayout.ColumnCount = 2;
            this.pnlMainDashLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.1117F));
            this.pnlMainDashLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.88831F));
            this.pnlMainDashLayout.Controls.Add(this.pnlDashSideMenu, 0, 1);
            this.pnlMainDashLayout.Controls.Add(this.pnlDashContext, 1, 1);
            this.pnlMainDashLayout.Controls.Add(this.imgLogo, 0, 0);
            this.pnlMainDashLayout.Controls.Add(this.pnlHeaderMainDash, 1, 0);
            this.pnlMainDashLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainDashLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlMainDashLayout.Name = "pnlMainDashLayout";
            this.pnlMainDashLayout.RowCount = 2;
            this.pnlMainDashLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.771574F));
            this.pnlMainDashLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.22842F));
            this.pnlMainDashLayout.Size = new System.Drawing.Size(1284, 728);
            this.pnlMainDashLayout.TabIndex = 2;
            // 
            // pnlDashSideMenu
            // 
            this.pnlDashSideMenu.Controls.Add(this.btnBackToMain);
            this.pnlDashSideMenu.Controls.Add(this.btnEditSensor);
            this.pnlDashSideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashSideMenu.Location = new System.Drawing.Point(3, 74);
            this.pnlDashSideMenu.Name = "pnlDashSideMenu";
            this.pnlDashSideMenu.Size = new System.Drawing.Size(188, 651);
            this.pnlDashSideMenu.TabIndex = 1;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToMain.FlatAppearance.BorderSize = 0;
            this.btnBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackToMain.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMain.Image")));
            this.btnBackToMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToMain.Location = new System.Drawing.Point(3, 51);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(186, 41);
            this.btnBackToMain.TabIndex = 2;
            this.btnBackToMain.Text = "   Back";
            this.btnBackToMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnEditSensor
            // 
            this.btnEditSensor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSensor.FlatAppearance.BorderSize = 0;
            this.btnEditSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSensor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSensor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditSensor.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSensor.Image")));
            this.btnEditSensor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSensor.Location = new System.Drawing.Point(3, 92);
            this.btnEditSensor.Name = "btnEditSensor";
            this.btnEditSensor.Size = new System.Drawing.Size(186, 41);
            this.btnEditSensor.TabIndex = 1;
            this.btnEditSensor.Text = "   Edit Sensor";
            this.btnEditSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSensor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditSensor.UseVisualStyleBackColor = true;
            this.btnEditSensor.Click += new System.EventHandler(this.btnEditSensor_Click);
            // 
            // pnlDashContext
            // 
            this.pnlDashContext.BackColor = System.Drawing.Color.Transparent;
            this.pnlDashContext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDashContext.BackgroundImage")));
            this.pnlDashContext.Controls.Add(this.label1);
            this.pnlDashContext.Controls.Add(this.lblSystemSettings);
            this.pnlDashContext.Controls.Add(this.lblDashDivider);
            this.pnlDashContext.Controls.Add(this.lblDashSubHeader);
            this.pnlDashContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashContext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDashContext.ForeColor = System.Drawing.Color.White;
            this.pnlDashContext.Location = new System.Drawing.Point(197, 74);
            this.pnlDashContext.Name = "pnlDashContext";
            this.pnlDashContext.Size = new System.Drawing.Size(1084, 651);
            this.pnlDashContext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(42, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "EDIT SENSOR";
            // 
            // lblSystemSettings
            // 
            this.lblSystemSettings.AutoSize = true;
            this.lblSystemSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemSettings.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemSettings.ForeColor = System.Drawing.Color.White;
            this.lblSystemSettings.Location = new System.Drawing.Point(41, 57);
            this.lblSystemSettings.Name = "lblSystemSettings";
            this.lblSystemSettings.Size = new System.Drawing.Size(166, 25);
            this.lblSystemSettings.TabIndex = 3;
            this.lblSystemSettings.Text = "System Settings";
            // 
            // lblDashDivider
            // 
            this.lblDashDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDashDivider.Location = new System.Drawing.Point(0, 139);
            this.lblDashDivider.Name = "lblDashDivider";
            this.lblDashDivider.Size = new System.Drawing.Size(1200, 1);
            this.lblDashDivider.TabIndex = 2;
            // 
            // lblDashSubHeader
            // 
            this.lblDashSubHeader.AutoSize = true;
            this.lblDashSubHeader.Location = new System.Drawing.Point(42, 92);
            this.lblDashSubHeader.Name = "lblDashSubHeader";
            this.lblDashSubHeader.Size = new System.Drawing.Size(371, 19);
            this.lblDashSubHeader.TabIndex = 1;
            this.lblDashSubHeader.Text = "Aquaponics && Aquaculture Monitoring System";
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLogo.BackgroundImage")));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLogo.Location = new System.Drawing.Point(3, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(188, 65);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // pnlHeaderMainDash
            // 
            this.pnlHeaderMainDash.Controls.Add(this.lblCompanyName);
            this.pnlHeaderMainDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderMainDash.Location = new System.Drawing.Point(197, 3);
            this.pnlHeaderMainDash.Name = "pnlHeaderMainDash";
            this.pnlHeaderMainDash.Size = new System.Drawing.Size(1084, 65);
            this.pnlHeaderMainDash.TabIndex = 3;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(3, 26);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(139, 23);
            this.lblCompanyName.TabIndex = 3;
            this.lblCompanyName.Text = "La Pieus Aqua";
            // 
            // frmEditSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 728);
            this.Controls.Add(this.pnlMainDashLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditSensor";
            this.Text = "frmEditSensor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMainDashLayout.ResumeLayout(false);
            this.pnlDashSideMenu.ResumeLayout(false);
            this.pnlDashContext.ResumeLayout(false);
            this.pnlDashContext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlHeaderMainDash.ResumeLayout(false);
            this.pnlHeaderMainDash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMainDashLayout;
        private System.Windows.Forms.Panel pnlDashSideMenu;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Panel pnlDashContext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSystemSettings;
        private System.Windows.Forms.Label lblDashDivider;
        private System.Windows.Forms.Label lblDashSubHeader;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlHeaderMainDash;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnEditSensor;
    }
}