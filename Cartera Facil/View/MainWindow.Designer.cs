namespace Cartera_Facil.View
{
    partial class MainWindow
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
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.btnToday = new FontAwesome.Sharp.IconButton();
            this.subMenuLoan = new System.Windows.Forms.Panel();
            this.btnConsultLoan = new FontAwesome.Sharp.IconButton();
            this.btnCreateLoan = new FontAwesome.Sharp.IconButton();
            this.btnLoan = new FontAwesome.Sharp.IconButton();
            this.subMenuUsers = new System.Windows.Forms.Panel();
            this.btnCreateUser = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnSimulator = new FontAwesome.Sharp.IconButton();
            this.btnWallet = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblForm = new System.Windows.Forms.Label();
            this.iconFormChild = new FontAwesome.Sharp.IconPictureBox();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.pictureProfile = new Guna.UI.WinForms.GunaPictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            this.subMenuLoan.SuspendLayout();
            this.subMenuUsers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.AutoScroll = true;
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(207)))));
            this.sideMenuPanel.Controls.Add(this.btnToday);
            this.sideMenuPanel.Controls.Add(this.subMenuLoan);
            this.sideMenuPanel.Controls.Add(this.btnLoan);
            this.sideMenuPanel.Controls.Add(this.subMenuUsers);
            this.sideMenuPanel.Controls.Add(this.btnUser);
            this.sideMenuPanel.Controls.Add(this.btnSimulator);
            this.sideMenuPanel.Controls.Add(this.btnWallet);
            this.sideMenuPanel.Controls.Add(this.panelLogo);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(200, 600);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // btnToday
            // 
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnToday.IconColor = System.Drawing.Color.White;
            this.btnToday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToday.IconSize = 44;
            this.btnToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.Location = new System.Drawing.Point(0, 375);
            this.btnToday.Name = "btnToday";
            this.btnToday.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnToday.Size = new System.Drawing.Size(200, 45);
            this.btnToday.TabIndex = 9;
            this.btnToday.Text = "Today";
            this.btnToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // subMenuLoan
            // 
            this.subMenuLoan.Controls.Add(this.btnConsultLoan);
            this.subMenuLoan.Controls.Add(this.btnCreateLoan);
            this.subMenuLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuLoan.ForeColor = System.Drawing.Color.White;
            this.subMenuLoan.Location = new System.Drawing.Point(0, 295);
            this.subMenuLoan.Name = "subMenuLoan";
            this.subMenuLoan.Size = new System.Drawing.Size(200, 80);
            this.subMenuLoan.TabIndex = 8;
            // 
            // btnConsultLoan
            // 
            this.btnConsultLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultLoan.FlatAppearance.BorderSize = 0;
            this.btnConsultLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultLoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultLoan.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnConsultLoan.IconColor = System.Drawing.Color.White;
            this.btnConsultLoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultLoan.IconSize = 44;
            this.btnConsultLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultLoan.Location = new System.Drawing.Point(0, 40);
            this.btnConsultLoan.Name = "btnConsultLoan";
            this.btnConsultLoan.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.btnConsultLoan.Size = new System.Drawing.Size(200, 40);
            this.btnConsultLoan.TabIndex = 2;
            this.btnConsultLoan.Text = "Consult loan";
            this.btnConsultLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultLoan.UseVisualStyleBackColor = true;
            this.btnConsultLoan.Click += new System.EventHandler(this.btnConsultLoan_Click);
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateLoan.FlatAppearance.BorderSize = 0;
            this.btnCreateLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateLoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateLoan.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnCreateLoan.IconColor = System.Drawing.Color.White;
            this.btnCreateLoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateLoan.IconSize = 44;
            this.btnCreateLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateLoan.Location = new System.Drawing.Point(0, 0);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.btnCreateLoan.Size = new System.Drawing.Size(200, 40);
            this.btnCreateLoan.TabIndex = 1;
            this.btnCreateLoan.Text = "Create loan";
            this.btnCreateLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoan.FlatAppearance.BorderSize = 0;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.ForeColor = System.Drawing.Color.White;
            this.btnLoan.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.btnLoan.IconColor = System.Drawing.Color.White;
            this.btnLoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoan.IconSize = 46;
            this.btnLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoan.Location = new System.Drawing.Point(0, 250);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLoan.Size = new System.Drawing.Size(200, 45);
            this.btnLoan.TabIndex = 7;
            this.btnLoan.Text = "Loan";
            this.btnLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // subMenuUsers
            // 
            this.subMenuUsers.Controls.Add(this.btnCreateUser);
            this.subMenuUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuUsers.ForeColor = System.Drawing.Color.White;
            this.subMenuUsers.Location = new System.Drawing.Point(0, 210);
            this.subMenuUsers.Name = "subMenuUsers";
            this.subMenuUsers.Size = new System.Drawing.Size(200, 40);
            this.subMenuUsers.TabIndex = 6;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCreateUser.IconColor = System.Drawing.Color.White;
            this.btnCreateUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateUser.Location = new System.Drawing.Point(0, 0);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.btnCreateUser.Size = new System.Drawing.Size(200, 40);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Create user";
            this.btnCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUser.IconColor = System.Drawing.Color.White;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 44;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 165);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUser.Size = new System.Drawing.Size(200, 45);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnSimulator
            // 
            this.btnSimulator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSimulator.FlatAppearance.BorderSize = 0;
            this.btnSimulator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulator.ForeColor = System.Drawing.Color.White;
            this.btnSimulator.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnSimulator.IconColor = System.Drawing.Color.White;
            this.btnSimulator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSimulator.IconSize = 42;
            this.btnSimulator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimulator.Location = new System.Drawing.Point(0, 120);
            this.btnSimulator.Name = "btnSimulator";
            this.btnSimulator.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSimulator.Size = new System.Drawing.Size(200, 45);
            this.btnSimulator.TabIndex = 4;
            this.btnSimulator.Text = "Simulator";
            this.btnSimulator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimulator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimulator.UseVisualStyleBackColor = true;
            this.btnSimulator.Click += new System.EventHandler(this.btnSimulator_Click);
            // 
            // btnWallet
            // 
            this.btnWallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWallet.FlatAppearance.BorderSize = 0;
            this.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.ForeColor = System.Drawing.Color.White;
            this.btnWallet.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btnWallet.IconColor = System.Drawing.Color.White;
            this.btnWallet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWallet.IconSize = 44;
            this.btnWallet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWallet.Location = new System.Drawing.Point(0, 75);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnWallet.Size = new System.Drawing.Size(200, 45);
            this.btnWallet.TabIndex = 3;
            this.btnWallet.Text = "Wallet";
            this.btnWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWallet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWallet.UseVisualStyleBackColor = true;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(207)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 75);
            this.panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.lblForm);
            this.panel1.Controls.Add(this.iconFormChild);
            this.panel1.Controls.Add(this.lblNameUser);
            this.panel1.Controls.Add(this.pictureProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 58);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.Color.White;
            this.lblForm.Location = new System.Drawing.Point(58, 12);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(71, 30);
            this.lblForm.TabIndex = 6;
            this.lblForm.Text = "Home";
            // 
            // iconFormChild
            // 
            this.iconFormChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(207)))));
            this.iconFormChild.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconFormChild.IconColor = System.Drawing.Color.White;
            this.iconFormChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFormChild.IconSize = 40;
            this.iconFormChild.Location = new System.Drawing.Point(12, 11);
            this.iconFormChild.Name = "iconFormChild";
            this.iconFormChild.Size = new System.Drawing.Size(40, 40);
            this.iconFormChild.TabIndex = 11;
            this.iconFormChild.TabStop = false;
            // 
            // lblNameUser
            // 
            this.lblNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblNameUser.ForeColor = System.Drawing.Color.White;
            this.lblNameUser.Location = new System.Drawing.Point(398, 14);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNameUser.Size = new System.Drawing.Size(296, 23);
            this.lblNameUser.TabIndex = 10;
            this.lblNameUser.Text = "IVAN DAVID BERMUDEZ CASTAÑEDA";
            this.lblNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureProfile
            // 
            this.pictureProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureProfile.BaseColor = System.Drawing.Color.IndianRed;
            this.pictureProfile.Location = new System.Drawing.Point(700, 9);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Radius = 18;
            this.pictureProfile.Size = new System.Drawing.Size(35, 35);
            this.pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProfile.TabIndex = 4;
            this.pictureProfile.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 58);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(750, 542);
            this.pnlMain.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sideMenuPanel);
            this.MinimumSize = new System.Drawing.Size(966, 639);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartera Facil";
            this.sideMenuPanel.ResumeLayout(false);
            this.subMenuLoan.ResumeLayout(false);
            this.subMenuUsers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnWallet;
        private FontAwesome.Sharp.IconButton btnSimulator;
        private FontAwesome.Sharp.IconButton btnUser;
        private System.Windows.Forms.Panel subMenuUsers;
        private FontAwesome.Sharp.IconButton btnCreateUser;
        private FontAwesome.Sharp.IconButton btnLoan;
        private System.Windows.Forms.Panel subMenuLoan;
        private FontAwesome.Sharp.IconButton btnConsultLoan;
        private FontAwesome.Sharp.IconButton btnCreateLoan;
        private FontAwesome.Sharp.IconButton btnToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMain;
        private Guna.UI.WinForms.GunaPictureBox pictureProfile;
        private System.Windows.Forms.Label lblNameUser;
        private FontAwesome.Sharp.IconPictureBox iconFormChild;
        private System.Windows.Forms.Label lblForm;
    }
}