namespace Cartera_Facil.View
{
    partial class ConfirmEmail
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
            Guna.UI.WinForms.GunaButton btnConfirm;
            Guna.UI.WinForms.GunaButton btnCancel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmEmail));
            this.lblTitle = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtCode = new Guna.UI.WinForms.GunaTextBox();
            this.lblCodeInvalid = new System.Windows.Forms.Label();
            this.linkLabelResendCode = new System.Windows.Forms.LinkLabel();
            btnConfirm = new Guna.UI.WinForms.GunaButton();
            btnCancel = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.AnimationHoverSpeed = 0.07F;
            btnConfirm.AnimationSpeed = 0.03F;
            btnConfirm.BackColor = System.Drawing.Color.Transparent;
            btnConfirm.BaseColor = System.Drawing.Color.Aqua;
            btnConfirm.BorderColor = System.Drawing.Color.Black;
            btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            btnConfirm.FocusedColor = System.Drawing.Color.Empty;
            btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnConfirm.ForeColor = System.Drawing.Color.Black;
            btnConfirm.Image = null;
            btnConfirm.ImageSize = new System.Drawing.Size(20, 20);
            btnConfirm.Location = new System.Drawing.Point(154, 228);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnConfirm.OnHoverBorderColor = System.Drawing.Color.Black;
            btnConfirm.OnHoverForeColor = System.Drawing.Color.White;
            btnConfirm.OnHoverImage = null;
            btnConfirm.OnPressedColor = System.Drawing.Color.Black;
            btnConfirm.Radius = 10;
            btnConfirm.Size = new System.Drawing.Size(138, 36);
            btnConfirm.TabIndex = 18;
            btnConfirm.Text = "CONFIRMAR";
            btnConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            btnCancel.AnimationHoverSpeed = 0.07F;
            btnCancel.AnimationSpeed = 0.03F;
            btnCancel.BackColor = System.Drawing.Color.Transparent;
            btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            btnCancel.BorderColor = System.Drawing.Color.Black;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            btnCancel.FocusedColor = System.Drawing.Color.Empty;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnCancel.ForeColor = System.Drawing.Color.Black;
            btnCancel.Image = null;
            btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            btnCancel.Location = new System.Drawing.Point(298, 228);
            btnCancel.Name = "btnCancel";
            btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            btnCancel.OnHoverImage = null;
            btnCancel.OnPressedColor = System.Drawing.Color.Black;
            btnCancel.Radius = 10;
            btnCancel.Size = new System.Drawing.Size(138, 36);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "CANCELAR";
            btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(104, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 37);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Validacion de email";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(436, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 9;
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
            this.closeButton.TabIndex = 8;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblInstructions.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions.Location = new System.Drawing.Point(107, 86);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(325, 46);
            this.lblInstructions.TabIndex = 15;
            this.lblInstructions.Text = "Al coreo @correo\r\nse ha enviado un codigo de confirmacion";
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
            this.txtCode.Location = new System.Drawing.Point(111, 135);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.Radius = 10;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(325, 45);
            this.txtCode.TabIndex = 16;
            // 
            // lblCodeInvalid
            // 
            this.lblCodeInvalid.AutoSize = true;
            this.lblCodeInvalid.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblCodeInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblCodeInvalid.Location = new System.Drawing.Point(278, 183);
            this.lblCodeInvalid.Name = "lblCodeInvalid";
            this.lblCodeInvalid.Size = new System.Drawing.Size(158, 23);
            this.lblCodeInvalid.TabIndex = 17;
            this.lblCodeInvalid.Text = "Codigo equivocado";
            this.lblCodeInvalid.Visible = false;
            // 
            // linkLabelResendCode
            // 
            this.linkLabelResendCode.AutoSize = true;
            this.linkLabelResendCode.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.linkLabelResendCode.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelResendCode.LinkColor = System.Drawing.Color.Black;
            this.linkLabelResendCode.Location = new System.Drawing.Point(107, 183);
            this.linkLabelResendCode.Name = "linkLabelResendCode";
            this.linkLabelResendCode.Size = new System.Drawing.Size(132, 23);
            this.linkLabelResendCode.TabIndex = 20;
            this.linkLabelResendCode.TabStop = true;
            this.linkLabelResendCode.Text = "Reenviar codigo";
            this.linkLabelResendCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelResendCode_LinkClicked);
            this.linkLabelResendCode.MouseEnter += new System.EventHandler(this.linkLabelResendCode_MouseEnter);
            this.linkLabelResendCode.MouseLeave += new System.EventHandler(this.linkLabelResendCode_MouseLeave);
            // 
            // ConfirmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 288);
            this.Controls.Add(this.linkLabelResendCode);
            this.Controls.Add(btnCancel);
            this.Controls.Add(btnConfirm);
            this.Controls.Add(this.lblCodeInvalid);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmEmail";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConfirmEmail_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfirmEmail_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label lblInstructions;
        private Guna.UI.WinForms.GunaTextBox txtCode;
        private System.Windows.Forms.Label lblCodeInvalid;
        private System.Windows.Forms.LinkLabel linkLabelResendCode;
    }
}