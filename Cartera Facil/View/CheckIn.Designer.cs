namespace Cartera_Facil.View
{
    partial class CheckIn
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
            Guna.UI.WinForms.GunaButton btnSingUp;
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ComboBoxDocumentsType = new Guna.UI.WinForms.GunaComboBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtIdentificationNumber = new Guna.UI.WinForms.GunaTextBox();
            this.lblConfirmationIdentificationNumber = new System.Windows.Forms.Label();
            this.lblConfirmationEmail = new System.Windows.Forms.Label();
            this.lblConfirmationNames = new System.Windows.Forms.Label();
            this.txtNames = new Guna.UI.WinForms.GunaTextBox();
            this.lblConfirmationSurnames = new System.Windows.Forms.Label();
            this.txtSurnames = new Guna.UI.WinForms.GunaTextBox();
            this.lblIdentificationNumberInvalid = new System.Windows.Forms.Label();
            this.lblEmailInvalid = new System.Windows.Forms.Label();
            btnSingUp = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSingUp
            // 
            btnSingUp.AnimationHoverSpeed = 0.07F;
            btnSingUp.AnimationSpeed = 0.03F;
            btnSingUp.BackColor = System.Drawing.Color.Transparent;
            btnSingUp.BaseColor = System.Drawing.Color.IndianRed;
            btnSingUp.BorderColor = System.Drawing.Color.Black;
            btnSingUp.DialogResult = System.Windows.Forms.DialogResult.None;
            btnSingUp.FocusedColor = System.Drawing.Color.Empty;
            btnSingUp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnSingUp.ForeColor = System.Drawing.Color.Black;
            btnSingUp.Image = null;
            btnSingUp.ImageSize = new System.Drawing.Size(20, 20);
            btnSingUp.Location = new System.Drawing.Point(35, 518);
            btnSingUp.Name = "btnSingUp";
            btnSingUp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnSingUp.OnHoverBorderColor = System.Drawing.Color.Black;
            btnSingUp.OnHoverForeColor = System.Drawing.Color.White;
            btnSingUp.OnHoverImage = null;
            btnSingUp.OnPressedColor = System.Drawing.Color.Black;
            btnSingUp.Radius = 10;
            btnSingUp.Size = new System.Drawing.Size(315, 45);
            btnSingUp.TabIndex = 12;
            btnSingUp.Text = "SING UP";
            btnSingUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnSingUp.Click += new System.EventHandler(this.btnSingUp_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minimizeButton.Location = new System.Drawing.Point(320, 6);
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
            this.closeButton.Location = new System.Drawing.Point(351, 6);
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(108, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 45);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Registrate";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxDocumentsType
            // 
            this.ComboBoxDocumentsType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxDocumentsType.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxDocumentsType.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ComboBoxDocumentsType.BorderColor = System.Drawing.Color.Black;
            this.ComboBoxDocumentsType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxDocumentsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDocumentsType.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxDocumentsType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ComboBoxDocumentsType.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxDocumentsType.FormattingEnabled = true;
            this.ComboBoxDocumentsType.Location = new System.Drawing.Point(35, 118);
            this.ComboBoxDocumentsType.Name = "ComboBoxDocumentsType";
            this.ComboBoxDocumentsType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxDocumentsType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxDocumentsType.Radius = 10;
            this.ComboBoxDocumentsType.Size = new System.Drawing.Size(315, 30);
            this.ComboBoxDocumentsType.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(35, 269);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 10;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(315, 45);
            this.txtEmail.TabIndex = 14;
            // 
            // txtIdentificationNumber
            // 
            this.txtIdentificationNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdentificationNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtIdentificationNumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtIdentificationNumber.BorderColor = System.Drawing.Color.Black;
            this.txtIdentificationNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentificationNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdentificationNumber.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtIdentificationNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdentificationNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificationNumber.Location = new System.Drawing.Point(35, 186);
            this.txtIdentificationNumber.Name = "txtIdentificationNumber";
            this.txtIdentificationNumber.PasswordChar = '\0';
            this.txtIdentificationNumber.Radius = 10;
            this.txtIdentificationNumber.SelectedText = "";
            this.txtIdentificationNumber.Size = new System.Drawing.Size(315, 45);
            this.txtIdentificationNumber.TabIndex = 15;
            // 
            // lblConfirmationIdentificationNumber
            // 
            this.lblConfirmationIdentificationNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationIdentificationNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationIdentificationNumber.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationIdentificationNumber.Location = new System.Drawing.Point(30, 158);
            this.lblConfirmationIdentificationNumber.Name = "lblConfirmationIdentificationNumber";
            this.lblConfirmationIdentificationNumber.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationIdentificationNumber.TabIndex = 31;
            this.lblConfirmationIdentificationNumber.Text = "*";
            this.lblConfirmationIdentificationNumber.Visible = false;
            // 
            // lblConfirmationEmail
            // 
            this.lblConfirmationEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationEmail.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationEmail.Location = new System.Drawing.Point(30, 241);
            this.lblConfirmationEmail.Name = "lblConfirmationEmail";
            this.lblConfirmationEmail.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationEmail.TabIndex = 39;
            this.lblConfirmationEmail.Text = "*";
            this.lblConfirmationEmail.Visible = false;
            // 
            // lblConfirmationNames
            // 
            this.lblConfirmationNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationNames.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationNames.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationNames.Location = new System.Drawing.Point(30, 324);
            this.lblConfirmationNames.Name = "lblConfirmationNames";
            this.lblConfirmationNames.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationNames.TabIndex = 42;
            this.lblConfirmationNames.Text = "*";
            this.lblConfirmationNames.Visible = false;
            // 
            // txtNames
            // 
            this.txtNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNames.BackColor = System.Drawing.Color.Transparent;
            this.txtNames.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNames.BorderColor = System.Drawing.Color.Black;
            this.txtNames.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNames.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNames.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtNames.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNames.Location = new System.Drawing.Point(35, 352);
            this.txtNames.Name = "txtNames";
            this.txtNames.PasswordChar = '\0';
            this.txtNames.Radius = 10;
            this.txtNames.SelectedText = "";
            this.txtNames.Size = new System.Drawing.Size(315, 45);
            this.txtNames.TabIndex = 41;
            // 
            // lblConfirmationSurnames
            // 
            this.lblConfirmationSurnames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationSurnames.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationSurnames.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationSurnames.Location = new System.Drawing.Point(30, 407);
            this.lblConfirmationSurnames.Name = "lblConfirmationSurnames";
            this.lblConfirmationSurnames.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationSurnames.TabIndex = 44;
            this.lblConfirmationSurnames.Text = "*";
            this.lblConfirmationSurnames.Visible = false;
            // 
            // txtSurnames
            // 
            this.txtSurnames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSurnames.BackColor = System.Drawing.Color.Transparent;
            this.txtSurnames.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtSurnames.BorderColor = System.Drawing.Color.Black;
            this.txtSurnames.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurnames.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSurnames.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtSurnames.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSurnames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurnames.Location = new System.Drawing.Point(35, 435);
            this.txtSurnames.Name = "txtSurnames";
            this.txtSurnames.PasswordChar = '\0';
            this.txtSurnames.Radius = 10;
            this.txtSurnames.SelectedText = "";
            this.txtSurnames.Size = new System.Drawing.Size(315, 45);
            this.txtSurnames.TabIndex = 43;
            // 
            // lblIdentificationNumberInvalid
            // 
            this.lblIdentificationNumberInvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdentificationNumberInvalid.AutoSize = true;
            this.lblIdentificationNumberInvalid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificationNumberInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblIdentificationNumberInvalid.Location = new System.Drawing.Point(167, 234);
            this.lblIdentificationNumberInvalid.Name = "lblIdentificationNumberInvalid";
            this.lblIdentificationNumberInvalid.Size = new System.Drawing.Size(183, 17);
            this.lblIdentificationNumberInvalid.TabIndex = 45;
            this.lblIdentificationNumberInvalid.Text = "Número de identidad inválido";
            this.lblIdentificationNumberInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIdentificationNumberInvalid.Visible = false;
            // 
            // lblEmailInvalid
            // 
            this.lblEmailInvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailInvalid.AutoSize = true;
            this.lblEmailInvalid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblEmailInvalid.Location = new System.Drawing.Point(257, 317);
            this.lblEmailInvalid.Name = "lblEmailInvalid";
            this.lblEmailInvalid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmailInvalid.Size = new System.Drawing.Size(88, 17);
            this.lblEmailInvalid.TabIndex = 46;
            this.lblEmailInvalid.Text = "Email inválido";
            this.lblEmailInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmailInvalid.Visible = false;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 595);
            this.Controls.Add(this.lblEmailInvalid);
            this.Controls.Add(this.lblIdentificationNumberInvalid);
            this.Controls.Add(this.lblConfirmationSurnames);
            this.Controls.Add(this.txtSurnames);
            this.Controls.Add(this.lblConfirmationNames);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.lblConfirmationEmail);
            this.Controls.Add(this.lblConfirmationIdentificationNumber);
            this.Controls.Add(this.txtIdentificationNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.ComboBoxDocumentsType);
            this.Controls.Add(btnSingUp);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckIn_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckIn_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckIn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaComboBox ComboBoxDocumentsType;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtIdentificationNumber;
        private System.Windows.Forms.Label lblConfirmationIdentificationNumber;
        private System.Windows.Forms.Label lblConfirmationEmail;
        private System.Windows.Forms.Label lblConfirmationNames;
        private Guna.UI.WinForms.GunaTextBox txtNames;
        private System.Windows.Forms.Label lblConfirmationSurnames;
        private Guna.UI.WinForms.GunaTextBox txtSurnames;
        private System.Windows.Forms.Label lblIdentificationNumberInvalid;
        private System.Windows.Forms.Label lblEmailInvalid;
    }
}