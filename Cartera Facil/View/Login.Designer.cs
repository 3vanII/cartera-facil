namespace Cartera_Facil.View
{
    partial class Login
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
            Guna.UI.WinForms.GunaButton btnSingIn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pictureBoxShowPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxHidePassword = new System.Windows.Forms.PictureBox();
            this.linkLabelCreateUser = new System.Windows.Forms.LinkLabel();
            this.linkLabelRecoverPass = new System.Windows.Forms.LinkLabel();
            this.lblPasswordInvalid = new System.Windows.Forms.Label();
            this.lblUserInvalid = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUser = new Guna.UI.WinForms.GunaTextBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.businessLogo = new Guna.UI.WinForms.GunaPictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            btnSingIn = new Guna.UI.WinForms.GunaButton();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSingIn
            // 
            btnSingIn.AnimationHoverSpeed = 0.07F;
            btnSingIn.AnimationSpeed = 0.03F;
            btnSingIn.BackColor = System.Drawing.Color.Transparent;
            btnSingIn.BaseColor = System.Drawing.Color.IndianRed;
            btnSingIn.BorderColor = System.Drawing.Color.Black;
            btnSingIn.DialogResult = System.Windows.Forms.DialogResult.None;
            btnSingIn.FocusedColor = System.Drawing.Color.Empty;
            btnSingIn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnSingIn.ForeColor = System.Drawing.Color.Black;
            btnSingIn.Image = null;
            btnSingIn.ImageSize = new System.Drawing.Size(20, 20);
            btnSingIn.Location = new System.Drawing.Point(35, 461);
            btnSingIn.Name = "btnSingIn";
            btnSingIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnSingIn.OnHoverBorderColor = System.Drawing.Color.Black;
            btnSingIn.OnHoverForeColor = System.Drawing.Color.White;
            btnSingIn.OnHoverImage = null;
            btnSingIn.OnPressedColor = System.Drawing.Color.Black;
            btnSingIn.Radius = 10;
            btnSingIn.Size = new System.Drawing.Size(315, 45);
            btnSingIn.TabIndex = 11;
            btnSingIn.Text = "SING IN";
            btnSingIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnSingIn.Click += new System.EventHandler(this.btnSingIn_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUser.Controls.Add(this.pictureBoxShowPassword);
            this.pnlUser.Controls.Add(this.pictureBoxHidePassword);
            this.pnlUser.Controls.Add(this.linkLabelCreateUser);
            this.pnlUser.Controls.Add(this.linkLabelRecoverPass);
            this.pnlUser.Controls.Add(btnSingIn);
            this.pnlUser.Controls.Add(this.lblPasswordInvalid);
            this.pnlUser.Controls.Add(this.lblUserInvalid);
            this.pnlUser.Controls.Add(this.txtPassword);
            this.pnlUser.Controls.Add(this.txtUser);
            this.pnlUser.Controls.Add(this.lblSlogan);
            this.pnlUser.Controls.Add(this.businessLogo);
            this.pnlUser.Controls.Add(this.minimizeButton);
            this.pnlUser.Controls.Add(this.closeButton);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(385, 595);
            this.pnlUser.TabIndex = 0;
            this.pnlUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContainer_MouseDown);
            // 
            // pictureBoxShowPassword
            // 
            this.pictureBoxShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(157)))), ((int)(((byte)(241)))));
            this.pictureBoxShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShowPassword.Image")));
            this.pictureBoxShowPassword.Location = new System.Drawing.Point(320, 371);
            this.pictureBoxShowPassword.Name = "pictureBoxShowPassword";
            this.pictureBoxShowPassword.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShowPassword.TabIndex = 15;
            this.pictureBoxShowPassword.TabStop = false;
            this.pictureBoxShowPassword.Click += new System.EventHandler(this.pictureBoxShowPassword_Click);
            // 
            // pictureBoxHidePassword
            // 
            this.pictureBoxHidePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.pictureBoxHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHidePassword.Image")));
            this.pictureBoxHidePassword.Location = new System.Drawing.Point(320, 371);
            this.pictureBoxHidePassword.Name = "pictureBoxHidePassword";
            this.pictureBoxHidePassword.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHidePassword.TabIndex = 14;
            this.pictureBoxHidePassword.TabStop = false;
            this.pictureBoxHidePassword.Visible = false;
            this.pictureBoxHidePassword.Click += new System.EventHandler(this.pictureBoxHidePassword_Click);
            // 
            // linkLabelCreateUser
            // 
            this.linkLabelCreateUser.AutoSize = true;
            this.linkLabelCreateUser.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateUser.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelCreateUser.LinkColor = System.Drawing.Color.Black;
            this.linkLabelCreateUser.Location = new System.Drawing.Point(155, 516);
            this.linkLabelCreateUser.Name = "linkLabelCreateUser";
            this.linkLabelCreateUser.Size = new System.Drawing.Size(76, 20);
            this.linkLabelCreateUser.TabIndex = 13;
            this.linkLabelCreateUser.TabStop = true;
            this.linkLabelCreateUser.Text = "Registrate";
            this.linkLabelCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelCreateUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateUser_LinkClicked);
            this.linkLabelCreateUser.MouseEnter += new System.EventHandler(this.linkLabelCreateUser_MouseEnter);
            this.linkLabelCreateUser.MouseLeave += new System.EventHandler(this.linkLabelCreateUser_MouseLeave);
            // 
            // linkLabelRecoverPass
            // 
            this.linkLabelRecoverPass.AutoSize = true;
            this.linkLabelRecoverPass.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRecoverPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelRecoverPass.LinkColor = System.Drawing.Color.Black;
            this.linkLabelRecoverPass.Location = new System.Drawing.Point(115, 547);
            this.linkLabelRecoverPass.Name = "linkLabelRecoverPass";
            this.linkLabelRecoverPass.Size = new System.Drawing.Size(152, 20);
            this.linkLabelRecoverPass.TabIndex = 12;
            this.linkLabelRecoverPass.TabStop = true;
            this.linkLabelRecoverPass.Text = "Recuperar contraseña";
            this.linkLabelRecoverPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRecoverPass_LinkClicked);
            this.linkLabelRecoverPass.MouseEnter += new System.EventHandler(this.linkLabelRecoverPass_MouseEnter);
            this.linkLabelRecoverPass.MouseLeave += new System.EventHandler(this.linkLabelRecoverPass_MouseLeave);
            // 
            // lblPasswordInvalid
            // 
            this.lblPasswordInvalid.AutoSize = true;
            this.lblPasswordInvalid.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblPasswordInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordInvalid.Location = new System.Drawing.Point(172, 409);
            this.lblPasswordInvalid.Name = "lblPasswordInvalid";
            this.lblPasswordInvalid.Size = new System.Drawing.Size(178, 23);
            this.lblPasswordInvalid.TabIndex = 10;
            this.lblPasswordInvalid.Text = "Contraseña incorrecta";
            this.lblPasswordInvalid.Visible = false;
            // 
            // lblUserInvalid
            // 
            this.lblUserInvalid.AutoSize = true;
            this.lblUserInvalid.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblUserInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblUserInvalid.Location = new System.Drawing.Point(218, 324);
            this.lblUserInvalid.Name = "lblUserInvalid";
            this.lblUserInvalid.Size = new System.Drawing.Size(132, 23);
            this.lblUserInvalid.TabIndex = 9;
            this.lblUserInvalid.Text = "Usuario invalido";
            this.lblUserInvalid.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(35, 361);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 10;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(315, 45);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtUser.BorderColor = System.Drawing.Color.Black;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUser.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(35, 276);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.Radius = 10;
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(315, 45);
            this.txtUser.TabIndex = 6;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.Location = new System.Drawing.Point(36, 212);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(311, 25);
            this.lblSlogan.TabIndex = 4;
            this.lblSlogan.Text = "Créditos fáciles, rápidos y eficientes";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // businessLogo
            // 
            this.businessLogo.BackColor = System.Drawing.Color.Transparent;
            this.businessLogo.BaseColor = System.Drawing.Color.IndianRed;
            this.businessLogo.Location = new System.Drawing.Point(123, 46);
            this.businessLogo.Name = "businessLogo";
            this.businessLogo.Radius = 70;
            this.businessLogo.Size = new System.Drawing.Size(140, 140);
            this.businessLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.businessLogo.TabIndex = 3;
            this.businessLogo.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(320, 6);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(351, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(143, 88);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "gunaButton1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 595);
            this.Controls.Add(this.pnlUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUser;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private Guna.UI.WinForms.GunaPictureBox businessLogo;
        private System.Windows.Forms.Label lblSlogan;
        private Guna.UI.WinForms.GunaTextBox txtUser;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private System.Windows.Forms.Label lblUserInvalid;
        private System.Windows.Forms.Label lblPasswordInvalid;
        private System.Windows.Forms.LinkLabel linkLabelRecoverPass;
        private System.Windows.Forms.LinkLabel linkLabelCreateUser;
        private System.Windows.Forms.PictureBox pictureBoxShowPassword;
        private System.Windows.Forms.PictureBox pictureBoxHidePassword;
    }
}