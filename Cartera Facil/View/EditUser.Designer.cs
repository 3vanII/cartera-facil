namespace Cartera_Facil.View
{
    partial class EditUser
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
            Guna.UI.WinForms.GunaButton btnCancel;
            Guna.UI.WinForms.GunaButton btnUpdate;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.ComboBoxCargo = new Guna.UI.WinForms.GunaComboBox();
            this.lblEmailInvalid = new System.Windows.Forms.Label();
            this.lblIdentificationNumberInvalid = new System.Windows.Forms.Label();
            this.lblConfirmationEmail = new System.Windows.Forms.Label();
            this.lblConfirmationPhone = new System.Windows.Forms.Label();
            this.lblConfirmationResidenceAddress = new System.Windows.Forms.Label();
            this.lblConfirmationSurnames = new System.Windows.Forms.Label();
            this.lblConfirmationNames = new System.Windows.Forms.Label();
            this.lblConfirmationIdentificationNumber = new System.Windows.Forms.Label();
            this.ComboBoxRol = new Guna.UI.WinForms.GunaComboBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.txtResidenceAddress = new Guna.UI.WinForms.GunaTextBox();
            this.ComboBoxCity = new Guna.UI.WinForms.GunaComboBox();
            this.ComboBoxDepartaments = new Guna.UI.WinForms.GunaComboBox();
            this.txtSurnames = new Guna.UI.WinForms.GunaTextBox();
            this.txtNames = new Guna.UI.WinForms.GunaTextBox();
            this.txtIdentificationNumber = new Guna.UI.WinForms.GunaTextBox();
            this.ComboBoxDocumentsType = new Guna.UI.WinForms.GunaComboBox();
            this.ptbhoto = new Guna.UI.WinForms.GunaPictureBox();
            btnCancel = new Guna.UI.WinForms.GunaButton();
            btnUpdate = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.AnimationHoverSpeed = 0.07F;
            btnCancel.AnimationSpeed = 0.03F;
            btnCancel.BackColor = System.Drawing.Color.Transparent;
            btnCancel.BaseColor = System.Drawing.Color.LightCoral;
            btnCancel.BorderColor = System.Drawing.Color.Black;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            btnCancel.FocusedColor = System.Drawing.Color.Empty;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnCancel.ForeColor = System.Drawing.Color.Black;
            btnCancel.Image = null;
            btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            btnCancel.Location = new System.Drawing.Point(748, 436);
            btnCancel.Name = "btnCancel";
            btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            btnCancel.OnHoverImage = null;
            btnCancel.OnPressedColor = System.Drawing.Color.Black;
            btnCancel.Radius = 10;
            btnCancel.Size = new System.Drawing.Size(99, 37);
            btnCancel.TabIndex = 81;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUpdate.AnimationHoverSpeed = 0.07F;
            btnUpdate.AnimationSpeed = 0.03F;
            btnUpdate.BackColor = System.Drawing.Color.Transparent;
            btnUpdate.BaseColor = System.Drawing.Color.LightGreen;
            btnUpdate.BorderColor = System.Drawing.Color.Black;
            btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnUpdate.ForeColor = System.Drawing.Color.Black;
            btnUpdate.Image = null;
            btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            btnUpdate.Location = new System.Drawing.Point(619, 436);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            btnUpdate.OnHoverImage = null;
            btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            btnUpdate.Radius = 10;
            btnUpdate.Size = new System.Drawing.Size(97, 37);
            btnUpdate.TabIndex = 80;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ComboBoxCargo
            // 
            this.ComboBoxCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxCargo.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxCargo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ComboBoxCargo.BorderColor = System.Drawing.Color.Black;
            this.ComboBoxCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCargo.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxCargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCargo.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxCargo.FormattingEnabled = true;
            this.ComboBoxCargo.Location = new System.Drawing.Point(85, 443);
            this.ComboBoxCargo.Name = "ComboBoxCargo";
            this.ComboBoxCargo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxCargo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxCargo.Radius = 10;
            this.ComboBoxCargo.Size = new System.Drawing.Size(230, 30);
            this.ComboBoxCargo.TabIndex = 90;
            // 
            // lblEmailInvalid
            // 
            this.lblEmailInvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailInvalid.AutoSize = true;
            this.lblEmailInvalid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblEmailInvalid.Location = new System.Drawing.Point(762, 304);
            this.lblEmailInvalid.Name = "lblEmailInvalid";
            this.lblEmailInvalid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmailInvalid.Size = new System.Drawing.Size(88, 17);
            this.lblEmailInvalid.TabIndex = 89;
            this.lblEmailInvalid.Text = "Email inválido";
            this.lblEmailInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmailInvalid.Visible = false;
            // 
            // lblIdentificationNumberInvalid
            // 
            this.lblIdentificationNumberInvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdentificationNumberInvalid.AutoSize = true;
            this.lblIdentificationNumberInvalid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificationNumberInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblIdentificationNumberInvalid.Location = new System.Drawing.Point(665, 128);
            this.lblIdentificationNumberInvalid.Name = "lblIdentificationNumberInvalid";
            this.lblIdentificationNumberInvalid.Size = new System.Drawing.Size(183, 17);
            this.lblIdentificationNumberInvalid.TabIndex = 88;
            this.lblIdentificationNumberInvalid.Text = "Número de identidad inválido";
            this.lblIdentificationNumberInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIdentificationNumberInvalid.Visible = false;
            // 
            // lblConfirmationEmail
            // 
            this.lblConfirmationEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationEmail.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationEmail.Location = new System.Drawing.Point(831, 239);
            this.lblConfirmationEmail.Name = "lblConfirmationEmail";
            this.lblConfirmationEmail.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationEmail.TabIndex = 87;
            this.lblConfirmationEmail.Text = "*";
            this.lblConfirmationEmail.Visible = false;
            // 
            // lblConfirmationPhone
            // 
            this.lblConfirmationPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationPhone.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationPhone.Location = new System.Drawing.Point(562, 241);
            this.lblConfirmationPhone.Name = "lblConfirmationPhone";
            this.lblConfirmationPhone.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationPhone.TabIndex = 86;
            this.lblConfirmationPhone.Text = "*";
            this.lblConfirmationPhone.Visible = false;
            // 
            // lblConfirmationResidenceAddress
            // 
            this.lblConfirmationResidenceAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationResidenceAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationResidenceAddress.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationResidenceAddress.Location = new System.Drawing.Point(829, 327);
            this.lblConfirmationResidenceAddress.Name = "lblConfirmationResidenceAddress";
            this.lblConfirmationResidenceAddress.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationResidenceAddress.TabIndex = 85;
            this.lblConfirmationResidenceAddress.Text = "*";
            this.lblConfirmationResidenceAddress.Visible = false;
            // 
            // lblConfirmationSurnames
            // 
            this.lblConfirmationSurnames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationSurnames.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationSurnames.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationSurnames.Location = new System.Drawing.Point(829, 152);
            this.lblConfirmationSurnames.Name = "lblConfirmationSurnames";
            this.lblConfirmationSurnames.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationSurnames.TabIndex = 84;
            this.lblConfirmationSurnames.Text = "*";
            this.lblConfirmationSurnames.Visible = false;
            // 
            // lblConfirmationNames
            // 
            this.lblConfirmationNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationNames.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationNames.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationNames.Location = new System.Drawing.Point(562, 153);
            this.lblConfirmationNames.Name = "lblConfirmationNames";
            this.lblConfirmationNames.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationNames.TabIndex = 83;
            this.lblConfirmationNames.Text = "*";
            this.lblConfirmationNames.Visible = false;
            // 
            // lblConfirmationIdentificationNumber
            // 
            this.lblConfirmationIdentificationNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationIdentificationNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationIdentificationNumber.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationIdentificationNumber.Location = new System.Drawing.Point(831, 67);
            this.lblConfirmationIdentificationNumber.Name = "lblConfirmationIdentificationNumber";
            this.lblConfirmationIdentificationNumber.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationIdentificationNumber.TabIndex = 82;
            this.lblConfirmationIdentificationNumber.Text = "*";
            this.lblConfirmationIdentificationNumber.Visible = false;
            // 
            // ComboBoxRol
            // 
            this.ComboBoxRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxRol.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxRol.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ComboBoxRol.BorderColor = System.Drawing.Color.Black;
            this.ComboBoxRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRol.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRol.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxRol.FormattingEnabled = true;
            this.ComboBoxRol.Location = new System.Drawing.Point(352, 443);
            this.ComboBoxRol.Name = "ComboBoxRol";
            this.ComboBoxRol.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxRol.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxRol.Radius = 10;
            this.ComboBoxRol.Size = new System.Drawing.Size(230, 30);
            this.ComboBoxRol.TabIndex = 79;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(619, 269);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 10;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(231, 32);
            this.txtEmail.TabIndex = 78;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtPhone.BorderColor = System.Drawing.Color.Black;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(352, 269);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 10;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(230, 32);
            this.txtPhone.TabIndex = 77;
            // 
            // txtResidenceAddress
            // 
            this.txtResidenceAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResidenceAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtResidenceAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtResidenceAddress.BorderColor = System.Drawing.Color.Black;
            this.txtResidenceAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResidenceAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtResidenceAddress.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtResidenceAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResidenceAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidenceAddress.Location = new System.Drawing.Point(619, 355);
            this.txtResidenceAddress.Name = "txtResidenceAddress";
            this.txtResidenceAddress.PasswordChar = '\0';
            this.txtResidenceAddress.Radius = 10;
            this.txtResidenceAddress.SelectedText = "";
            this.txtResidenceAddress.Size = new System.Drawing.Size(229, 32);
            this.txtResidenceAddress.TabIndex = 76;
            // 
            // ComboBoxCity
            // 
            this.ComboBoxCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxCity.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxCity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ComboBoxCity.BorderColor = System.Drawing.Color.Black;
            this.ComboBoxCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCity.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCity.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxCity.FormattingEnabled = true;
            this.ComboBoxCity.IntegralHeight = false;
            this.ComboBoxCity.Items.AddRange(new object[] {
            "w",
            "r",
            "t"});
            this.ComboBoxCity.Location = new System.Drawing.Point(350, 357);
            this.ComboBoxCity.MaxDropDownItems = 6;
            this.ComboBoxCity.Name = "ComboBoxCity";
            this.ComboBoxCity.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxCity.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxCity.Radius = 10;
            this.ComboBoxCity.Size = new System.Drawing.Size(230, 30);
            this.ComboBoxCity.TabIndex = 75;
            // 
            // ComboBoxDepartaments
            // 
            this.ComboBoxDepartaments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxDepartaments.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxDepartaments.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ComboBoxDepartaments.BorderColor = System.Drawing.Color.Black;
            this.ComboBoxDepartaments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxDepartaments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDepartaments.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxDepartaments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDepartaments.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxDepartaments.FormattingEnabled = true;
            this.ComboBoxDepartaments.IntegralHeight = false;
            this.ComboBoxDepartaments.Location = new System.Drawing.Point(85, 357);
            this.ComboBoxDepartaments.MaxDropDownItems = 6;
            this.ComboBoxDepartaments.Name = "ComboBoxDepartaments";
            this.ComboBoxDepartaments.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxDepartaments.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxDepartaments.Radius = 10;
            this.ComboBoxDepartaments.Size = new System.Drawing.Size(230, 30);
            this.ComboBoxDepartaments.TabIndex = 74;
            this.ComboBoxDepartaments.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDepartaments_SelectedIndexChanged);
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
            this.txtSurnames.Location = new System.Drawing.Point(617, 181);
            this.txtSurnames.Name = "txtSurnames";
            this.txtSurnames.PasswordChar = '\0';
            this.txtSurnames.Radius = 10;
            this.txtSurnames.SelectedText = "";
            this.txtSurnames.Size = new System.Drawing.Size(231, 32);
            this.txtSurnames.TabIndex = 73;
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
            this.txtNames.Location = new System.Drawing.Point(350, 181);
            this.txtNames.Name = "txtNames";
            this.txtNames.PasswordChar = '\0';
            this.txtNames.Radius = 10;
            this.txtNames.SelectedText = "";
            this.txtNames.Size = new System.Drawing.Size(230, 32);
            this.txtNames.TabIndex = 72;
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
            this.txtIdentificationNumber.Location = new System.Drawing.Point(619, 93);
            this.txtIdentificationNumber.Name = "txtIdentificationNumber";
            this.txtIdentificationNumber.PasswordChar = '\0';
            this.txtIdentificationNumber.Radius = 10;
            this.txtIdentificationNumber.SelectedText = "";
            this.txtIdentificationNumber.Size = new System.Drawing.Size(230, 32);
            this.txtIdentificationNumber.TabIndex = 71;
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
            this.ComboBoxDocumentsType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDocumentsType.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxDocumentsType.FormattingEnabled = true;
            this.ComboBoxDocumentsType.Location = new System.Drawing.Point(352, 95);
            this.ComboBoxDocumentsType.Name = "ComboBoxDocumentsType";
            this.ComboBoxDocumentsType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxDocumentsType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxDocumentsType.Radius = 10;
            this.ComboBoxDocumentsType.Size = new System.Drawing.Size(230, 30);
            this.ComboBoxDocumentsType.TabIndex = 70;
            // 
            // ptbhoto
            // 
            this.ptbhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbhoto.BackColor = System.Drawing.Color.Transparent;
            this.ptbhoto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ptbhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbhoto.Image = ((System.Drawing.Image)(resources.GetObject("ptbhoto.Image")));
            this.ptbhoto.Location = new System.Drawing.Point(110, 95);
            this.ptbhoto.Name = "ptbhoto";
            this.ptbhoto.Radius = 10;
            this.ptbhoto.Size = new System.Drawing.Size(180, 206);
            this.ptbhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbhoto.TabIndex = 69;
            this.ptbhoto.TabStop = false;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.ComboBoxCargo);
            this.Controls.Add(this.lblEmailInvalid);
            this.Controls.Add(this.lblIdentificationNumberInvalid);
            this.Controls.Add(this.lblConfirmationEmail);
            this.Controls.Add(this.lblConfirmationPhone);
            this.Controls.Add(this.lblConfirmationResidenceAddress);
            this.Controls.Add(this.lblConfirmationSurnames);
            this.Controls.Add(this.lblConfirmationNames);
            this.Controls.Add(this.lblConfirmationIdentificationNumber);
            this.Controls.Add(btnCancel);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(this.ComboBoxRol);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtResidenceAddress);
            this.Controls.Add(this.ComboBoxCity);
            this.Controls.Add(this.ComboBoxDepartaments);
            this.Controls.Add(this.txtSurnames);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.txtIdentificationNumber);
            this.Controls.Add(this.ComboBoxDocumentsType);
            this.Controls.Add(this.ptbhoto);
            this.MaximizeBox = false;
            this.Name = "EditUser";
            this.Text = "Editar usuario";
            ((System.ComponentModel.ISupportInitialize)(this.ptbhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox ComboBoxCargo;
        private System.Windows.Forms.Label lblEmailInvalid;
        private System.Windows.Forms.Label lblIdentificationNumberInvalid;
        private System.Windows.Forms.Label lblConfirmationEmail;
        private System.Windows.Forms.Label lblConfirmationPhone;
        private System.Windows.Forms.Label lblConfirmationResidenceAddress;
        private System.Windows.Forms.Label lblConfirmationSurnames;
        private System.Windows.Forms.Label lblConfirmationNames;
        private System.Windows.Forms.Label lblConfirmationIdentificationNumber;
        private Guna.UI.WinForms.GunaComboBox ComboBoxRol;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Guna.UI.WinForms.GunaTextBox txtResidenceAddress;
        private Guna.UI.WinForms.GunaComboBox ComboBoxCity;
        private Guna.UI.WinForms.GunaComboBox ComboBoxDepartaments;
        private Guna.UI.WinForms.GunaTextBox txtSurnames;
        private Guna.UI.WinForms.GunaTextBox txtNames;
        private Guna.UI.WinForms.GunaTextBox txtIdentificationNumber;
        private Guna.UI.WinForms.GunaComboBox ComboBoxDocumentsType;
        private Guna.UI.WinForms.GunaPictureBox ptbhoto;
    }
}