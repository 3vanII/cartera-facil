namespace Cartera_Facil.View
{
    partial class CreateUser
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
            Guna.UI.WinForms.GunaButton btnCreate;
            Guna.UI.WinForms.GunaButton btnCancel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.ComboBoxDocumentsType = new Guna.UI.WinForms.GunaComboBox();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.lblIdentificationNumber = new System.Windows.Forms.Label();
            this.txtNames = new Guna.UI.WinForms.GunaTextBox();
            this.lblNames = new System.Windows.Forms.Label();
            this.txtSurnames = new Guna.UI.WinForms.GunaTextBox();
            this.lblSurnames = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.ComboBoxRol = new Guna.UI.WinForms.GunaComboBox();
            this.lblConfirmationIdentificationNumber = new System.Windows.Forms.Label();
            this.lblConfirmationNames = new System.Windows.Forms.Label();
            this.lblConfirmationSurnames = new System.Windows.Forms.Label();
            this.lblIdentificationNumberInvalid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentificationNumber = new Guna.UI.WinForms.GunaTextBox();
            this.ptbhoto = new Guna.UI.WinForms.GunaPictureBox();
            this.ComboBoxDepartaments = new Guna.UI.WinForms.GunaComboBox();
            this.lblDepartament = new System.Windows.Forms.Label();
            this.lblConfirmationEmail = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblResidenceAddress = new System.Windows.Forms.Label();
            this.txtResidenceAddress = new Guna.UI.WinForms.GunaTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.lblConfirmationResidenceAddress = new System.Windows.Forms.Label();
            this.lblConfirmationPhone = new System.Windows.Forms.Label();
            this.ComboBoxCity = new Guna.UI.WinForms.GunaComboBox();
            this.lblEmailInvalid = new System.Windows.Forms.Label();
            btnCreate = new Guna.UI.WinForms.GunaButton();
            btnCancel = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCreate.AnimationHoverSpeed = 0.07F;
            btnCreate.AnimationSpeed = 0.03F;
            btnCreate.BackColor = System.Drawing.Color.Transparent;
            btnCreate.BaseColor = System.Drawing.Color.LightGreen;
            btnCreate.BorderColor = System.Drawing.Color.Black;
            btnCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            btnCreate.FocusedColor = System.Drawing.Color.Empty;
            btnCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnCreate.ForeColor = System.Drawing.Color.Black;
            btnCreate.Image = null;
            btnCreate.ImageSize = new System.Drawing.Size(20, 20);
            btnCreate.Location = new System.Drawing.Point(523, 410);
            btnCreate.Name = "btnCreate";
            btnCreate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnCreate.OnHoverBorderColor = System.Drawing.Color.Black;
            btnCreate.OnHoverForeColor = System.Drawing.Color.White;
            btnCreate.OnHoverImage = null;
            btnCreate.OnPressedColor = System.Drawing.Color.Black;
            btnCreate.Radius = 10;
            btnCreate.Size = new System.Drawing.Size(97, 45);
            btnCreate.TabIndex = 27;
            btnCreate.Text = "CREATE";
            btnCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
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
            btnCancel.Location = new System.Drawing.Point(642, 411);
            btnCancel.Name = "btnCancel";
            btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            btnCancel.OnHoverImage = null;
            btnCancel.OnPressedColor = System.Drawing.Color.Black;
            btnCancel.Radius = 10;
            btnCancel.Size = new System.Drawing.Size(99, 45);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.ComboBoxDocumentsType.Location = new System.Drawing.Point(259, 168);
            this.ComboBoxDocumentsType.Name = "ComboBoxDocumentsType";
            this.ComboBoxDocumentsType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxDocumentsType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxDocumentsType.Radius = 10;
            this.ComboBoxDocumentsType.Size = new System.Drawing.Size(230, 30);
            this.ComboBoxDocumentsType.TabIndex = 2;
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentType.Location = new System.Drawing.Point(254, 140);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(178, 25);
            this.lblDocumentType.TabIndex = 6;
            this.lblDocumentType.Text = "Tipo de documento";
            // 
            // lblIdentificationNumber
            // 
            this.lblIdentificationNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdentificationNumber.AutoSize = true;
            this.lblIdentificationNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.lblIdentificationNumber.Location = new System.Drawing.Point(507, 137);
            this.lblIdentificationNumber.Name = "lblIdentificationNumber";
            this.lblIdentificationNumber.Size = new System.Drawing.Size(212, 25);
            this.lblIdentificationNumber.TabIndex = 7;
            this.lblIdentificationNumber.Text = "Número de documento";
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
            this.txtNames.Location = new System.Drawing.Point(259, 253);
            this.txtNames.Name = "txtNames";
            this.txtNames.PasswordChar = '\0';
            this.txtNames.Radius = 10;
            this.txtNames.SelectedText = "";
            this.txtNames.Size = new System.Drawing.Size(230, 32);
            this.txtNames.TabIndex = 10;
            // 
            // lblNames
            // 
            this.lblNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.Location = new System.Drawing.Point(254, 225);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(91, 25);
            this.lblNames.TabIndex = 9;
            this.lblNames.Text = "Nombres";
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
            this.txtSurnames.Location = new System.Drawing.Point(512, 253);
            this.txtSurnames.Name = "txtSurnames";
            this.txtSurnames.PasswordChar = '\0';
            this.txtSurnames.Radius = 10;
            this.txtSurnames.SelectedText = "";
            this.txtSurnames.Size = new System.Drawing.Size(230, 32);
            this.txtSurnames.TabIndex = 12;
            // 
            // lblSurnames
            // 
            this.lblSurnames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSurnames.AutoSize = true;
            this.lblSurnames.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnames.Location = new System.Drawing.Point(507, 225);
            this.lblSurnames.Name = "lblSurnames";
            this.lblSurnames.Size = new System.Drawing.Size(91, 25);
            this.lblSurnames.TabIndex = 11;
            this.lblSurnames.Text = "Apellidos";
            // 
            // lblUserRole
            // 
            this.lblUserRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.Location = new System.Drawing.Point(6, 225);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(63, 25);
            this.lblUserRole.TabIndex = 26;
            this.lblUserRole.Text = "Cargo";
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
            this.ComboBoxRol.Location = new System.Drawing.Point(11, 253);
            this.ComboBoxRol.Name = "ComboBoxRol";
            this.ComboBoxRol.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxRol.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxRol.Radius = 10;
            this.ComboBoxRol.Size = new System.Drawing.Size(230, 30);
            this.ComboBoxRol.TabIndex = 25;
            // 
            // lblConfirmationIdentificationNumber
            // 
            this.lblConfirmationIdentificationNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationIdentificationNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationIdentificationNumber.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationIdentificationNumber.Location = new System.Drawing.Point(724, 139);
            this.lblConfirmationIdentificationNumber.Name = "lblConfirmationIdentificationNumber";
            this.lblConfirmationIdentificationNumber.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationIdentificationNumber.TabIndex = 30;
            this.lblConfirmationIdentificationNumber.Text = "*";
            this.lblConfirmationIdentificationNumber.Visible = false;
            // 
            // lblConfirmationNames
            // 
            this.lblConfirmationNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationNames.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationNames.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationNames.Location = new System.Drawing.Point(471, 225);
            this.lblConfirmationNames.Name = "lblConfirmationNames";
            this.lblConfirmationNames.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationNames.TabIndex = 31;
            this.lblConfirmationNames.Text = "*";
            this.lblConfirmationNames.Visible = false;
            // 
            // lblConfirmationSurnames
            // 
            this.lblConfirmationSurnames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationSurnames.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationSurnames.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationSurnames.Location = new System.Drawing.Point(723, 224);
            this.lblConfirmationSurnames.Name = "lblConfirmationSurnames";
            this.lblConfirmationSurnames.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationSurnames.TabIndex = 33;
            this.lblConfirmationSurnames.Text = "*";
            this.lblConfirmationSurnames.Visible = false;
            // 
            // lblIdentificationNumberInvalid
            // 
            this.lblIdentificationNumberInvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdentificationNumberInvalid.AutoSize = true;
            this.lblIdentificationNumberInvalid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificationNumberInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblIdentificationNumberInvalid.Location = new System.Drawing.Point(559, 200);
            this.lblIdentificationNumberInvalid.Name = "lblIdentificationNumberInvalid";
            this.lblIdentificationNumberInvalid.Size = new System.Drawing.Size(183, 17);
            this.lblIdentificationNumberInvalid.TabIndex = 40;
            this.lblIdentificationNumberInvalid.Text = "Número de identidad inválido";
            this.lblIdentificationNumberInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIdentificationNumberInvalid.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 44);
            this.label1.TabIndex = 41;
            this.label1.Text = "Crear usuario";
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
            this.txtIdentificationNumber.Location = new System.Drawing.Point(512, 165);
            this.txtIdentificationNumber.Name = "txtIdentificationNumber";
            this.txtIdentificationNumber.PasswordChar = '\0';
            this.txtIdentificationNumber.Radius = 10;
            this.txtIdentificationNumber.SelectedText = "";
            this.txtIdentificationNumber.Size = new System.Drawing.Size(230, 32);
            this.txtIdentificationNumber.TabIndex = 8;
            // 
            // ptbhoto
            // 
            this.ptbhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbhoto.BackColor = System.Drawing.Color.Transparent;
            this.ptbhoto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ptbhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbhoto.Image = ((System.Drawing.Image)(resources.GetObject("ptbhoto.Image")));
            this.ptbhoto.Location = new System.Drawing.Point(44, 51);
            this.ptbhoto.Name = "ptbhoto";
            this.ptbhoto.Radius = 10;
            this.ptbhoto.Size = new System.Drawing.Size(150, 160);
            this.ptbhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbhoto.TabIndex = 1;
            this.ptbhoto.TabStop = false;
            this.ptbhoto.Click += new System.EventHandler(this.ptbhoto_Click);
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
            this.ComboBoxDepartaments.Location = new System.Drawing.Point(11, 341);
            this.ComboBoxDepartaments.MaxDropDownItems = 6;
            this.ComboBoxDepartaments.Name = "ComboBoxDepartaments";
            this.ComboBoxDepartaments.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxDepartaments.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxDepartaments.Radius = 10;
            this.ComboBoxDepartaments.Size = new System.Drawing.Size(230, 30);
            this.ComboBoxDepartaments.TabIndex = 13;
            this.ComboBoxDepartaments.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDepartaments_SelectedIndexChanged);
            // 
            // lblDepartament
            // 
            this.lblDepartament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartament.AutoSize = true;
            this.lblDepartament.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartament.Location = new System.Drawing.Point(6, 310);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(144, 28);
            this.lblDepartament.TabIndex = 14;
            this.lblDepartament.Text = "Departamento";
            // 
            // lblConfirmationEmail
            // 
            this.lblConfirmationEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationEmail.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationEmail.Location = new System.Drawing.Point(472, 394);
            this.lblConfirmationEmail.Name = "lblConfirmationEmail";
            this.lblConfirmationEmail.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationEmail.TabIndex = 38;
            this.lblConfirmationEmail.Text = "*";
            this.lblConfirmationEmail.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(256, 310);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(102, 28);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "Municipio";
            // 
            // lblResidenceAddress
            // 
            this.lblResidenceAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResidenceAddress.AutoSize = true;
            this.lblResidenceAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidenceAddress.Location = new System.Drawing.Point(507, 310);
            this.lblResidenceAddress.Name = "lblResidenceAddress";
            this.lblResidenceAddress.Size = new System.Drawing.Size(96, 28);
            this.lblResidenceAddress.TabIndex = 17;
            this.lblResidenceAddress.Text = "Dirección";
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
            this.txtResidenceAddress.Location = new System.Drawing.Point(512, 341);
            this.txtResidenceAddress.Name = "txtResidenceAddress";
            this.txtResidenceAddress.PasswordChar = '\0';
            this.txtResidenceAddress.Radius = 10;
            this.txtResidenceAddress.SelectedText = "";
            this.txtResidenceAddress.Size = new System.Drawing.Size(230, 32);
            this.txtResidenceAddress.TabIndex = 18;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(5, 394);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 28);
            this.lblPhone.TabIndex = 21;
            this.lblPhone.Text = "Telefono";
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
            this.txtPhone.Location = new System.Drawing.Point(10, 424);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 10;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(230, 32);
            this.txtPhone.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(256, 394);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 28);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email";
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
            this.txtEmail.Location = new System.Drawing.Point(261, 424);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 10;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(230, 32);
            this.txtEmail.TabIndex = 24;
            // 
            // lblConfirmationResidenceAddress
            // 
            this.lblConfirmationResidenceAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationResidenceAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationResidenceAddress.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationResidenceAddress.Location = new System.Drawing.Point(723, 312);
            this.lblConfirmationResidenceAddress.Name = "lblConfirmationResidenceAddress";
            this.lblConfirmationResidenceAddress.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationResidenceAddress.TabIndex = 35;
            this.lblConfirmationResidenceAddress.Text = "*";
            this.lblConfirmationResidenceAddress.Visible = false;
            // 
            // lblConfirmationPhone
            // 
            this.lblConfirmationPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationPhone.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationPhone.Location = new System.Drawing.Point(220, 396);
            this.lblConfirmationPhone.Name = "lblConfirmationPhone";
            this.lblConfirmationPhone.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationPhone.TabIndex = 37;
            this.lblConfirmationPhone.Text = "*";
            this.lblConfirmationPhone.Visible = false;
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
            this.ComboBoxCity.Location = new System.Drawing.Point(261, 341);
            this.ComboBoxCity.MaxDropDownItems = 6;
            this.ComboBoxCity.Name = "ComboBoxCity";
            this.ComboBoxCity.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxCity.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxCity.Radius = 10;
            this.ComboBoxCity.Size = new System.Drawing.Size(230, 30);
            this.ComboBoxCity.TabIndex = 15;
            // 
            // lblEmailInvalid
            // 
            this.lblEmailInvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailInvalid.AutoSize = true;
            this.lblEmailInvalid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblEmailInvalid.Location = new System.Drawing.Point(403, 459);
            this.lblEmailInvalid.Name = "lblEmailInvalid";
            this.lblEmailInvalid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmailInvalid.Size = new System.Drawing.Size(88, 17);
            this.lblEmailInvalid.TabIndex = 42;
            this.lblEmailInvalid.Text = "Email inválido";
            this.lblEmailInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmailInvalid.Visible = false;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 525);
            this.Controls.Add(this.lblEmailInvalid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIdentificationNumberInvalid);
            this.Controls.Add(this.lblConfirmationEmail);
            this.Controls.Add(this.lblConfirmationPhone);
            this.Controls.Add(this.lblConfirmationResidenceAddress);
            this.Controls.Add(this.lblConfirmationSurnames);
            this.Controls.Add(this.lblConfirmationNames);
            this.Controls.Add(this.lblConfirmationIdentificationNumber);
            this.Controls.Add(btnCancel);
            this.Controls.Add(btnCreate);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.ComboBoxRol);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtResidenceAddress);
            this.Controls.Add(this.lblResidenceAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.ComboBoxCity);
            this.Controls.Add(this.lblDepartament);
            this.Controls.Add(this.ComboBoxDepartaments);
            this.Controls.Add(this.txtSurnames);
            this.Controls.Add(this.lblSurnames);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.txtIdentificationNumber);
            this.Controls.Add(this.lblIdentificationNumber);
            this.Controls.Add(this.lblDocumentType);
            this.Controls.Add(this.ComboBoxDocumentsType);
            this.Controls.Add(this.ptbhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateUser";
            this.Text = "Crear usuario";
            ((System.ComponentModel.ISupportInitialize)(this.ptbhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaComboBox ComboBoxDocumentsType;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.Label lblIdentificationNumber;
        private Guna.UI.WinForms.GunaTextBox txtNames;
        private System.Windows.Forms.Label lblNames;
        private Guna.UI.WinForms.GunaTextBox txtSurnames;
        private System.Windows.Forms.Label lblSurnames;
        private System.Windows.Forms.Label lblUserRole;
        private Guna.UI.WinForms.GunaComboBox ComboBoxRol;
        private System.Windows.Forms.Label lblConfirmationIdentificationNumber;
        private System.Windows.Forms.Label lblConfirmationNames;
        private System.Windows.Forms.Label lblConfirmationSurnames;
        private System.Windows.Forms.Label lblIdentificationNumberInvalid;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtIdentificationNumber;
        private Guna.UI.WinForms.GunaPictureBox ptbhoto;
        private Guna.UI.WinForms.GunaComboBox ComboBoxDepartaments;
        private System.Windows.Forms.Label lblDepartament;
        private System.Windows.Forms.Label lblConfirmationEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblResidenceAddress;
        private Guna.UI.WinForms.GunaTextBox txtResidenceAddress;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private System.Windows.Forms.Label lblConfirmationResidenceAddress;
        private System.Windows.Forms.Label lblConfirmationPhone;
        private Guna.UI.WinForms.GunaComboBox ComboBoxCity;
        private System.Windows.Forms.Label lblEmailInvalid;
    }
}