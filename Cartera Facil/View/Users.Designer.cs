namespace Cartera_Facil.View
{
    partial class Users
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
            Guna.UI.WinForms.GunaButton btnRestore;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.panelUsers = new System.Windows.Forms.Panel();
            this.groupBoxSearchEmployee = new System.Windows.Forms.GroupBox();
            this.groupBoxListEmployeed = new System.Windows.Forms.GroupBox();
            this.dtgvEmployees = new System.Windows.Forms.DataGridView();
            this.Detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.lblIdentificationNotRegistered = new System.Windows.Forms.Label();
            this.txtIdentificationNumber = new Guna.UI.WinForms.GunaTextBox();
            btnRestore = new Guna.UI.WinForms.GunaButton();
            this.panelUsers.SuspendLayout();
            this.groupBoxSearchEmployee.SuspendLayout();
            this.groupBoxListEmployeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestore
            // 
            btnRestore.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnRestore.AnimationHoverSpeed = 0.07F;
            btnRestore.AnimationSpeed = 0.03F;
            btnRestore.BackColor = System.Drawing.Color.Transparent;
            btnRestore.BaseColor = System.Drawing.Color.SkyBlue;
            btnRestore.BorderColor = System.Drawing.Color.Black;
            btnRestore.DialogResult = System.Windows.Forms.DialogResult.None;
            btnRestore.FocusedColor = System.Drawing.Color.Empty;
            btnRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRestore.ForeColor = System.Drawing.Color.Black;
            btnRestore.Image = null;
            btnRestore.ImageSize = new System.Drawing.Size(20, 20);
            btnRestore.Location = new System.Drawing.Point(799, 380);
            btnRestore.Name = "btnRestore";
            btnRestore.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            btnRestore.OnHoverBorderColor = System.Drawing.Color.Black;
            btnRestore.OnHoverForeColor = System.Drawing.Color.White;
            btnRestore.OnHoverImage = null;
            btnRestore.OnPressedColor = System.Drawing.Color.Black;
            btnRestore.Radius = 5;
            btnRestore.Size = new System.Drawing.Size(111, 20);
            btnRestore.TabIndex = 59;
            btnRestore.Text = "RESTAURAR";
            btnRestore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // panelUsers
            // 
            this.panelUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsers.Controls.Add(this.groupBoxSearchEmployee);
            this.panelUsers.Location = new System.Drawing.Point(0, 0);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(950, 580);
            this.panelUsers.TabIndex = 0;
            // 
            // groupBoxSearchEmployee
            // 
            this.groupBoxSearchEmployee.Controls.Add(this.groupBoxListEmployeed);
            this.groupBoxSearchEmployee.Controls.Add(this.ptbSearch);
            this.groupBoxSearchEmployee.Controls.Add(this.txtName);
            this.groupBoxSearchEmployee.Controls.Add(this.lblIdentificationNotRegistered);
            this.groupBoxSearchEmployee.Controls.Add(this.txtIdentificationNumber);
            this.groupBoxSearchEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxSearchEmployee.Location = new System.Drawing.Point(10, 12);
            this.groupBoxSearchEmployee.Name = "groupBoxSearchEmployee";
            this.groupBoxSearchEmployee.Size = new System.Drawing.Size(928, 556);
            this.groupBoxSearchEmployee.TabIndex = 0;
            this.groupBoxSearchEmployee.TabStop = false;
            this.groupBoxSearchEmployee.Text = "Buscar empleado";
            // 
            // groupBoxListEmployeed
            // 
            this.groupBoxListEmployeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxListEmployeed.Controls.Add(btnRestore);
            this.groupBoxListEmployeed.Controls.Add(this.dtgvEmployees);
            this.groupBoxListEmployeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxListEmployeed.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxListEmployeed.ForeColor = System.Drawing.Color.Black;
            this.groupBoxListEmployeed.Location = new System.Drawing.Point(6, 144);
            this.groupBoxListEmployeed.Name = "groupBoxListEmployeed";
            this.groupBoxListEmployeed.Size = new System.Drawing.Size(916, 406);
            this.groupBoxListEmployeed.TabIndex = 71;
            this.groupBoxListEmployeed.TabStop = false;
            this.groupBoxListEmployeed.Text = "Lista de empleados";
            // 
            // dtgvEmployees
            // 
            this.dtgvEmployees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle,
            this.Editar});
            this.dtgvEmployees.Location = new System.Drawing.Point(6, 24);
            this.dtgvEmployees.Name = "dtgvEmployees";
            this.dtgvEmployees.Size = new System.Drawing.Size(904, 350);
            this.dtgvEmployees.TabIndex = 0;
            this.dtgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmployees_CellClick);
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Detalle.Image")));
            this.Detalle.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Detalle.Name = "Detalle";
            this.Detalle.Width = 59;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.Width = 51;
            // 
            // ptbSearch
            // 
            this.ptbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbSearch.Image = ((System.Drawing.Image)(resources.GetObject("ptbSearch.Image")));
            this.ptbSearch.Location = new System.Drawing.Point(762, 53);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(34, 32);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSearch.TabIndex = 70;
            this.ptbSearch.TabStop = false;
            this.ptbSearch.Click += new System.EventHandler(this.ptbSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(448, 53);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Radius = 10;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(230, 32);
            this.txtName.TabIndex = 69;
            // 
            // lblIdentificationNotRegistered
            // 
            this.lblIdentificationNotRegistered.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdentificationNotRegistered.AutoSize = true;
            this.lblIdentificationNotRegistered.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificationNotRegistered.ForeColor = System.Drawing.Color.Red;
            this.lblIdentificationNotRegistered.Location = new System.Drawing.Point(216, 88);
            this.lblIdentificationNotRegistered.Name = "lblIdentificationNotRegistered";
            this.lblIdentificationNotRegistered.Size = new System.Drawing.Size(148, 17);
            this.lblIdentificationNotRegistered.TabIndex = 68;
            this.lblIdentificationNotRegistered.Text = "Identificacion no inscrita";
            this.lblIdentificationNotRegistered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIdentificationNotRegistered.Visible = false;
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
            this.txtIdentificationNumber.Location = new System.Drawing.Point(134, 53);
            this.txtIdentificationNumber.Name = "txtIdentificationNumber";
            this.txtIdentificationNumber.PasswordChar = '\0';
            this.txtIdentificationNumber.Radius = 10;
            this.txtIdentificationNumber.SelectedText = "";
            this.txtIdentificationNumber.Size = new System.Drawing.Size(230, 32);
            this.txtIdentificationNumber.TabIndex = 67;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 580);
            this.Controls.Add(this.panelUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panelUsers.ResumeLayout(false);
            this.groupBoxSearchEmployee.ResumeLayout(false);
            this.groupBoxSearchEmployee.PerformLayout();
            this.groupBoxListEmployeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.GroupBox groupBoxSearchEmployee;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.Label lblIdentificationNotRegistered;
        private Guna.UI.WinForms.GunaTextBox txtIdentificationNumber;
        private System.Windows.Forms.GroupBox groupBoxListEmployeed;
        private System.Windows.Forms.DataGridView dtgvEmployees;
        private System.Windows.Forms.PictureBox ptbSearch;
        private System.Windows.Forms.DataGridViewImageColumn Detalle;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}