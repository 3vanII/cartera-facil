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
            this.txtUser = new System.Windows.Forms.Panel();
            this.linkLabelCreateUser = new System.Windows.Forms.LinkLabel();
            this.linkLabelRecoverPass = new System.Windows.Forms.LinkLabel();
            this.lblPasswordInvalid = new System.Windows.Forms.Label();
            this.lblUserInvalid = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.tbxUser = new Guna.UI.WinForms.GunaTextBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.businessLogo = new Guna.UI.WinForms.GunaPictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            btnSingIn = new Guna.UI.WinForms.GunaButton();
            this.txtUser.SuspendLayout();
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
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.Controls.Add(this.linkLabelCreateUser);
            this.txtUser.Controls.Add(this.linkLabelRecoverPass);
            this.txtUser.Controls.Add(btnSingIn);
            this.txtUser.Controls.Add(this.lblPasswordInvalid);
            this.txtUser.Controls.Add(this.lblUserInvalid);
            this.txtUser.Controls.Add(this.txtPassword);
            this.txtUser.Controls.Add(this.tbxUser);
            this.txtUser.Controls.Add(this.lblSlogan);
            this.txtUser.Controls.Add(this.businessLogo);
            this.txtUser.Controls.Add(this.minimizeButton);
            this.txtUser.Controls.Add(this.closeButton);
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUser.Location = new System.Drawing.Point(0, 0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(385, 595);
            this.txtUser.TabIndex = 0;
            this.txtUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContainer_MouseDown);
            // 
            // linkLabelCreateUser
            // 
            this.linkLabelCreateUser.AutoSize = true;
            this.linkLabelCreateUser.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateUser.Location = new System.Drawing.Point(155, 519);
            this.linkLabelCreateUser.Name = "linkLabelCreateUser";
            this.linkLabelCreateUser.Size = new System.Drawing.Size(76, 20);
            this.linkLabelCreateUser.TabIndex = 13;
            this.linkLabelCreateUser.TabStop = true;
            this.linkLabelCreateUser.Text = "Registrate";
            this.linkLabelCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelCreateUser.UseMnemonic = false;
            // 
            // linkLabelRecoverPass
            // 
            this.linkLabelRecoverPass.AutoSize = true;
            this.linkLabelRecoverPass.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRecoverPass.Location = new System.Drawing.Point(115, 548);
            this.linkLabelRecoverPass.Name = "linkLabelRecoverPass";
            this.linkLabelRecoverPass.Size = new System.Drawing.Size(152, 20);
            this.linkLabelRecoverPass.TabIndex = 12;
            this.linkLabelRecoverPass.TabStop = true;
            this.linkLabelRecoverPass.Text = "Recuperar contraseña";
            this.linkLabelRecoverPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRecoverPass_LinkClicked);
            // 
            // lblPasswordInvalid
            // 
            this.lblPasswordInvalid.AutoSize = true;
            this.lblPasswordInvalid.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblPasswordInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordInvalid.Location = new System.Drawing.Point(216, 409);
            this.lblPasswordInvalid.Name = "lblPasswordInvalid";
            this.lblPasswordInvalid.Size = new System.Drawing.Size(134, 23);
            this.lblPasswordInvalid.TabIndex = 10;
            this.lblPasswordInvalid.Text = "Password invalid";
            // 
            // lblUserInvalid
            // 
            this.lblUserInvalid.AutoSize = true;
            this.lblUserInvalid.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblUserInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblUserInvalid.Location = new System.Drawing.Point(252, 324);
            this.lblUserInvalid.Name = "lblUserInvalid";
            this.lblUserInvalid.Size = new System.Drawing.Size(98, 23);
            this.lblUserInvalid.TabIndex = 9;
            this.lblUserInvalid.Text = "User invalid";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(35, 361);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Radius = 10;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(315, 45);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "myPassword";
            // 
            // tbxUser
            // 
            this.tbxUser.BackColor = System.Drawing.Color.Transparent;
            this.tbxUser.BaseColor = System.Drawing.Color.White;
            this.tbxUser.BorderColor = System.Drawing.Color.Black;
            this.tbxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUser.FocusedBaseColor = System.Drawing.Color.White;
            this.tbxUser.FocusedBorderColor = System.Drawing.Color.Black;
            this.tbxUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(35, 276);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.PasswordChar = '\0';
            this.tbxUser.Radius = 10;
            this.tbxUser.SelectedText = "";
            this.tbxUser.Size = new System.Drawing.Size(315, 45);
            this.tbxUser.TabIndex = 6;
            this.tbxUser.Text = "myEmail@gmail.com";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.Location = new System.Drawing.Point(29, 213);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(328, 32);
            this.lblSlogan.TabIndex = 4;
            this.lblSlogan.Text = "Easy, fast and efficient credits";
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
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.txtUser.ResumeLayout(false);
            this.txtUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel txtUser;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private Guna.UI.WinForms.GunaPictureBox businessLogo;
        private System.Windows.Forms.Label lblSlogan;
        private Guna.UI.WinForms.GunaTextBox tbxUser;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private System.Windows.Forms.Label lblUserInvalid;
        private System.Windows.Forms.Label lblPasswordInvalid;
        private System.Windows.Forms.LinkLabel linkLabelRecoverPass;
        private System.Windows.Forms.LinkLabel linkLabelCreateUser;
    }
}