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
            this.btnEditUser = new FontAwesome.Sharp.IconButton();
            this.btnCreateUser = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnSimulator = new FontAwesome.Sharp.IconButton();
            this.btnWallet = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            this.subMenuLoan.SuspendLayout();
            this.subMenuUsers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.AutoScroll = true;
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
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
            this.btnToday.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnToday.IconColor = System.Drawing.Color.Black;
            this.btnToday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToday.IconSize = 44;
            this.btnToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.Location = new System.Drawing.Point(0, 415);
            this.btnToday.Name = "btnToday";
            this.btnToday.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnToday.Size = new System.Drawing.Size(200, 45);
            this.btnToday.TabIndex = 9;
            this.btnToday.Text = "Today";
            this.btnToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToday.UseVisualStyleBackColor = true;
            // 
            // subMenuLoan
            // 
            this.subMenuLoan.Controls.Add(this.btnConsultLoan);
            this.subMenuLoan.Controls.Add(this.btnCreateLoan);
            this.subMenuLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuLoan.Location = new System.Drawing.Point(0, 335);
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
            this.btnConsultLoan.IconColor = System.Drawing.Color.Black;
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
            this.btnCreateLoan.IconColor = System.Drawing.Color.Black;
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
            this.btnLoan.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.btnLoan.IconColor = System.Drawing.Color.Black;
            this.btnLoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoan.IconSize = 46;
            this.btnLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoan.Location = new System.Drawing.Point(0, 290);
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
            this.subMenuUsers.Controls.Add(this.btnEditUser);
            this.subMenuUsers.Controls.Add(this.btnCreateUser);
            this.subMenuUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuUsers.Location = new System.Drawing.Point(0, 210);
            this.subMenuUsers.Name = "subMenuUsers";
            this.subMenuUsers.Size = new System.Drawing.Size(200, 80);
            this.subMenuUsers.TabIndex = 6;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditUser.IconColor = System.Drawing.Color.Black;
            this.btnEditUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUser.Location = new System.Drawing.Point(0, 40);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.btnEditUser.Size = new System.Drawing.Size(200, 40);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit user";
            this.btnEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCreateUser.IconColor = System.Drawing.Color.Black;
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
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUser.IconColor = System.Drawing.Color.Black;
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
            this.btnSimulator.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnSimulator.IconColor = System.Drawing.Color.Black;
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
            // 
            // btnWallet
            // 
            this.btnWallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWallet.FlatAppearance.BorderSize = 0;
            this.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btnWallet.IconColor = System.Drawing.Color.Black;
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
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(195)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 75);
            this.panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 75);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minimizeButton.Location = new System.Drawing.Point(629, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeButton.Location = new System.Drawing.Point(722, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMaximize.Location = new System.Drawing.Point(691, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.TabStop = false;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRestore.Location = new System.Drawing.Point(660, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(25, 25);
            this.btnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestore.TabIndex = 5;
            this.btnRestore.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 75);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(750, 525);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.sideMenuPanel.ResumeLayout(false);
            this.subMenuLoan.ResumeLayout(false);
            this.subMenuUsers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
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
        private FontAwesome.Sharp.IconButton btnEditUser;
        private System.Windows.Forms.Panel subMenuLoan;
        private FontAwesome.Sharp.IconButton btnConsultLoan;
        private FontAwesome.Sharp.IconButton btnCreateLoan;
        private FontAwesome.Sharp.IconButton btnToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox btnRestore;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.Panel pnlMain;
    }
}