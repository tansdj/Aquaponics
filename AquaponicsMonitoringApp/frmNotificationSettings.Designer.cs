namespace AquaponicsMonitoringApp
{
    partial class frmNotificationSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotificationSettings));
            this.pnlMainDashLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDashSideMenu = new System.Windows.Forms.Panel();
            this.btnNotificationSettings = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.pnlDashContext = new System.Windows.Forms.Panel();
            this.btnSaveNewList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAvailableEmails = new System.Windows.Forms.Label();
            this.btnMoveAllLeft = new System.Windows.Forms.Button();
            this.btnMoveAllRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.lbxNotificationEmails = new System.Windows.Forms.ListBox();
            this.lbxAvailableEmails = new System.Windows.Forms.ListBox();
            this.lblNotificationSettings = new System.Windows.Forms.Label();
            this.lblSystemSettings = new System.Windows.Forms.Label();
            this.lblDashDivider = new System.Windows.Forms.Label();
            this.lblDashSubHeader = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeaderMainDash = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.pnlMainDashLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.43302F));
            this.pnlMainDashLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.56698F));
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
            this.pnlMainDashLayout.Size = new System.Drawing.Size(1284, 749);
            this.pnlMainDashLayout.TabIndex = 3;
            // 
            // pnlDashSideMenu
            // 
            this.pnlDashSideMenu.Controls.Add(this.btnNotificationSettings);
            this.pnlDashSideMenu.Controls.Add(this.btnBackToMain);
            this.pnlDashSideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashSideMenu.Location = new System.Drawing.Point(3, 76);
            this.pnlDashSideMenu.Name = "pnlDashSideMenu";
            this.pnlDashSideMenu.Size = new System.Drawing.Size(204, 670);
            this.pnlDashSideMenu.TabIndex = 1;
            // 
            // btnNotificationSettings
            // 
            this.btnNotificationSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotificationSettings.FlatAppearance.BorderSize = 0;
            this.btnNotificationSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificationSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificationSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNotificationSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnNotificationSettings.Image")));
            this.btnNotificationSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificationSettings.Location = new System.Drawing.Point(0, 98);
            this.btnNotificationSettings.Name = "btnNotificationSettings";
            this.btnNotificationSettings.Size = new System.Drawing.Size(217, 41);
            this.btnNotificationSettings.TabIndex = 4;
            this.btnNotificationSettings.Text = "   Notification Settings";
            this.btnNotificationSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificationSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotificationSettings.UseVisualStyleBackColor = true;
            this.btnNotificationSettings.Click += new System.EventHandler(this.btnNotificationSettings_Click);
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
            this.btnBackToMain.Size = new System.Drawing.Size(202, 41);
            this.btnBackToMain.TabIndex = 2;
            this.btnBackToMain.Text = "   Back";
            this.btnBackToMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // pnlDashContext
            // 
            this.pnlDashContext.BackColor = System.Drawing.Color.Transparent;
            this.pnlDashContext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDashContext.BackgroundImage")));
            this.pnlDashContext.Controls.Add(this.comboBox2);
            this.pnlDashContext.Controls.Add(this.comboBox1);
            this.pnlDashContext.Controls.Add(this.btnSaveNewList);
            this.pnlDashContext.Controls.Add(this.label1);
            this.pnlDashContext.Controls.Add(this.lblAvailableEmails);
            this.pnlDashContext.Controls.Add(this.btnMoveAllLeft);
            this.pnlDashContext.Controls.Add(this.btnMoveAllRight);
            this.pnlDashContext.Controls.Add(this.btnMoveLeft);
            this.pnlDashContext.Controls.Add(this.btnMoveRight);
            this.pnlDashContext.Controls.Add(this.lbxNotificationEmails);
            this.pnlDashContext.Controls.Add(this.lbxAvailableEmails);
            this.pnlDashContext.Controls.Add(this.lblNotificationSettings);
            this.pnlDashContext.Controls.Add(this.lblSystemSettings);
            this.pnlDashContext.Controls.Add(this.lblDashDivider);
            this.pnlDashContext.Controls.Add(this.lblDashSubHeader);
            this.pnlDashContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashContext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDashContext.ForeColor = System.Drawing.Color.White;
            this.pnlDashContext.Location = new System.Drawing.Point(213, 76);
            this.pnlDashContext.Name = "pnlDashContext";
            this.pnlDashContext.Size = new System.Drawing.Size(1068, 670);
            this.pnlDashContext.TabIndex = 2;
            // 
            // btnSaveNewList
            // 
            this.btnSaveNewList.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSaveNewList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewList.Location = new System.Drawing.Point(835, 628);
            this.btnSaveNewList.Name = "btnSaveNewList";
            this.btnSaveNewList.Size = new System.Drawing.Size(148, 34);
            this.btnSaveNewList.TabIndex = 20;
            this.btnSaveNewList.Text = "Save New List";
            this.btnSaveNewList.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(704, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Notification Emails:";
            // 
            // lblAvailableEmails
            // 
            this.lblAvailableEmails.AutoSize = true;
            this.lblAvailableEmails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableEmails.Location = new System.Drawing.Point(319, 239);
            this.lblAvailableEmails.Name = "lblAvailableEmails";
            this.lblAvailableEmails.Size = new System.Drawing.Size(142, 19);
            this.lblAvailableEmails.TabIndex = 18;
            this.lblAvailableEmails.Text = "Available Emails:";
            // 
            // btnMoveAllLeft
            // 
            this.btnMoveAllLeft.BackColor = System.Drawing.Color.DarkGreen;
            this.btnMoveAllLeft.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAllLeft.Location = new System.Drawing.Point(623, 508);
            this.btnMoveAllLeft.Name = "btnMoveAllLeft";
            this.btnMoveAllLeft.Size = new System.Drawing.Size(61, 34);
            this.btnMoveAllLeft.TabIndex = 17;
            this.btnMoveAllLeft.Text = "<<";
            this.btnMoveAllLeft.UseVisualStyleBackColor = false;
            // 
            // btnMoveAllRight
            // 
            this.btnMoveAllRight.BackColor = System.Drawing.Color.DarkGreen;
            this.btnMoveAllRight.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAllRight.Location = new System.Drawing.Point(623, 456);
            this.btnMoveAllRight.Name = "btnMoveAllRight";
            this.btnMoveAllRight.Size = new System.Drawing.Size(61, 34);
            this.btnMoveAllRight.TabIndex = 16;
            this.btnMoveAllRight.Text = ">>";
            this.btnMoveAllRight.UseVisualStyleBackColor = false;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.BackColor = System.Drawing.Color.DarkGreen;
            this.btnMoveLeft.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveLeft.Location = new System.Drawing.Point(623, 403);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(61, 34);
            this.btnMoveLeft.TabIndex = 15;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = false;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.BackColor = System.Drawing.Color.DarkGreen;
            this.btnMoveRight.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveRight.Location = new System.Drawing.Point(623, 352);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(61, 34);
            this.btnMoveRight.TabIndex = 14;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = false;
            // 
            // lbxNotificationEmails
            // 
            this.lbxNotificationEmails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNotificationEmails.FormattingEnabled = true;
            this.lbxNotificationEmails.ItemHeight = 21;
            this.lbxNotificationEmails.Location = new System.Drawing.Point(708, 261);
            this.lbxNotificationEmails.Name = "lbxNotificationEmails";
            this.lbxNotificationEmails.Size = new System.Drawing.Size(275, 361);
            this.lbxNotificationEmails.TabIndex = 13;
            // 
            // lbxAvailableEmails
            // 
            this.lbxAvailableEmails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAvailableEmails.FormattingEnabled = true;
            this.lbxAvailableEmails.ItemHeight = 21;
            this.lbxAvailableEmails.Location = new System.Drawing.Point(323, 261);
            this.lbxAvailableEmails.Name = "lbxAvailableEmails";
            this.lbxAvailableEmails.Size = new System.Drawing.Size(275, 361);
            this.lbxAvailableEmails.TabIndex = 12;
            // 
            // lblNotificationSettings
            // 
            this.lblNotificationSettings.AutoSize = true;
            this.lblNotificationSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblNotificationSettings.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationSettings.ForeColor = System.Drawing.Color.White;
            this.lblNotificationSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNotificationSettings.Location = new System.Drawing.Point(42, 162);
            this.lblNotificationSettings.Name = "lblNotificationSettings";
            this.lblNotificationSettings.Size = new System.Drawing.Size(225, 23);
            this.lblNotificationSettings.TabIndex = 11;
            this.lblNotificationSettings.Text = "NOTIFICATION SETTINGS";
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
            this.imgLogo.Size = new System.Drawing.Size(204, 67);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // pnlHeaderMainDash
            // 
            this.pnlHeaderMainDash.Controls.Add(this.lblCompanyName);
            this.pnlHeaderMainDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderMainDash.Location = new System.Drawing.Point(213, 3);
            this.pnlHeaderMainDash.Name = "pnlHeaderMainDash";
            this.pnlHeaderMainDash.Size = new System.Drawing.Size(1068, 67);
            this.pnlHeaderMainDash.TabIndex = 3;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(3, 27);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(139, 23);
            this.lblCompanyName.TabIndex = 3;
            this.lblCompanyName.Text = "La Pieus Aqua";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 27);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "Select Tank:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(46, 261);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 27);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.Text = "Select Sensor:";
            // 
            // frmNotificationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.pnlMainDashLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotificationSettings";
            this.Text = "frmNotificationSettings";
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
        private System.Windows.Forms.Label lblNotificationSettings;
        private System.Windows.Forms.Label lblSystemSettings;
        private System.Windows.Forms.Label lblDashDivider;
        private System.Windows.Forms.Label lblDashSubHeader;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlHeaderMainDash;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnNotificationSettings;
        private System.Windows.Forms.ListBox lbxNotificationEmails;
        private System.Windows.Forms.ListBox lbxAvailableEmails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvailableEmails;
        private System.Windows.Forms.Button btnMoveAllLeft;
        private System.Windows.Forms.Button btnMoveAllRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnSaveNewList;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}