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
using System.Windows.Input;

namespace Cartera_Facil.View
{
    public partial class Users : Form
    {
        ViewFunctions obj = new ViewFunctions();  
        public Users()
        {
            InitializeComponent();
            obj.AssignIndicativeText(txtIdentificationNumber, "Id number");
            obj.AssignIndicativeText(txtName, "Name");
            groupBoxSearchEmployee.Select();
        }

        private void FillGrid()
        {
            try
            {
                if ((txtIdentificationNumber.Text != "Id number") && (txtIdentificationNumber.Text != string.Empty))
                    dtgvEmployees.DataSource = obj.GetSales(txtIdentificationNumber.Text);
  
                else if ((txtName.Text != "Name") && (txtName.Text != string.Empty))
                    dtgvEmployees.DataSource = obj.GetSales(txtName.Text);

                else
                    dtgvEmployees.DataSource = obj.GetSales(string.Empty);

                dtgvEmployees.Columns["Identificacion"].DisplayIndex = 0;
                dtgvEmployees.Columns["Nombre"].DisplayIndex = 1;
                dtgvEmployees.Columns["Apellido"].DisplayIndex = 2;
                dtgvEmployees.Columns["Cargo"].DisplayIndex = 3;
                dtgvEmployees.Columns["Telefono"].DisplayIndex = 4;
                dtgvEmployees.Columns["Email"].DisplayIndex = 5;
                dtgvEmployees.Columns["Detalle"].DisplayIndex = 6;
                dtgvEmployees.Columns["Editar"].DisplayIndex = 7;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void Restore()
        {
            txtIdentificationNumber.Text = string.Empty;
            txtName.Text = string.Empty;
            obj.AssignIndicativeText(txtIdentificationNumber, "Id number");
            obj.AssignIndicativeText(txtName, "Name");
            if( lblIdentificationNotRegistered.Visible == true)
                lblIdentificationNotRegistered.Visible = false;
            FillGrid();
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            if ((txtIdentificationNumber.Text == string.Empty) && (lblIdentificationNotRegistered.Visible == true))
                lblIdentificationNotRegistered.Visible = false;
            else if ((obj.CheckDocumentNumber(txtIdentificationNumber) == false) && (txtIdentificationNumber.Text != "Id number"))
                lblIdentificationNotRegistered.Visible = true;
            
            FillGrid();


        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void dtgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvEmployees.Columns[e.ColumnIndex].Name == "Detalle")
            {
                string id = dtgvEmployees.CurrentRow.Cells["Identificacion"].Value.ToString();
                UserView userView = new UserView(id);
                userView.Show();
            }

            else if ((dtgvEmployees.Columns[e.ColumnIndex].Name == "Editar") && 
                ((AuthenticatedUser.ROLE == "ADMIN") || (AuthenticatedUser.ROLE == "USER_WRITER")))
            {
                string id = dtgvEmployees.CurrentRow.Cells["Identificacion"].Value.ToString();
                EditUser userEdit = new EditUser(id);   
                userEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("No posees los permisos de acceso", "Cartera Facil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
