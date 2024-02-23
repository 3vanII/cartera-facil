using Cartera_Facil.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartera_Facil.View
{
    public partial class ChangePassword : Form
    {
        ViewFunctions obj = new ViewFunctions();
        Entities2 entities = new Entities2();
        private string email;
        private string code;
        public ChangePassword(string email, string code)
        {
            InitializeComponent();
            this.email = email;
            this.code = code;
            obj.AssignIndicativeText(txtCode, "security code");
            obj.AssignIndicativeText(txtPassword, "Password");
            obj.AssignIndicativeText(txtConfirmPassword, "Confirm password");
            lblTitle.Select();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateCredentials()
        {
            if(code == txtCode.Text)
                lblCodeInvalid.Visible = false;
            else
                lblCodeInvalid.Visible = true;

            if(txtPassword.Text == txtConfirmPassword.Text)
                lblPasswordsDoNotMatch.Visible = false;
            else
                lblPasswordsDoNotMatch.Visible = true;

            if((code == txtCode.Text) && (txtPassword.Text == txtConfirmPassword.Text))
                return true;
            else
                return false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (ValidateCredentials())
            {
                try
                {
                    var user = entities.USUARIOS.FirstOrDefault(u => u.EMAIL == email);
                    if (user != null)
                    {
                        user.PASSWORD = obj.HashPassword(txtConfirmPassword.Text);
                        entities.SaveChanges();
                        MessageBox.Show("Contraseña actualizada");
                        DialogResult = DialogResult.OK;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ChangePassword_Paint(object sender, PaintEventArgs e)
        {
            obj.FormRegionAndBorder(this, 20, e.Graphics, Color.FromArgb(255, 255, 255), 2);
        }

        private void ChangePassword_MouseDown(object sender, MouseEventArgs e)
        {
            ViewFunctions.ReleaseCapture();
            ViewFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxShowPassword_Click(object sender, EventArgs e)
        {
            pictureBoxShowPassword.Visible = false;
            pictureBoxHidePassword.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '\0';
            txtConfirmPassword.UseSystemPasswordChar = false;
            txtConfirmPassword.PasswordChar = '\0';
        }

        private void pictureBoxHidePassword_Click(object sender, EventArgs e)
        {
            pictureBoxHidePassword.Visible = false;
            pictureBoxShowPassword.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.PasswordChar = '*';
        }

        private void linkLabelResendCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            code = obj.GenerateRandomCode();
            obj.ComposeEmail(email, code);
            obj.Enviar();
            MessageBox.Show("Codigo reenviado");
            txtCode.Text = string.Empty;
            if (lblCodeInvalid.Visible == true)
                lblCodeInvalid.Visible = false;
        }
    }
}
