using Cartera_Facil.Model;
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
    public partial class EditUser : Form
    {
        Entities3 entities = new Entities3();
        ViewFunctions obj = new ViewFunctions();
        private USUARIOS usuario;
        private string DefailPhoto = "C:/Users/nikol/Documents/proyectos/Cartera Facil/Cartera Facil/Img/agregar-usuario.png";
        public EditUser()
        {
            InitializeComponent();
        }

        public EditUser(string id)
        {
            usuario = (from u in entities.USUARIOS
                           where u.ID == id
                           select u).FirstOrDefault();
            InitializeComponent();
            obj.AssignIndicativeText(txtIdentificationNumber, $"{usuario.ID}");
            obj.AssignIndicativeText(txtNames, $"{usuario.NOMBRES}");
            obj.AssignIndicativeText(txtSurnames, $"{usuario.APELLIDO}");
            if(usuario.EMAIL == null)
            {
                obj.AssignIndicativeText(txtEmail, $"Email");
            }
            else
            {
                obj.AssignIndicativeText(txtEmail, $"{usuario.EMAIL}");
            }
            if(usuario.TELEFONO == null)
            {
                obj.AssignIndicativeText(txtPhone, $"Telefono");
            }
            else
            {
                obj.AssignIndicativeText(txtPhone, $"{usuario.TELEFONO}");
            }
            if(usuario.DIRECCION == null)
            {
                obj.AssignIndicativeText(txtResidenceAddress, $"Direccion");
            }
            else
            {
                obj.AssignIndicativeText(txtResidenceAddress, $"{usuario.DIRECCION}");
            }
            obj.LlenarCombobox(entities.DOCUMENTOS.ToList(), "ID", "DOCUMENTO", ComboBoxDocumentsType, "Tipo de documento", usuario.DOCUMENTO_ID);
            obj.LlenarCombobox(entities.CARGOS.ToList(), "ID", "CARGO", ComboBoxCargo, "Cargo", usuario.CARGO_ID);
            obj.LlenarCombobox(entities.ROLES.ToList(), "ID", "ROL", ComboBoxRol, "Rol", usuario.ROL_ID);
            if(usuario.DEPARTAMENTO_ID == null)
            {
                obj.LlenarCombobox(entities.DEPARTAMENTOS.OrderBy(dpto => dpto.DEPARTAMENTO).ToList(), "ID", "DEPARTAMENTO", ComboBoxDepartaments, "Departamento");
            }
            else
            {
                obj.LlenarCombobox(entities.DEPARTAMENTOS.OrderBy(dpto => dpto.DEPARTAMENTO).ToList(), "ID", "DEPARTAMENTO", ComboBoxDepartaments, "Departamento", usuario.DEPARTAMENTO_ID);
            }
            if(usuario.FOTO == null)
            {
                ViewFunctions.Image2Byte(obj.UploadPhotoByDefault
                    (DefailPhoto, ptbhoto));
            }
            else
            {
                obj.ShowImageInPictureBox(usuario.FOTO, ptbhoto);
            }
        }

        private void ComboBoxDepartaments_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboBoxDepartaments.SelectedItem != null)
            {
                if(usuario.MUNICIPIO_ID != null)
                {
                    obj.LlenarCombobox(entities.MUNICIPIOS
                        .Where(m => m.DEPARTAMENTO_ID == ((DEPARTAMENTOS)ComboBoxDepartaments.SelectedItem).ID)
                        .OrderBy(m => m.MUNICIPIO)
                        .ToList(), "ID", "MUNICIPIO", ComboBoxCity, "Municipios", usuario.MUNICIPIO_ID);
                }
                else
                {
                    obj.LlenarCombobox(entities.MUNICIPIOS
                        .Where(m => m.DEPARTAMENTO_ID == ((DEPARTAMENTOS)ComboBoxDepartaments.SelectedItem).ID)
                        .OrderBy(m => m.MUNICIPIO)
                        .ToList(), "ID", "MUNICIPIO", ComboBoxCity, "Municipios");
                }
            }

            
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
                lblConfirmationSurnames.Visible = false;

            if (txtResidenceAddress.Text == string.Empty)
                lblConfirmationResidenceAddress.Visible = true;
            else
                lblConfirmationResidenceAddress.Visible = false;

            if (txtPhone.Text == string.Empty)
                lblConfirmationPhone.Visible = true;
            else
                lblConfirmationPhone.Visible = false;

            if (txtEmail.Text == string.Empty)
                lblConfirmationEmail.Visible = true;
            else
                lblConfirmationEmail.Visible = false;

            if ((txtIdentificationNumber.Text == string.Empty) ||
                (txtNames.Text == string.Empty) ||
                (txtSurnames.Text == string.Empty) ||
                (txtResidenceAddress.Text == string.Empty) ||
                (txtPhone.Text == string.Empty) ||
                (txtEmail.Text == string.Empty))
            {
                MessageBox.Show("Faltan datos por llenar");
                return true;
            }
            else
                return false;
        }

        private void CheckData()
        {
            if ((obj.CheckDocumentNumber(txtIdentificationNumber)) && (txtIdentificationNumber.Text != usuario.ID))
            {
                lblIdentificationNumberInvalid.Visible = true;
            }
            if((obj.CheckEmail(txtEmail)) && (txtEmail.Text.ToUpper() != usuario.EMAIL))
            {
                lblEmailInvalid.Visible = true;
            }

        }

        private USUARIOS CaptureData()
        {
            USUARIOS ob = new USUARIOS();

            ob.ID = txtIdentificationNumber.Text;
            ob.DOCUMENTO_ID = (int)ComboBoxDocumentsType.SelectedValue;
            ob.NOMBRES = txtNames.Text.ToUpper();
            ob.APELLIDO = txtSurnames.Text.ToUpper();
            ob.DEPARTAMENTO_ID = (int)ComboBoxDepartaments.SelectedValue;
            ob.MUNICIPIO_ID = (int)ComboBoxCity.SelectedValue;
            ob.DIRECCION = txtResidenceAddress.Text.ToUpper();
            ob.ROL_ID = (int)ComboBoxRol.SelectedValue;
            ob.EMAIL = txtEmail.Text.ToUpper();
            ob.CARGO_ID = (int)ComboBoxCargo.SelectedValue;
            ob.FOTO = ViewFunctions.Image2Byte(obj.UploadPhotoByDefault(DefailPhoto, ptbhoto));
            ob.PASSWORD = txtIdentificationNumber.Text;
            ob.TELEFONO = txtPhone.Text;
            ob.HABILITADO = "true";
            return ob;
        }

        private void InsertData()
        {
            try
            {
                CheckData();
                //bool chekingRequiredFields = CheckRequiredFields();
                //if (chekingRequiredFields == false)
                //{
                //    DialogResult respuesta = MessageBox.Show("¿Los datos son correctos?",
                //        "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //    if (respuesta == DialogResult.Yes)
                //    {
                //        USUARIOS ob = CaptureData();
                //        entities.USUARIOS.Add(ob);
                //        entities.SaveChanges();
                //        MessageBox.Show("Empleado guardado",
                //        "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        this.Close();
                //    }
                //}

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
