namespace Cartera_Facil.View
{
    partial class RecoverPassword
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
            Guna.UI.WinForms.GunaButton btnRecover;
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.businessLogo = new Guna.UI.WinForms.GunaPictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmailInvalid = new System.Windows.Forms.Label();
            this.tbxEmail = new Guna.UI.WinForms.GunaTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            btnRecover = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecover
            // 
            btnRecover.AnimationHoverSpeed = 0.07F;
            btnRecover.AnimationSpeed = 0.03F;
            btnRecover.BackColor = System.Drawing.Color.Transparent;
            btnRecover.BaseColor = System.Drawing.Color.IndianRed;
            btnRecover.BorderColor = System.Drawing.Color.Black;
            btnRecover.DialogResult = System.Windows.Forms.DialogResult.None;
            btnRecover.FocusedColor = System.Drawing.Color.Empty;
            btnRecover.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnRecover.ForeColor = System.Drawing.Color.Black;
            btnRecover.Image = null;
            btnRecover.ImageSize = new System.Drawing.Size(20, 20);
            btnRecover.Location = new System.Drawing.Point(244, 211);
            btnRecover.Name = "btnRecover";
            btnRecover.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnRecover.OnHoverBorderColor = System.Drawing.Color.Black;
            btnRecover.OnHoverForeColor = System.Drawing.Color.White;
            btnRecover.OnHoverImage = null;
            btnRecover.OnPressedColor = System.Drawing.Color.Black;
            btnRecover.Radius = 10;
            btnRecover.Size = new System.Drawing.Size(134, 45);
            btnRecover.TabIndex = 13;
            btnRecover.Text = "RECOVER";
            btnRecover.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minimizeButton.Location = new System.Drawing.Point(436, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeButton.Location = new System.Drawing.Point(471, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // businessLogo
            // 
            this.businessLogo.BackColor = System.Drawing.Color.Transparent;
            this.businessLogo.BaseColor = System.Drawing.Color.IndianRed;
            this.businessLogo.Location = new System.Drawing.Point(32, 85);
            this.businessLogo.Name = "businessLogo";
            this.businessLogo.Radius = 50;
            this.businessLogo.Size = new System.Drawing.Size(100, 100);
            this.businessLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.businessLogo.TabIndex = 5;
            this.businessLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(184, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 37);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Recover password";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailInvalid
            // 
            this.lblEmailInvalid.AutoSize = true;
            this.lblEmailInvalid.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblEmailInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblEmailInvalid.Location = new System.Drawing.Point(375, 188);
            this.lblEmailInvalid.Name = "lblEmailInvalid";
            this.lblEmailInvalid.Size = new System.Drawing.Size(105, 23);
            this.lblEmailInvalid.TabIndex = 12;
            this.lblEmailInvalid.Text = "Email invalid";
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbxEmail.BaseColor = System.Drawing.Color.White;
            this.tbxEmail.BorderColor = System.Drawing.Color.Black;
            this.tbxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.tbxEmail.FocusedBorderColor = System.Drawing.Color.Black;
            this.tbxEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(158, 140);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PasswordChar = '\0';
            this.tbxEmail.Radius = 10;
            this.tbxEmail.SelectedText = "";
            this.tbxEmail.Size = new System.Drawing.Size(315, 45);
            this.tbxEmail.TabIndex = 11;
            this.tbxEmail.Text = "myEmail@gmail.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(153, 109);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 28);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblInstructions.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions.Location = new System.Drawing.Point(154, 76);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(269, 19);
            this.lblInstructions.TabIndex = 14;
            this.lblInstructions.Text = "A new password will be sent to your email.\u2028";
            // 
            // RecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 282);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(btnRecover);
            this.Controls.Add(this.lblEmailInvalid);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.businessLogo);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoverPassword";
            this.Text = "RecoverPassword";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RecoverPassword_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecoverPassword_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox closeButton;
        private Guna.UI.WinForms.GunaPictureBox businessLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmailInvalid;
        private Guna.UI.WinForms.GunaTextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblInstructions;
    }
}