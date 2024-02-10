namespace Cartera_Facil.View
{
    partial class Simulator
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
            Guna.UI.WinForms.GunaButton btnsSimulate;
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblConfirmationAmount = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI.WinForms.GunaTextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.gunaNumericTime = new Guna.UI.WinForms.GunaNumeric();
            this.gunaNumericInterestRate = new Guna.UI.WinForms.GunaNumeric();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.ComboBoxPaymentMethod = new Guna.UI.WinForms.GunaComboBox();
            this.lblValidateNumber = new System.Windows.Forms.Label();
            this.lblIdentificationNumberInvalid = new System.Windows.Forms.Label();
            btnsSimulate = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // btnsSimulate
            // 
            btnsSimulate.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnsSimulate.AnimationHoverSpeed = 0.07F;
            btnsSimulate.AnimationSpeed = 0.03F;
            btnsSimulate.BackColor = System.Drawing.Color.Transparent;
            btnsSimulate.BaseColor = System.Drawing.Color.LightGreen;
            btnsSimulate.BorderColor = System.Drawing.Color.Black;
            btnsSimulate.DialogResult = System.Windows.Forms.DialogResult.None;
            btnsSimulate.FocusedColor = System.Drawing.Color.Empty;
            btnsSimulate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnsSimulate.ForeColor = System.Drawing.Color.Black;
            btnsSimulate.Image = null;
            btnsSimulate.ImageSize = new System.Drawing.Size(20, 20);
            btnsSimulate.Location = new System.Drawing.Point(516, 443);
            btnsSimulate.Name = "btnsSimulate";
            btnsSimulate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnsSimulate.OnHoverBorderColor = System.Drawing.Color.Black;
            btnsSimulate.OnHoverForeColor = System.Drawing.Color.White;
            btnsSimulate.OnHoverImage = null;
            btnsSimulate.OnPressedColor = System.Drawing.Color.Black;
            btnsSimulate.Radius = 10;
            btnsSimulate.Size = new System.Drawing.Size(129, 45);
            btnsSimulate.TabIndex = 56;
            btnsSimulate.Text = "SIMULATE";
            btnsSimulate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnsSimulate.Click += new System.EventHandler(this.btnsSimulate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(117, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(543, 63);
            this.lblTitle.TabIndex = 42;
            this.lblTitle.Text = "Simulador de credito";
            // 
            // lblConfirmationAmount
            // 
            this.lblConfirmationAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmationAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationAmount.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmationAmount.Location = new System.Drawing.Point(627, 155);
            this.lblConfirmationAmount.Name = "lblConfirmationAmount";
            this.lblConfirmationAmount.Size = new System.Drawing.Size(18, 25);
            this.lblConfirmationAmount.TabIndex = 46;
            this.lblConfirmationAmount.Text = "*";
            this.lblConfirmationAmount.Visible = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtAmount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtAmount.BorderColor = System.Drawing.Color.Black;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAmount.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtAmount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(228, 183);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.Radius = 10;
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(417, 32);
            this.txtAmount.TabIndex = 45;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(126, 183);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(97, 28);
            this.lblAmount.TabIndex = 44;
            this.lblAmount.Text = "Cantidad:";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(126, 251);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(179, 28);
            this.lblTime.TabIndex = 47;
            this.lblTime.Text = "Tiempo en meses:";
            // 
            // gunaNumericTime
            // 
            this.gunaNumericTime.AllowDrop = true;
            this.gunaNumericTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaNumericTime.BackColor = System.Drawing.Color.Transparent;
            this.gunaNumericTime.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gunaNumericTime.BorderColor = System.Drawing.Color.Black;
            this.gunaNumericTime.BorderSize = 2;
            this.gunaNumericTime.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(207)))));
            this.gunaNumericTime.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumericTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gunaNumericTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaNumericTime.ForeColor = System.Drawing.Color.Black;
            this.gunaNumericTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaNumericTime.Location = new System.Drawing.Point(303, 253);
            this.gunaNumericTime.Maximum = ((long)(9999999));
            this.gunaNumericTime.Minimum = ((long)(1));
            this.gunaNumericTime.Name = "gunaNumericTime";
            this.gunaNumericTime.Radius = 10;
            this.gunaNumericTime.Size = new System.Drawing.Size(342, 30);
            this.gunaNumericTime.TabIndex = 48;
            this.gunaNumericTime.Value = ((long)(1));
            // 
            // gunaNumericInterestRate
            // 
            this.gunaNumericInterestRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaNumericInterestRate.BackColor = System.Drawing.Color.Transparent;
            this.gunaNumericInterestRate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gunaNumericInterestRate.BorderColor = System.Drawing.Color.Black;
            this.gunaNumericInterestRate.BorderSize = 2;
            this.gunaNumericInterestRate.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(207)))));
            this.gunaNumericInterestRate.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumericInterestRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaNumericInterestRate.ForeColor = System.Drawing.Color.Black;
            this.gunaNumericInterestRate.Location = new System.Drawing.Point(303, 320);
            this.gunaNumericInterestRate.Maximum = ((long)(9999999));
            this.gunaNumericInterestRate.Minimum = ((long)(1));
            this.gunaNumericInterestRate.Name = "gunaNumericInterestRate";
            this.gunaNumericInterestRate.Radius = 10;
            this.gunaNumericInterestRate.Size = new System.Drawing.Size(342, 30);
            this.gunaNumericInterestRate.TabIndex = 51;
            this.gunaNumericInterestRate.Value = ((long)(1));
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.Location = new System.Drawing.Point(126, 317);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(175, 28);
            this.lblInterestRate.TabIndex = 50;
            this.lblInterestRate.Text = "Tasa de interes %:";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(126, 388);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(183, 25);
            this.lblPaymentMethod.TabIndex = 54;
            this.lblPaymentMethod.Text = "Modalidad de pago:";
            // 
            // ComboBoxPaymentMethod
            // 
            this.ComboBoxPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxPaymentMethod.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ComboBoxPaymentMethod.BorderColor = System.Drawing.Color.Black;
            this.ComboBoxPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPaymentMethod.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxPaymentMethod.FormattingEnabled = true;
            this.ComboBoxPaymentMethod.Location = new System.Drawing.Point(315, 386);
            this.ComboBoxPaymentMethod.Name = "ComboBoxPaymentMethod";
            this.ComboBoxPaymentMethod.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxPaymentMethod.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxPaymentMethod.Radius = 10;
            this.ComboBoxPaymentMethod.Size = new System.Drawing.Size(330, 30);
            this.ComboBoxPaymentMethod.TabIndex = 53;
            // 
            // lblValidateNumber
            // 
            this.lblValidateNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidateNumber.AutoSize = true;
            this.lblValidateNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidateNumber.ForeColor = System.Drawing.Color.Red;
            this.lblValidateNumber.Location = new System.Drawing.Point(529, 218);
            this.lblValidateNumber.Name = "lblValidateNumber";
            this.lblValidateNumber.Size = new System.Drawing.Size(116, 17);
            this.lblValidateNumber.TabIndex = 57;
            this.lblValidateNumber.Text = "Valor no aceptado";
            this.lblValidateNumber.Visible = false;
            // 
            // lblIdentificationNumberInvalid
            // 
            this.lblIdentificationNumberInvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdentificationNumberInvalid.AutoSize = true;
            this.lblIdentificationNumberInvalid.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificationNumberInvalid.ForeColor = System.Drawing.Color.Black;
            this.lblIdentificationNumberInvalid.Location = new System.Drawing.Point(123, 124);
            this.lblIdentificationNumberInvalid.Name = "lblIdentificationNumberInvalid";
            this.lblIdentificationNumberInvalid.Size = new System.Drawing.Size(522, 25);
            this.lblIdentificationNumberInvalid.TabIndex = 43;
            this.lblIdentificationNumberInvalid.Text = "Rellena los campos y conoce la información de tu crédito";
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 542);
            this.Controls.Add(this.lblValidateNumber);
            this.Controls.Add(btnsSimulate);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.ComboBoxPaymentMethod);
            this.Controls.Add(this.gunaNumericInterestRate);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.gunaNumericTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblConfirmationAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblIdentificationNumberInvalid);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Simulator";
            this.Text = "Simulador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblConfirmationAmount;
        private Guna.UI.WinForms.GunaTextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTime;
        private Guna.UI.WinForms.GunaNumeric gunaNumericTime;
        private Guna.UI.WinForms.GunaNumeric gunaNumericInterestRate;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblPaymentMethod;
        private Guna.UI.WinForms.GunaComboBox ComboBoxPaymentMethod;
        private System.Windows.Forms.Label lblValidateNumber;
        private System.Windows.Forms.Label lblIdentificationNumberInvalid;
    }
}