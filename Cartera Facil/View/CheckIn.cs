using Cartera_Facil.Model;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartera_Facil.View
{
    public partial class CheckIn : Form
    {
        ViewFunctions obj = new ViewFunctions();
        Entities2 entities = new Entities2();
        public CheckIn()
        {
            InitializeComponent();
            obj.LlenarCombobox(entities.DOCUMENTOS.ToList(), "ID", "DOCUMENTO", ComboBoxDocumentsType);
            AssignIndicativeText(txtIdentificationNumber, "Número de identificación");
            AssignIndicativeText(txtEmail, "myEmail@gmail.com");
            AssignIndicativeText(txtNames, "Nombres");
            AssignIndicativeText(txtSurnames, "Apellidos");
        }

        private void AssignIndicativeText(GunaTextBox textBox, string indicativeText)
        {
            // Asignar el texto de indicación al Tag del GunaTextBox
            textBox.Tag = indicativeText;
            // Asignar el evento Enter al GunaTextBox
            textBox.Enter += TextBox_Enter;
            // Asignar el evento Leave al GunaTextBox
            textBox.Leave += TextBox_Leave;
            // Mostrar el texto de indicación inicialmente
            ShowIndicativeText(textBox);
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            GunaTextBox textBox = (GunaTextBox)sender;
            // Cuando el GunaTextBox recibe el foco, limpiar el texto de indicación
            if (textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.SystemColors.WindowText; // Color de texto normal
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            GunaTextBox textBox = (GunaTextBox)sender;
            // Cuando el GunaTextBox pierde el foco, mostrar el texto de indicación si está vacío
            ShowIndicativeText(textBox);
        }

        private void ShowIndicativeText(GunaTextBox textBox)
        {
            string textoIndicacion = textBox.Tag.ToString();
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textoIndicacion;
                textBox.ForeColor = System.Drawing.SystemColors.GrayText; // Color de texto grisáceo
            }
        }

        private void CheckIn_MouseDown(object sender, MouseEventArgs e)
        {
            ViewFunctions.ReleaseCapture();
            ViewFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CheckIn_Paint(object sender, PaintEventArgs e)
        {
            obj.FormRegionAndBorder(this, 20, e.Graphics, Color.FromArgb(255, 255, 255), 2);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool CheckRequiredFields() //comprobar campos obligatorios
        {
            if (txtIdentificationNumber.Text == string.Empty || txtIdentificationNumber.Text == "Número de identificación")
                lblConfirmationIdentificationNumber.Visible = true;
            else
                lblConfirmationIdentificationNumber.Visible = false;

            if (txtNames.Text == string.Empty || txtNames.Text == "Nombres")
                lblConfirmationNames.Visible = true;
            else
                lblConfirmationNames.Visible = false;

            if (txtSurnames.Text == string.Empty || txtSurnames.Text == "Apellidos")
                lblConfirmationSurnames.Visible = true;
            else
                lblConfirmationSurnames.Visible = false;

            if (txtEmail.Text == string.Empty || txtEmail.Text == "myEmail@gmail.com")
                lblConfirmationEmail.Visible = true;
            else
                lblConfirmationEmail.Visible = false;

            if ((txtIdentificationNumber.Text == string.Empty || txtIdentificationNumber.Text == "Número de identificación") ||
                (txtNames.Text == string.Empty || txtNames.Text == "Nombres") ||
                (txtSurnames.Text == string.Empty || txtSurnames.Text == "Apellidos") ||
                (txtEmail.Text == string.Empty || txtEmail.Text == "myEmail@gmail.com"))
            {
                MessageBox.Show("Faltan datos por llenar");
                return true;
            }
            else
                return false;
        }

        private USUARIOS CaptureData()
        {
            USUARIOS ob = new USUARIOS();

            ob.ID = txtIdentificationNumber.Text;
            ob.DOCUMENTO_ID = (int)ComboBoxDocumentsType.SelectedValue;
            ob.NOMBRES = txtNames.Text.ToUpper();
            ob.APELLIDO = txtSurnames.Text.ToUpper();
            ob.EMAIL = txtEmail.Text.ToUpper();
            if(ob.EMAIL == obj.Email1)
                ob.ROL_ID = 100;
            else
                ob.ROL_ID= 101;
            ob.PASSWORD = txtIdentificationNumber.Text;
            ob.HABILITADO = "true";
            return ob;
        }

        private void ClearText()
        {
            txtIdentificationNumber.Text = string.Empty;
            txtNames.Text = string.Empty;
            txtSurnames.Text = string.Empty;
            txtEmail.Text = string.Empty;
            obj.LlenarCombobox(entities.DOCUMENTOS.ToList(), "ID", "DOCUMENTO", ComboBoxDocumentsType);
        }

        private void InsertData()
        {
            try
            {
                bool chekingData = obj.checkData(txtIdentificationNumber, txtEmail, lblIdentificationNumberInvalid, lblEmailInvalid);
                bool chekingRequiredFields = CheckRequiredFields();
                if (chekingData == false && chekingRequiredFields == false)
                {
                    DialogResult respuesta = MessageBox.Show("¿Los datos son correctos?",
                        "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        USUARIOS ob = CaptureData();
                        entities.USUARIOS.Add(ob);
                        entities.SaveChanges();
                        ClearText();
                        MessageBox.Show("Empleado guardado",
                        "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (DbUpdateException dbEx)
            {
                // Acceder a la excepción interna para obtener más detalles
                var innerException = dbEx.InnerException;

                // Mostrar detalles de la excepción interna
                MessageBox.Show("Error al guardar los datos. Detalles: " + innerException.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            
        }
    }
}
