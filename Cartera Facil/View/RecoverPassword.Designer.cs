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
            Guna.UI.WinForms.GunaButton btnSend;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverPassword));
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmailInvalid = new System.Windows.Forms.Label();
            this.tbxEmail = new Guna.UI.WinForms.GunaTextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblConfirmationEmail = new System.Windows.Forms.Label();
            btnSend = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.AnimationHoverSpeed = 0.07F;
            btnSend.AnimationSpeed = 0.03F;
            btnSend.BackColor = System.Drawing.Color.Transparent;
            btnSend.BaseColor = System.Drawing.Color.IndianRed;
            btnSend.BorderColor = System.Drawing.Color.Black;
            btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            btnSend.FocusedColor = System.Drawing.Color.Empty;
            btnSend.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnSend.ForeColor = System.Drawing.Color.Black;
            btnSend.Image = null;
            btnSend.ImageSize = new System.Drawing.Size(20, 20);
            btnSend.Location = new System.Drawing.Point(289, 246);
            btnSend.Name = "btnSend";
            btnSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnSend.OnHoverBorderColor = System.Drawing.Color.Black;
            btnSend.OnHoverForeColor = System.Drawing.Color.White;
            btnSend.OnHoverImage = null;
            btnSend.OnPressedColor = System.Drawing.Color.Black;
            btnSend.Radius = 10;
            btnSend.Size = new System.Drawing.Size(134, 45);
            btnSend.TabIndex = 13;
            btnSend.Text = "SEND";
            btnSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnSend.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
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
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(471, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(76, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 37);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Recuperar contraseña";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailInvalid
            // 
            this.lblEmailInvalid.AutoSize = true;
            this.lblEmailInvalid.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblEmailInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblEmailInvalid.Location = new System.Drawing.Point(308, 217);
            this.lblEmailInvalid.Name = "lblEmailInvalid";
            this.lblEmailInvalid.Size = new System.Drawing.Size(115, 23);
            this.lblEmailInvalid.TabIndex = 12;
            this.lblEmailInvalid.Text = "Email invalido";
            this.lblEmailInvalid.Visible = false;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbxEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbxEmail.BorderColor = System.Drawing.Color.Black;
            this.tbxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.tbxEmail.FocusedBorderColor = System.Drawing.Color.Black;
            this.tbxEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(83, 169);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PasswordChar = '\0';
            this.tbxEmail.Radius = 10;
            this.tbxEmail.SelectedText = "";
            this.tbxEmail.Size = new System.Drawing.Size(340, 45);
            this.tbxEmail.TabIndex = 11;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblInstructions.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions.Location = new System.Drawing.Point(79, 89);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(359, 69);
            this.lblInstructions.TabIndex = 14;
            this.lblInstructions.Text = "Se enviará a su correo electrónico un código  \r\nde seguridad que permitirá el cam" +
    "bio de \r\ncontraseña.";
            // 
            // lblConfirmationEmail
            // 
            this.lblConfirmationEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationEmail.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationEmail.Location = new System.Drawing.Point(405, 141);
            this.lblConfirmationEmail.Name = "lblConfirmationEmail";
            this.lblConfirmationEmail.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationEmail.TabIndex = 39;
            this.lblConfirmationEmail.Text = "*";
            this.lblConfirmationEmail.Visible = false;
            // 
            // RecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 336);
            this.Controls.Add(this.lblConfirmationEmail);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(btnSend);
            this.Controls.Add(this.lblEmailInvalid);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoverPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoverPassword";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RecoverPassword_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecoverPassword_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmailInvalid;
        private Guna.UI.WinForms.GunaTextBox tbxEmail;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblConfirmationEmail;
    }
}