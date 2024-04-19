using Cartera_Facil.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UserView : Form
    {
        Entities3 db = new Entities3();
        public UserView()
        {
            InitializeComponent();
        }

        public UserView(string id)
        {
            InitializeComponent();
            var usuario = (from u in db.USUARIOS
                           where u.ID == id
                           select u).FirstOrDefault();
            lbldocumentType.Text = (from documentType in db.DOCUMENTOS
                                    where documentType.ID == usuario.DOCUMENTO_ID
                                    select documentType.DOCUMENTO).FirstOrDefault();
            lblIdentificationNumber.Text = usuario.ID;
            lblNames.Text = usuario.NOMBRES;
            lblLastName.Text = usuario.APELLIDO;
            lblDepartament.Text = (from departaments in db.DEPARTAMENTOS
                                   where departaments.ID == usuario.DEPARTAMENTO_ID
                                   select departaments.DEPARTAMENTO).FirstOrDefault().ToUpper();
            lblMunicipality.Text = (from municipality in db.MUNICIPIOS
                                    where municipality.ID == usuario.MUNICIPIO_ID
                                    select municipality.MUNICIPIO).FirstOrDefault().ToUpper();
            lblAddress.Text = usuario.DIRECCION;
            lblPhone.Text = usuario.TELEFONO;
            lblEmail.Text = usuario.EMAIL;
            lblPost.Text = (from post in db.CARGOS
                            where post.ID == usuario.CARGO_ID
                            select post.CARGO).FirstOrDefault().ToUpper();
            lblRole.Text = (from rol in db.ROLES
                            where rol.ID == usuario.ROL_ID
                            select rol.ROL).FirstOrDefault().ToUpper();
            lblEnabled.Text = usuario.HABILITADO.ToUpper();
        }
    }
}
