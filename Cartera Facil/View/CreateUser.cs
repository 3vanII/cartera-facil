using Cartera_Facil.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Data.Entity.Infrastructure;

namespace Cartera_Facil.View
{
    public partial class CreateUser : Form
    {
        ViewFunctions obj = new ViewFunctions();
        Entities2 entities = new Entities2();
        private string DefailPhoto = "C:/Users/nikol/Documents/proyectos/Cartera Facil/Cartera Facil/Img/agregar-usuario.png";
        public CreateUser()
        {
            InitializeComponent();
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            obj.LlenarCombobox(entities.DOCUMENTOS.ToList(), "ID", "DOCUMENTO", ComboBoxDocumentsType, "Tipo de documento");
            obj.LlenarCombobox(entities.ROLES.ToList(), "ID", "CARGO", ComboBoxRol, "Cargo");
            obj.LlenarCombobox(entities.DEPARTAMENTOS.OrderBy(dpto =>dpto.DEPARTAMENTO).ToList(), "ID", "DEPARTAMENTO", ComboBoxDepartaments, "Departamento");
            obj.AssignIndicativeText(txtIdentificationNumber, "Número de documento");
            obj.AssignIndicativeText(txtNames, "Nombres");
            obj.AssignIndicativeText(txtSurnames, "Apellidos");
            obj.AssignIndicativeText(txtEmail, "MyEmail@dominio.com");
            obj.AssignIndicativeText(txtPhone, "Telefono");
            obj.AssignIndicativeText(txtResidenceAddress, "Direccion");
        }

        private void ComboBoxDepartaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.LlenarCombobox(entities.MUNICIPIOS
                    .Where(m => m.DEPARTAMENTO_ID == ((DEPARTAMENTOS)ComboBoxDepartaments.SelectedItem).ID)
                    .OrderBy(m => m.MUNICIPIO)
                    .ToList(), "ID", "MUNICIPIO", ComboBoxCity, "Municipios");
        }

        private bool CheckRequiredFields() //comprobar campos obligatorios
        {
            if (txtIdentificationNumber.Text == string.Empty)
                lblConfirmationIdentificationNumber.Visible = true;
            else
                lblConfirmationIdentificationNumber.Visible = false;
      
            if (txtNames.Text == string.Empty)
                lblConfirmationNames.Visible = true;
            else
                lblConfirmationNames.Visible = false;

            if (txtSurnames.Text == string.Empty)
                lblConfirmationSurnames.Visible = true;
            else
                lblConfirmationSurnames.Visible= false;

            if (txtResidenceAddress.Text == string.Empty)
                lblConfirmationResidenceAddress.Visible = true;
            else
                lblConfirmationResidenceAddress.Visible= false;

            if (txtPhone.Text == string.Empty)
                lblConfirmationPhone.Visible = true;
            else
                lblConfirmationPhone.Visible= false;

            if (txtEmail.Text == string.Empty)  
                lblConfirmationEmail.Visible = true;
            else
                lblConfirmationEmail.Visible= false;

            if((txtIdentificationNumber.Text == string.Empty) || (txtNames.Text == string.Empty) || (txtSurnames.Text == string.Empty) 
                || (txtResidenceAddress.Text == string.Empty) || (txtPhone.Text == string.Empty)
                || (txtEmail.Text == string.Empty))
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
            ob.DOCUMENTO_ID= (int)ComboBoxDocumentsType.SelectedValue;
            ob.NOMBRES = txtNames.Text.ToUpper();
            ob.APELLIDO = txtSurnames.Text.ToUpper();
            ob.DEPARTAMENTO_ID = (int)ComboBoxDepartaments.SelectedValue;
            ob.MUNICIPIO_ID = (int)ComboBoxCity.SelectedValue;
            ob.DIRECCION = txtResidenceAddress.Text.ToUpper();
            ob.ROL_ID = (int)ComboBoxRol.SelectedValue;
            ob.EMAIL = txtEmail.Text.ToUpper();
            if (ptbhoto != null)
                ob.FOTO = ViewFunctions.Image2Byte(ptbhoto.Image);
            else
            {
                ob.FOTO = ViewFunctions.Image2Byte(obj.UploadPhotoByDefault
                    (DefailPhoto, ptbhoto));
            }
            ob.PASSWORD = txtIdentificationNumber.Text;
            ob.TELEFONO = txtPhone.Text;
            ob.HABILITADO = "true";
            return ob;
        }

        private void ClearText()
        {
            txtIdentificationNumber.Text = string.Empty;
            txtNames.Text = string.Empty;
            txtSurnames.Text = string.Empty;    
            txtResidenceAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;  
            ptbhoto.Image = Image.FromFile(DefailPhoto);
            CargarComboBox();
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

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            InsertData();
        }

        private void ptbhoto_Click(object sender, EventArgs e)
        {
            obj.UploadImage(ptbhoto);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }

}
