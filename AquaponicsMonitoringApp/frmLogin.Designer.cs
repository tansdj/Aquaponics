namespace AquaponicsMonitoringApp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlHeaderLogin = new System.Windows.Forms.Panel();
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.btnCloseLogin = new System.Windows.Forms.Button();
            this.pnlLogin_Register = new System.Windows.Forms.Panel();
            this.pnlRegisterDetails = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlSecurityQuestion = new System.Windows.Forms.Panel();
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.pnlNotificationDetails = new System.Windows.Forms.Panel();
            this.txtConfirmEmail = new System.Windows.Forms.TextBox();
            this.lblNotificationDetails = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblConfirmEmail = new System.Windows.Forms.Label();
            this.lblEnterEmail = new System.Windows.Forms.Label();
            this.lblLoginInformation = new System.Windows.Forms.Label();
            this.pnlRegisterLoginDetails = new System.Windows.Forms.Panel();
            this.txtRePasswordRegister = new System.Windows.Forms.TextBox();
            this.lblReEnterPassword = new System.Windows.Forms.Label();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.lblEnterUsername = new System.Windows.Forms.Label();
            this.txtPasswordRegister = new System.Windows.Forms.TextBox();
            this.txtUsernameRegister = new System.Windows.Forms.TextBox();
            this.lblEnterNewUser = new System.Windows.Forms.Label();
            this.pnlLoginDetails = new System.Windows.Forms.Panel();
            this.lblEnterLoginDetails = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.btnREGISTERform = new System.Windows.Forms.Button();
            this.btnLOGINform = new System.Windows.Forms.Button();
            this.pnlHeaderLogin.SuspendLayout();
            this.pnlLogin_Register.SuspendLayout();
            this.pnlRegisterDetails.SuspendLayout();
            this.pnlSecurityQuestion.SuspendLayout();
            this.pnlNotificationDetails.SuspendLayout();
            this.pnlRegisterLoginDetails.SuspendLayout();
            this.pnlLoginDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderLogin
            // 
            this.pnlHeaderLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.pnlHeaderLogin.Controls.Add(this.lblLoginHeader);
            this.pnlHeaderLogin.Controls.Add(this.btnCloseLogin);
            this.pnlHeaderLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderLogin.Name = "pnlHeaderLogin";
            this.pnlHeaderLogin.Size = new System.Drawing.Size(486, 58);
            this.pnlHeaderLogin.TabIndex = 4;
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.AutoSize = true;
            this.lblLoginHeader.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeader.ForeColor = System.Drawing.Color.White;
            this.lblLoginHeader.Location = new System.Drawing.Point(7, 15);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(160, 23);
            this.lblLoginHeader.TabIndex = 6;
            this.lblLoginHeader.Text = "Login or Register";
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCloseLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseLogin.BackgroundImage")));
            this.btnCloseLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseLogin.FlatAppearance.BorderSize = 0;
            this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLogin.Location = new System.Drawing.Point(444, 11);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Size = new System.Drawing.Size(39, 39);
            this.btnCloseLogin.TabIndex = 5;
            this.btnCloseLogin.UseVisualStyleBackColor = true;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // pnlLogin_Register
            // 
            this.pnlLogin_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin_Register.Controls.Add(this.pnlRegisterDetails);
            this.pnlLogin_Register.Controls.Add(this.pnlLoginDetails);
            this.pnlLogin_Register.Controls.Add(this.btnREGISTERform);
            this.pnlLogin_Register.Controls.Add(this.btnLOGINform);
            this.pnlLogin_Register.Location = new System.Drawing.Point(63, 93);
            this.pnlLogin_Register.Name = "pnlLogin_Register";
            this.pnlLogin_Register.Size = new System.Drawing.Size(359, 468);
            this.pnlLogin_Register.TabIndex = 5;
            // 
            // pnlRegisterDetails
            // 
            this.pnlRegisterDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegisterDetails.Controls.Add(this.btnRegister);
            this.pnlRegisterDetails.Controls.Add(this.pnlSecurityQuestion);
            this.pnlRegisterDetails.Controls.Add(this.pnlNotificationDetails);
            this.pnlRegisterDetails.Controls.Add(this.lblLoginInformation);
            this.pnlRegisterDetails.Controls.Add(this.pnlRegisterLoginDetails);
            this.pnlRegisterDetails.Controls.Add(this.lblEnterNewUser);
            this.pnlRegisterDetails.Location = new System.Drawing.Point(0, 59);
            this.pnlRegisterDetails.Name = "pnlRegisterDetails";
            this.pnlRegisterDetails.Size = new System.Drawing.Size(359, 394);
            this.pnlRegisterDetails.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(221, 358);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(127, 33);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // pnlSecurityQuestion
            // 
            this.pnlSecurityQuestion.Controls.Add(this.cmbSecurityQuestion);
            this.pnlSecurityQuestion.Controls.Add(this.lblSecurityQuestion);
            this.pnlSecurityQuestion.Controls.Add(this.txtSecurityAnswer);
            this.pnlSecurityQuestion.Location = new System.Drawing.Point(0, 291);
            this.pnlSecurityQuestion.Name = "pnlSecurityQuestion";
            this.pnlSecurityQuestion.Size = new System.Drawing.Size(359, 64);
            this.pnlSecurityQuestion.TabIndex = 16;
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecurityQuestion.FormattingEnabled = true;
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(6, 24);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(172, 25);
            this.cmbSecurityQuestion.TabIndex = 18;
            this.cmbSecurityQuestion.Text = "Choose A Question:";
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSecurityQuestion.Location = new System.Drawing.Point(3, -4);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(139, 18);
            this.lblSecurityQuestion.TabIndex = 17;
            this.lblSecurityQuestion.Text = "Security Question";
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecurityAnswer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityAnswer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSecurityAnswer.Location = new System.Drawing.Point(193, 24);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(163, 23);
            this.txtSecurityAnswer.TabIndex = 14;
            this.txtSecurityAnswer.Text = "Enter Answer";
            this.txtSecurityAnswer.Enter += new System.EventHandler(this.txtSecurityAnswer_Enter);
            this.txtSecurityAnswer.Leave += new System.EventHandler(this.txtSecurityAnswer_Leave);
            // 
            // pnlNotificationDetails
            // 
            this.pnlNotificationDetails.Controls.Add(this.txtConfirmEmail);
            this.pnlNotificationDetails.Controls.Add(this.lblNotificationDetails);
            this.pnlNotificationDetails.Controls.Add(this.txtEmail);
            this.pnlNotificationDetails.Controls.Add(this.lblConfirmEmail);
            this.pnlNotificationDetails.Controls.Add(this.lblEnterEmail);
            this.pnlNotificationDetails.Location = new System.Drawing.Point(0, 190);
            this.pnlNotificationDetails.Name = "pnlNotificationDetails";
            this.pnlNotificationDetails.Size = new System.Drawing.Size(359, 80);
            this.pnlNotificationDetails.TabIndex = 15;
            // 
            // txtConfirmEmail
            // 
            this.txtConfirmEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtConfirmEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmEmail.ForeColor = System.Drawing.Color.White;
            this.txtConfirmEmail.Location = new System.Drawing.Point(159, 45);
            this.txtConfirmEmail.Name = "txtConfirmEmail";
            this.txtConfirmEmail.Size = new System.Drawing.Size(189, 26);
            this.txtConfirmEmail.TabIndex = 15;
            // 
            // lblNotificationDetails
            // 
            this.lblNotificationDetails.AutoSize = true;
            this.lblNotificationDetails.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNotificationDetails.Location = new System.Drawing.Point(3, -4);
            this.lblNotificationDetails.Name = "lblNotificationDetails";
            this.lblNotificationDetails.Size = new System.Drawing.Size(150, 18);
            this.lblNotificationDetails.TabIndex = 16;
            this.lblNotificationDetails.Text = "Notification Details";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(159, 13);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // lblConfirmEmail
            // 
            this.lblConfirmEmail.AutoSize = true;
            this.lblConfirmEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblConfirmEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmEmail.ForeColor = System.Drawing.Color.White;
            this.lblConfirmEmail.Location = new System.Drawing.Point(23, 51);
            this.lblConfirmEmail.Name = "lblConfirmEmail";
            this.lblConfirmEmail.Size = new System.Drawing.Size(111, 20);
            this.lblConfirmEmail.TabIndex = 1;
            this.lblConfirmEmail.Text = "Confirm Email:";
            // 
            // lblEnterEmail
            // 
            this.lblEnterEmail.AutoSize = true;
            this.lblEnterEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterEmail.ForeColor = System.Drawing.Color.White;
            this.lblEnterEmail.Location = new System.Drawing.Point(23, 19);
            this.lblEnterEmail.Name = "lblEnterEmail";
            this.lblEnterEmail.Size = new System.Drawing.Size(91, 20);
            this.lblEnterEmail.TabIndex = 0;
            this.lblEnterEmail.Text = "Enter Email:";
            // 
            // lblLoginInformation
            // 
            this.lblLoginInformation.AutoSize = true;
            this.lblLoginInformation.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLoginInformation.Location = new System.Drawing.Point(3, 31);
            this.lblLoginInformation.Name = "lblLoginInformation";
            this.lblLoginInformation.Size = new System.Drawing.Size(136, 18);
            this.lblLoginInformation.TabIndex = 14;
            this.lblLoginInformation.Text = "Login Information";
            // 
            // pnlRegisterLoginDetails
            // 
            this.pnlRegisterLoginDetails.Controls.Add(this.txtRePasswordRegister);
            this.pnlRegisterLoginDetails.Controls.Add(this.lblReEnterPassword);
            this.pnlRegisterLoginDetails.Controls.Add(this.lblEnterPassword);
            this.pnlRegisterLoginDetails.Controls.Add(this.lblEnterUsername);
            this.pnlRegisterLoginDetails.Controls.Add(this.txtPasswordRegister);
            this.pnlRegisterLoginDetails.Controls.Add(this.txtUsernameRegister);
            this.pnlRegisterLoginDetails.Location = new System.Drawing.Point(0, 38);
            this.pnlRegisterLoginDetails.Name = "pnlRegisterLoginDetails";
            this.pnlRegisterLoginDetails.Size = new System.Drawing.Size(359, 137);
            this.pnlRegisterLoginDetails.TabIndex = 8;
            // 
            // txtRePasswordRegister
            // 
            this.txtRePasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtRePasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRePasswordRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePasswordRegister.ForeColor = System.Drawing.Color.White;
            this.txtRePasswordRegister.Location = new System.Drawing.Point(185, 100);
            this.txtRePasswordRegister.Name = "txtRePasswordRegister";
            this.txtRePasswordRegister.PasswordChar = '•';
            this.txtRePasswordRegister.Size = new System.Drawing.Size(163, 26);
            this.txtRePasswordRegister.TabIndex = 13;
            // 
            // lblReEnterPassword
            // 
            this.lblReEnterPassword.AutoSize = true;
            this.lblReEnterPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReEnterPassword.ForeColor = System.Drawing.Color.White;
            this.lblReEnterPassword.Location = new System.Drawing.Point(24, 102);
            this.lblReEnterPassword.Name = "lblReEnterPassword";
            this.lblReEnterPassword.Size = new System.Drawing.Size(150, 20);
            this.lblReEnterPassword.TabIndex = 12;
            this.lblReEnterPassword.Text = "Re-enter Password:";
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPassword.ForeColor = System.Drawing.Color.White;
            this.lblEnterPassword.Location = new System.Drawing.Point(24, 61);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(124, 20);
            this.lblEnterPassword.TabIndex = 11;
            this.lblEnterPassword.Text = "Enter Password:";
            // 
            // lblEnterUsername
            // 
            this.lblEnterUsername.AutoSize = true;
            this.lblEnterUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterUsername.ForeColor = System.Drawing.Color.White;
            this.lblEnterUsername.Location = new System.Drawing.Point(24, 19);
            this.lblEnterUsername.Name = "lblEnterUsername";
            this.lblEnterUsername.Size = new System.Drawing.Size(128, 20);
            this.lblEnterUsername.TabIndex = 10;
            this.lblEnterUsername.Text = "Enter Username:";
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordRegister.ForeColor = System.Drawing.Color.White;
            this.txtPasswordRegister.Location = new System.Drawing.Point(185, 59);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.PasswordChar = '•';
            this.txtPasswordRegister.Size = new System.Drawing.Size(163, 26);
            this.txtPasswordRegister.TabIndex = 9;
            // 
            // txtUsernameRegister
            // 
            this.txtUsernameRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtUsernameRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameRegister.ForeColor = System.Drawing.Color.White;
            this.txtUsernameRegister.Location = new System.Drawing.Point(185, 17);
            this.txtUsernameRegister.Name = "txtUsernameRegister";
            this.txtUsernameRegister.Size = new System.Drawing.Size(163, 26);
            this.txtUsernameRegister.TabIndex = 8;
            // 
            // lblEnterNewUser
            // 
            this.lblEnterNewUser.AutoSize = true;
            this.lblEnterNewUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNewUser.ForeColor = System.Drawing.Color.White;
            this.lblEnterNewUser.Location = new System.Drawing.Point(3, 0);
            this.lblEnterNewUser.Name = "lblEnterNewUser";
            this.lblEnterNewUser.Size = new System.Drawing.Size(124, 18);
            this.lblEnterNewUser.TabIndex = 5;
            this.lblEnterNewUser.Text = "Enter New User:";
            // 
            // pnlLoginDetails
            // 
            this.pnlLoginDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoginDetails.Controls.Add(this.lblEnterLoginDetails);
            this.pnlLoginDetails.Controls.Add(this.btnLogin);
            this.pnlLoginDetails.Controls.Add(this.lblPasswordLogin);
            this.pnlLoginDetails.Controls.Add(this.lblUsernameLogin);
            this.pnlLoginDetails.Controls.Add(this.txtPasswordLogin);
            this.pnlLoginDetails.Controls.Add(this.txtUsernameLogin);
            this.pnlLoginDetails.Location = new System.Drawing.Point(0, 133);
            this.pnlLoginDetails.Name = "pnlLoginDetails";
            this.pnlLoginDetails.Size = new System.Drawing.Size(359, 246);
            this.pnlLoginDetails.TabIndex = 2;
            this.pnlLoginDetails.Visible = false;
            // 
            // lblEnterLoginDetails
            // 
            this.lblEnterLoginDetails.AutoSize = true;
            this.lblEnterLoginDetails.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterLoginDetails.ForeColor = System.Drawing.Color.White;
            this.lblEnterLoginDetails.Location = new System.Drawing.Point(25, 26);
            this.lblEnterLoginDetails.Name = "lblEnterLoginDetails";
            this.lblEnterLoginDetails.Size = new System.Drawing.Size(148, 18);
            this.lblEnterLoginDetails.TabIndex = 5;
            this.lblEnterLoginDetails.Text = "Enter Login Details:";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(185, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.lblPasswordLogin.Location = new System.Drawing.Point(42, 130);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(86, 21);
            this.lblPasswordLogin.TabIndex = 3;
            this.lblPasswordLogin.Text = "Password:";
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameLogin.ForeColor = System.Drawing.Color.White;
            this.lblUsernameLogin.Location = new System.Drawing.Point(42, 70);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(92, 21);
            this.lblUsernameLogin.TabIndex = 2;
            this.lblUsernameLogin.Text = "Username:";
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.txtPasswordLogin.Location = new System.Drawing.Point(172, 128);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '•';
            this.txtPasswordLogin.Size = new System.Drawing.Size(163, 27);
            this.txtPasswordLogin.TabIndex = 1;
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtUsernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameLogin.ForeColor = System.Drawing.Color.White;
            this.txtUsernameLogin.Location = new System.Drawing.Point(172, 68);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(163, 27);
            this.txtUsernameLogin.TabIndex = 0;
            // 
            // btnREGISTERform
            // 
            this.btnREGISTERform.BackColor = System.Drawing.Color.Transparent;
            this.btnREGISTERform.FlatAppearance.BorderSize = 0;
            this.btnREGISTERform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnREGISTERform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREGISTERform.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREGISTERform.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnREGISTERform.Image = ((System.Drawing.Image)(resources.GetObject("btnREGISTERform.Image")));
            this.btnREGISTERform.Location = new System.Drawing.Point(210, 15);
            this.btnREGISTERform.Name = "btnREGISTERform";
            this.btnREGISTERform.Size = new System.Drawing.Size(115, 38);
            this.btnREGISTERform.TabIndex = 1;
            this.btnREGISTERform.Text = " REGISTER";
            this.btnREGISTERform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnREGISTERform.UseVisualStyleBackColor = false;
            this.btnREGISTERform.Click += new System.EventHandler(this.btnREGISTER_Click);
            // 
            // btnLOGINform
            // 
            this.btnLOGINform.BackColor = System.Drawing.Color.Transparent;
            this.btnLOGINform.FlatAppearance.BorderSize = 0;
            this.btnLOGINform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLOGINform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOGINform.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGINform.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLOGINform.Image = ((System.Drawing.Image)(resources.GetObject("btnLOGINform.Image")));
            this.btnLOGINform.Location = new System.Drawing.Point(27, 15);
            this.btnLOGINform.Name = "btnLOGINform";
            this.btnLOGINform.Size = new System.Drawing.Size(107, 38);
            this.btnLOGINform.TabIndex = 0;
            this.btnLOGINform.Text = " LOGIN";
            this.btnLOGINform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLOGINform.UseVisualStyleBackColor = false;
            this.btnLOGINform.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(486, 594);
            this.Controls.Add(this.pnlLogin_Register);
            this.Controls.Add(this.pnlHeaderLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.pnlHeaderLogin.ResumeLayout(false);
            this.pnlHeaderLogin.PerformLayout();
            this.pnlLogin_Register.ResumeLayout(false);
            this.pnlRegisterDetails.ResumeLayout(false);
            this.pnlRegisterDetails.PerformLayout();
            this.pnlSecurityQuestion.ResumeLayout(false);
            this.pnlSecurityQuestion.PerformLayout();
            this.pnlNotificationDetails.ResumeLayout(false);
            this.pnlNotificationDetails.PerformLayout();
            this.pnlRegisterLoginDetails.ResumeLayout(false);
            this.pnlRegisterLoginDetails.PerformLayout();
            this.pnlLoginDetails.ResumeLayout(false);
            this.pnlLoginDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeaderLogin;
        private System.Windows.Forms.Button btnCloseLogin;
        private System.Windows.Forms.Panel pnlLogin_Register;
        private System.Windows.Forms.Button btnLOGINform;
        private System.Windows.Forms.Button btnREGISTERform;
        private System.Windows.Forms.Panel pnlLoginDetails;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Label lblEnterLoginDetails;
        private System.Windows.Forms.Label lblLoginHeader;
        private System.Windows.Forms.Panel pnlRegisterDetails;
        private System.Windows.Forms.Label lblNotificationDetails;
        private System.Windows.Forms.Panel pnlNotificationDetails;
        private System.Windows.Forms.TextBox txtConfirmEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblConfirmEmail;
        private System.Windows.Forms.Label lblEnterEmail;
        private System.Windows.Forms.Label lblLoginInformation;
        private System.Windows.Forms.Panel pnlRegisterLoginDetails;
        private System.Windows.Forms.TextBox txtRePasswordRegister;
        private System.Windows.Forms.Label lblReEnterPassword;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.Label lblEnterUsername;
        private System.Windows.Forms.TextBox txtPasswordRegister;
        private System.Windows.Forms.TextBox txtUsernameRegister;
        private System.Windows.Forms.Label lblEnterNewUser;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlSecurityQuestion;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
    }
}