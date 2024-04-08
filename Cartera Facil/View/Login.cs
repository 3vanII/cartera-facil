using Cartera_Facil.Model;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Cartera_Facil.View
{
    public partial class Login : Form
    {
        ViewFunctions view = new ViewFunctions();
        Color colorOriginal = Color.FromArgb(217, 217, 217);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        public Login()
        {
            InitializeComponent();
            this.Padding = new Padding(2);
            this.BackColor = Color.FromArgb(255, 255, 255);
            view.AssignIndicativeText(txtUser, "myUser@dominio.com");
            view.AssignIndicativeText(txtPassword, "myPassword");
            businessLogo.Select();
        }

        private void panelContainer_MouseDown(object sender, MouseEventArgs e)
        {
            ViewFunctions.ReleaseCapture();
            ViewFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            view.FormRegionAndBorder(this, 20, e.Graphics, Color.FromArgb(255, 255, 255), 2);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            var (usuario, credencialesValidas) = ConfirmationCredentials(txtUser, txtPassword, lblUserInvalid, lblPasswordInvalid);
            if (credencialesValidas)
            {
                this.Hide();
                MainWindow main = new MainWindow();
                main.FormClosed += (s, args) => this.Close();
                main.Show();
            }
        }

        private void linkLabelRecoverPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoverPassword recoverPassword = new RecoverPassword();
            recoverPassword.ShowDialog();
        }

        private void linkLabelCreateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckIn check = new CheckIn();
            this.Hide();
            check.Show();
        }

        private void linkLabelCreateUser_MouseEnter(object sender, EventArgs e)
        {
            linkLabelCreateUser.LinkColor = Color.Blue;
        }

        private void linkLabelCreateUser_MouseLeave(object sender, EventArgs e)
        {
            linkLabelCreateUser.LinkColor = Color.Black;
        }

        private void linkLabelRecoverPass_MouseEnter(object sender, EventArgs e)
        {
            linkLabelRecoverPass.LinkColor = Color.Blue;
        }

        private void linkLabelRecoverPass_MouseLeave(object sender, EventArgs e)
        {
            linkLabelRecoverPass.LinkColor = Color.Black;
        }

        private void pictureBoxShowPassword_Click(object sender, EventArgs e)
        {
            pictureBoxShowPassword.Visible = false;
            pictureBoxHidePassword.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '\0';
        }

        private void pictureBoxHidePassword_Click(object sender, EventArgs e)
        {
            pictureBoxHidePassword.Visible=false;
            pictureBoxShowPassword.Visible=true;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '*';
        }

        public static (USUARIOS, bool) ConfirmationCredentials(GunaTextBox user, GunaTextBox password, Label userInvalid, Label passInvalid)
        {
            ViewFunctions obj = new ViewFunctions();
            bool validateUser = obj.CheckEmail(user);
            string passwordEncript = obj.HashPassword(password.Text);
            bool credentialsValid = false;
            USUARIOS authenticatedUser = null;
            if (validateUser)
            {
                userInvalid.Visible = false;
                using (Entities3 db = new Entities3())
                {
                    authenticatedUser = db.USUARIOS
                        .Where(u => u.EMAIL == user.Text.ToUpper() && u.PASSWORD == passwordEncript && u.HABILITADO == "true")
                        .FirstOrDefault();
                    if(authenticatedUser == null)
                    {
                        passInvalid.Visible = true;
                    }
                    else
                    {
                        passInvalid.Visible = false;
                        credentialsValid = true;
                        AuthenticatedUser.ID = authenticatedUser.ID;
                        AuthenticatedUser.NOMBRES = authenticatedUser.NOMBRES;
                        AuthenticatedUser.APELLIDO = authenticatedUser.APELLIDO;
                        AuthenticatedUser.CARGO_ID = authenticatedUser.CARGO_ID;
                        AuthenticatedUser.FOTO = authenticatedUser.FOTO;
                        AuthenticatedUser.EMAIL = authenticatedUser.EMAIL;
                        AuthenticatedUser.HABILITADO = authenticatedUser.HABILITADO;
                    }
                }

            }
            else
            {
                userInvalid.Visible = true;
            }
            return (authenticatedUser, credentialsValid);
        }
    }
}
