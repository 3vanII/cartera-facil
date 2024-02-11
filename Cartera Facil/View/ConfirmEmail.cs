using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cartera_Facil.View
{
    public partial class ConfirmEmail : Form
    {
        private string code; // Este es el campo de la clase ConfirmEmail para almacenar el código
        private ViewFunctions obj = new ViewFunctions(); // Objeto para acceder a los métodos de ViewFunctions
        private string email;

        public ConfirmEmail(string email)
        {
            InitializeComponent();
            obj.AssignIndicativeText(txtCode, "Ingresa el codigo");
            code = obj.GenerateRandomCode();
            lblTitle.Select();
            obj.ComposeEmail(email, code);
            obj.Enviar();
            lblInstructions.Text = $"Al correo {email}\nse ha enviado un código de confirmación";
            this.email = email;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(code == txtCode.Text)
            {
                lblCodeInvalid.Visible = false;
                DialogResult = DialogResult.OK;

            }
            else
            {
                lblCodeInvalid.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ConfirmEmail_MouseDown(object sender, MouseEventArgs e)
        {
            ViewFunctions.ReleaseCapture();
            ViewFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void linkLabelResendCode_MouseEnter(object sender, EventArgs e)
        {
            linkLabelResendCode.LinkColor = Color.Blue;
        }

        private void linkLabelResendCode_MouseLeave(object sender, EventArgs e)
        {
            linkLabelResendCode.LinkColor = Color.Black;
        }

        private void ConfirmEmail_Paint(object sender, PaintEventArgs e)
        {
            obj.FormRegionAndBorder(this, 20, e.Graphics, Color.FromArgb(255, 255, 255), 2);
        }
    }
}
