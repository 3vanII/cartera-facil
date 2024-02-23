using Cartera_Facil.Model;
using iTextSharp.text.pdf.qrcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Cartera_Facil.View
{
    public partial class RecoverPassword : Form
    {
        ViewFunctions view = new ViewFunctions();
        private string email;

        public string Email { get => email; set => email = value; }

        public RecoverPassword()
        {
            InitializeComponent();
            this.Padding = new Padding(2);
            this.BackColor = Color.FromArgb(255, 255, 255);
            view.AssignIndicativeText(tbxEmail, "myEmail@dominio.com");
            lblTitle.Select();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RecoverPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ViewFunctions.ReleaseCapture();
            ViewFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RecoverPassword_Paint(object sender, PaintEventArgs e)
        {
            view.FormRegionAndBorder(this, 20, e.Graphics, Color.FromArgb(255, 255, 255), 2);
        }

        private void ValidateEmail()
        {
            if (tbxEmail.Text != "myEmail@dominio.com")
            {
                lblConfirmationEmail.Visible = false;
                ViewFunctions obj = new ViewFunctions();
                if (obj.CheckEmail(tbxEmail))
                {
                    try
                    {
                        lblEmailInvalid.Visible = false;
                        string code = obj.GenerateRandomCode();
                        obj.ComposeEmail(tbxEmail.Text.ToUpper(), code);
                        obj.Enviar();
                        this.Hide();
                        using (var changePass = new ChangePassword(Email, code))
                        {
                            if (changePass.ShowDialog() == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    lblEmailInvalid.Visible = true;
                }
            }
            else
            {
                lblConfirmationEmail.Visible = true;
                MessageBox.Show("Faltan campos por llenar");
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            ValidateEmail();
        }
    }
}
