namespace Cartera_Facil.View
{
    partial class ChangePassword
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
            Guna.UI.WinForms.GunaButton btnChange;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.lblTitle = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.lblCodeInvalid = new System.Windows.Forms.Label();
            this.txtCode = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtConfirmPassword = new Guna.UI.WinForms.GunaTextBox();
            this.lblPasswordsDoNotMatch = new System.Windows.Forms.Label();
            this.pictureBoxShowPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxHidePassword = new System.Windows.Forms.PictureBox();
            this.linkLabelResendCode = new System.Windows.Forms.LinkLabel();
            btnChange = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            btnChange.AnimationHoverSpeed = 0.07F;
            btnChange.AnimationSpeed = 0.03F;
            btnChange.BackColor = System.Drawing.Color.Transparent;
            btnChange.BaseColor = System.Drawing.Color.IndianRed;
            btnChange.BorderColor = System.Drawing.Color.Black;
            btnChange.DialogResult = System.Windows.Forms.DialogResult.None;
            btnChange.FocusedColor = System.Drawing.Color.Empty;
            btnChange.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnChange.ForeColor = System.Drawing.Color.Black;
            btnChange.Image = null;
            btnChange.ImageSize = new System.Drawing.Size(20, 20);
            btnChange.Location = new System.Drawing.Point(253, 336);
            btnChange.Name = "btnChange";
            btnChange.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnChange.OnHoverBorderColor = System.Drawing.Color.Black;
            btnChange.OnHoverForeColor = System.Drawing.Color.White;
            btnChange.OnHoverImage = null;
            btnChange.OnPressedColor = System.Drawing.Color.Black;
            btnChange.Radius = 10;
            btnChange.Size = new System.Drawing.Size(134, 45);
            btnChange.TabIndex = 18;
            btnChange.Text = "CHANGE";
            btnChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(40, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 37);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Cambiar contraseña";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(366, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 9;
            this.minimizeButton.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(401, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 8;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // lblCodeInvalid
            // 
            this.lblCodeInvalid.AutoSize = true;
            this.lblCodeInvalid.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblCodeInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblCodeInvalid.Location = new System.Drawing.Point(258, 153);
            this.lblCodeInvalid.Name = "lblCodeInvalid";
            this.lblCodeInvalid.Size = new System.Drawing.Size(129, 23);
            this.lblCodeInvalid.TabIndex = 14;
            this.lblCodeInvalid.Text = "Codigo invalido";
            this.lblCodeInvalid.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.Transparent;
            this.txtCode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCode.BorderColor = System.Drawing.Color.Black;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCode.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtCode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(47, 105);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.Radius = 10;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(340, 45);
            this.txtCode.TabIndex = 13;
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
            this.txtPassword.Location = new System.Drawing.Point(47, 199);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 10;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(340, 45);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConfirmPassword.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(47, 250);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Radius = 10;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(340, 45);
            this.txtConfirmPassword.TabIndex = 16;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordsDoNotMatch
            // 
            this.lblPasswordsDoNotMatch.AutoSize = true;
            this.lblPasswordsDoNotMatch.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblPasswordsDoNotMatch.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordsDoNotMatch.Location = new System.Drawing.Point(154, 298);
            this.lblPasswordsDoNotMatch.Name = "lblPasswordsDoNotMatch";
            this.lblPasswordsDoNotMatch.Size = new System.Drawing.Size(233, 23);
            this.lblPasswordsDoNotMatch.TabIndex = 17;
            this.lblPasswordsDoNotMatch.Text = "Las contraseñas no coinciden";
            this.lblPasswordsDoNotMatch.Visible = false;
            // 
            // pictureBoxShowPassword
            // 
            this.pictureBoxShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(157)))), ((int)(((byte)(241)))));
            this.pictureBoxShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShowPassword.Image")));
            this.pictureBoxShowPassword.Location = new System.Drawing.Point(353, 260);
            this.pictureBoxShowPassword.Name = "pictureBoxShowPassword";
            this.pictureBoxShowPassword.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShowPassword.TabIndex = 20;
            this.pictureBoxShowPassword.TabStop = false;
            this.pictureBoxShowPassword.Click += new System.EventHandler(this.pictureBoxShowPassword_Click);
            // 
            // pictureBoxHidePassword
            // 
            this.pictureBoxHidePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.pictureBoxHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHidePassword.Image")));
            this.pictureBoxHidePassword.Location = new System.Drawing.Point(353, 260);
            this.pictureBoxHidePassword.Name = "pictureBoxHidePassword";
            this.pictureBoxHidePassword.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHidePassword.TabIndex = 19;
            this.pictureBoxHidePassword.TabStop = false;
            this.pictureBoxHidePassword.Visible = false;
            this.pictureBoxHidePassword.Click += new System.EventHandler(this.pictureBoxHidePassword_Click);
            // 
            // linkLabelResendCode
            // 
            this.linkLabelResendCode.AutoSize = true;
            this.linkLabelResendCode.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.linkLabelResendCode.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelResendCode.LinkColor = System.Drawing.Color.Black;
            this.linkLabelResendCode.Location = new System.Drawing.Point(43, 153);
            this.linkLabelResendCode.Name = "linkLabelResendCode";
            this.linkLabelResendCode.Size = new System.Drawing.Size(132, 23);
            this.linkLabelResendCode.TabIndex = 21;
            this.linkLabelResendCode.TabStop = true;
            this.linkLabelResendCode.Text = "Reenviar codigo";
            this.linkLabelResendCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelResendCode_LinkClicked);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 421);
            this.Controls.Add(this.linkLabelResendCode);
            this.Controls.Add(this.pictureBoxShowPassword);
            this.Controls.Add(this.pictureBoxHidePassword);
            this.Controls.Add(btnChange);
            this.Controls.Add(this.lblPasswordsDoNotMatch);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblCodeInvalid);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChangePassword_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePassword_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label lblCodeInvalid;
        private Guna.UI.WinForms.GunaTextBox txtCode;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblPasswordsDoNotMatch;
        private System.Windows.Forms.PictureBox pictureBoxShowPassword;
        private System.Windows.Forms.PictureBox pictureBoxHidePassword;
        private System.Windows.Forms.LinkLabel linkLabelResendCode;
    }
}