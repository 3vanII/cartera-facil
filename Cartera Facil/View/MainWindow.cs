using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Cartera_Facil.View
{
    public partial class MainWindow : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        ViewFunctions view = new ViewFunctions();
        public MainWindow()
        {
            InitializeComponent();
            CustomizeDesing();
            this.Padding = new Padding(2);
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void CustomizeDesing()
        {
            subMenuLoan.Visible = false;
            subMenuUsers.Visible = false;   
        }

        private void HideSubMenu()
        {
            if (subMenuLoan.Visible == true)
                subMenuLoan.Visible = false;
            if (subMenuUsers.Visible == true)
                subMenuUsers.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuUsers);
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuLoan);
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            /*escribe
                tu
                codigo
                aqui*/
            HideSubMenu();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            /*escribe
                tu
                codigo
                aqui*/
            HideSubMenu();
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            /*escribe
                tu
                codigo
                aqui*/
            HideSubMenu();
        }

        private void btnConsultLoan_Click(object sender, EventArgs e)
        {
            /*escribe
                tu
                codigo
                aqui*/
            HideSubMenu();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ViewFunctions.ReleaseCapture();
            ViewFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
